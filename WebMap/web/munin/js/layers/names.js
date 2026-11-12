// ForgeMap: the land named -- landmasses, ranges and their peaks, lakes, bays, rivers along their
// course -- over Munin's map, drawn by ForgeMap's own drawNames (map-core.js, loaded by the page as
// the global MapCore) into a canvas the size of the map, again at every move and zoom. A click on a
// name opens its card: what /at knows of the place, and a member may rename it (/names).
//
// MapCore draws in its texture's pixels (2048 of 12 m, north up); Leaflet in metres. Both are
// linear in x and z with north up, so the view is the screen point of the world's middle and the
// screen pixels per texture pixel: 12 m times Leaflet's pixels per metre.

import { fromLatLng, toLatLng } from '../crs.js';
import { layerState } from '../layerstate.js';
import { whoami, writeHeaders, canSignIn, signIn } from '../forgeauth.js';

// (MapCore is a classic script's top-level const: a global name, but not a property of window)
const MC = MapCore, T = (s, v) => window.I18N.t(s, v);
const KIND = { continent: 'Continent', island: 'Island', holm: 'Holm', range: 'Mountain range', lake: 'Lake', bay: 'Bay',
  river: 'River', forest: 'Black Forest', swamp: 'Swamp', plains: 'Plains', meadows: 'Meadows',
  mistlands: 'Mistlands', ashlands: 'Ashlands', north: 'Deep North' };
const kindName = (k) => (KIND[k] ? T(KIND[k]) : k);
const esc = (s) => String(s ?? '').replace(/[&<>"']/g, (c) => ({ '&': '&amp;', '<': '&lt;', '>': '&gt;', '"': '&quot;', "'": '&#39;' }[c]));
const dec1 = (n) => window.I18N.num(n, { minimumFractionDigits: 1, maximumFractionDigits: 1 });
const km2 = (a) => (a >= 1 ? dec1(a) + ' km²' : Math.round(a * 100) + ' ha');

export class NamesLayer extends L.Layer {
  constructor() {
    super();
    this.features = []; this.boxes = []; this.fog = null; this.frame = 0; this.on_ = layerState.placeNames !== false;
  }

  onAdd(map) {
    this.map = map;
    if (!map.getPane('fmNames')) { const p = map.createPane('fmNames'); p.style.zIndex = 590; p.style.pointerEvents = 'none'; }
    this.canvas = L.DomUtil.create('canvas', 'fm-names', map.getPane('fmNames'));
    this.g = this.canvas.getContext('2d');
    map.on('move zoom viewreset resize', this.request, this);
    map.on('click', this.click, this);
    this.load();
    this.timer = setInterval(() => this.load(), 60000);   // renamed places, new walked ground
    this.request();
  }

  onRemove(map) {
    map.off('move zoom viewreset resize', this.request, this);
    map.off('click', this.click, this);
    clearInterval(this.timer);
    this.canvas.remove(); this.boxes = [];
  }

  setOn(v) { this.on_ = v; this.request(); }

  async load() {
    try { await MC.fetchConfig(MC.cfg.api); } catch (e) { /* the default geometry */ }
    // the walked places only (the server leaves the rest out), each written where it was walked:
    // lx, lz, and a river along its walked stretch
    try {
      const j = await MC.fetchJSON(MC.cfg.api, '/features');
      this.features = ((j && j.features) || []).map((f) => Object.assign({}, f, { x: f.lx ?? f.x, z: f.lz ?? f.z, line: f.wline ?? f.line }));
    } catch (e) { /* none yet */ }
    // the explored mask names are read against, at the fog's own 12 m (MapCore.explored reads it at
    // 48 m, and a name at the edge showed over ground the map draws black)
    const img = new Image();
    img.onload = () => { this.fog = this.walked(img); this.request(); };
    img.src = MC.cfg.api + '/fog?t=' + Date.now();
    this.request();
  }

  // (px, py) in MapCore's texture pixels -> walked, from the fog picture at its full size
  walked(img) {
    const n = img.naturalWidth, c = document.createElement('canvas');
    c.width = c.height = n;
    const g = c.getContext('2d', { willReadFrequently: true });
    g.drawImage(img, 0, 0);
    let d;
    try { d = g.getImageData(0, 0, n, n).data; } catch (e) { return null; }
    const k = n / MC.geom.size;
    return (px, py) => { const x = Math.min(n - 1, Math.max(0, (px * k) | 0)), y = Math.min(n - 1, Math.max(0, (py * k) | 0)); return d[(y * n + x) * 4] > 127; };
  }

  request() { if (!this.frame) this.frame = requestAnimationFrame(() => { this.frame = 0; this.draw(); }); }

  draw() {
    const map = this.map; if (!map) return;
    const size = map.getSize(), pix = window.devicePixelRatio || 1;
    // the canvas stays on the screen while the map pane is dragged under it
    L.DomUtil.setPosition(this.canvas, map.containerPointToLayerPoint([0, 0]));
    if (this.canvas.width !== Math.round(size.x * pix) || this.canvas.height !== Math.round(size.y * pix)) {
      this.canvas.width = Math.round(size.x * pix); this.canvas.height = Math.round(size.y * pix);
      this.canvas.style.width = size.x + 'px'; this.canvas.style.height = size.y + 'px';
    }
    this.g.setTransform(1, 0, 0, 1, 0, 0);
    this.g.clearRect(0, 0, this.canvas.width, this.canvas.height);
    this.boxes = [];
    const ok = this.fog;
    if (!this.on_ || !ok || !this.features.length) return;
    const geom = MC.geom, mid = map.latLngToContainerPoint(toLatLng(0, 0));
    const metre = map.latLngToContainerPoint(toLatLng(1, 0)).x - mid.x;   // screen px per metre
    const scale = metre * geom.pixel, half = geom.size / 2;
    this.boxes = MC.drawNames(this.g, { scale, tx: mid.x - half * scale, ty: mid.y - half * scale, w: size.x, h: size.y, pix }, this.features, ok);
  }

  click(e) {
    if (!this.on_ || !this.boxes.length) return;
    const f = MC.hitName(this.boxes, e.containerPoint.x, e.containerPoint.y);
    if (f) this.openCard(f, e.latlng);
  }

  // the place's card: its kind, size, how much is walked, what stands on it; renaming for a member
  async openCard(f, latlng) {
    const { x, z } = fromLatLng(latlng);
    let here = [];
    try { here = (await MC.fetchJSON(MC.cfg.api, `/at?x=${x.toFixed(1)}&z=${z.toFixed(1)}`)).here || []; } catch (e) { /* unwalked: the name alone */ }
    const p = here.find((g) => g.id === f.id) || f;
    await whoami();
    const el = document.createElement('div');
    el.className = 'fm-place';
    const render = (editing, note) => {
      const bits = [kindName(p.kind), p.kind === 'river' ? (p.area >= 1000 ? T('{n} km long', { n: dec1(p.area / 1000) }) : T('{n} m long', { n: Math.round(p.area) })) : km2(p.area)];
      if (p.explored != null) bits.push(T('{n}% walked', { n: Math.round(p.explored * 100) }));
      const facts = [];
      if (p.elev) facts.push(p.kind === 'range' ? T('up to {n} m', { n: Math.round(p.elev.max) }) : `${Math.round(Math.max(0, p.elev.min))}–${Math.round(p.elev.max)} m`);
      if (p.builds) facts.push(window.I18N.tn(p.builds, '{n} piece built', '{n} pieces built'));
      if (p.portals) facts.push(window.I18N.tn(p.portals, '{n} portal', '{n} portals'));
      if (p.deaths) facts.push(window.I18N.tn(p.deaths, '{n} death', '{n} deaths'));
      const on = here.find((g) => g.id !== p.id && (g.kind === 'continent' || g.kind === 'island' || g.kind === 'holm'));
      if (on && !['continent', 'island', 'holm'].includes(p.kind)) facts.push(T('on {name}', { name: on.name }));
      const can = !!writeHeaders();
      el.innerHTML = `<small>${esc(bits.join(' · '))}</small>` +
        (editing
          ? `<form class="pin-form"><div class="row"><input name="n" maxlength="40" value="${esc(p.name)}" autocomplete="off"><button class="btn small" type="submit">${T('Save')}</button></div>
             <div class="row">${p.by ? `<button class="btn small" type="button" data-act="own" title="${T('Back to the name the world gave it')}">${T('Own name')}</button>` : ''}<button class="btn small" type="button" data-act="cancel">${T('Cancel')}</button></div></form>`
          : `<div class="fm-name"><b>${esc(p.name)}</b>` + (can ? `<button class="btn small" type="button" data-act="edit" title="${T('Rename')}">✎</button>` : '') + '</div>')
        + (facts.length ? `<small>${esc(facts.join(' · '))}</small>` : '')
        + `<small class="${note && note.bad ? 'err' : ''}">${note ? esc(note.text) : p.by ? esc(T('named by {name}', { name: p.by })) : esc(T(can ? "the world's own name" : "the world's own name · sign in to rename"))}</small>`
        + (!can && canSignIn() ? `<div class="pin-actions"><button class="btn small" type="button" data-act="in">${T('Sign in with Discord')}</button></div>` : '');
      // drawn again after the click is done: a button gone from the page mid-click reads to Leaflet as a
      // click on the map, which closes the popup
      const later = (fn) => () => setTimeout(fn, 0);
      el.querySelector('[data-act=edit]')?.addEventListener('click', later(() => render(true)));
      el.querySelector('[data-act=cancel]')?.addEventListener('click', later(() => render(false)));
      el.querySelector('[data-act=in]')?.addEventListener('click', () => signIn());
      el.querySelector('[data-act=own]')?.addEventListener('click', later(() => save('')));
      const form = el.querySelector('form');
      if (form) { form.addEventListener('submit', (ev) => { ev.preventDefault(); save(form.n.value); }); setTimeout(() => { form.n.focus(); form.n.select(); }, 30); }
    };
    const save = async (name) => {
      try {
        const r = await fetch(MC.cfg.api + '/names', { method: 'POST', headers: Object.assign({ 'Content-Type': 'application/json' }, writeHeaders() || {}), body: JSON.stringify({ id: p.id, name: name.trim() }) });
        const j = await r.json().catch(() => ({}));
        if (!r.ok) throw new Error(r.status === 403 ? T('not allowed: sign in again') : j.error || r.status);
        await this.load();
        const fresh = this.features.find((g) => g.id === p.id);
        if (fresh) { p.name = fresh.name; p.by = fresh.by; }
        render(false);
      } catch (e) { render(true, { bad: true, text: e.message || T('could not save') }); }
    };
    render(false);
    L.popup({ offset: [0, -4], className: 'fm-place-popup' }).setLatLng(latlng).setContent(el).openOn(this.map);
  }
}
