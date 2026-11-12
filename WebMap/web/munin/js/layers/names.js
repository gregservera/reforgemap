// ForgeMap: the land named -- landmasses, ranges and their peaks, lakes, bays, rivers along their
// course -- over Munin's map, drawn by ForgeMap's own drawNames (forgecanvas.js). A click on a name
// opens its card: what /at knows of the place, and a member may rename it (/names).

import { fromLatLng } from '../crs.js';
import { ForgeCanvas, MC } from './forgecanvas.js';
import { layerState } from '../layerstate.js';
import { whoami, writeHeaders, canSignIn, signIn } from '../forgeauth.js';

const T = (s, v) => window.I18N.t(s, v);
const KIND = { continent: 'Continent', island: 'Island', holm: 'Holm', range: 'Mountain range', lake: 'Lake', bay: 'Bay',
  river: 'River', forest: 'Black Forest', swamp: 'Swamp', plains: 'Plains', meadows: 'Meadows',
  mistlands: 'Mistlands', ashlands: 'Ashlands', north: 'Deep North' };
const kindName = (k) => (KIND[k] ? T(KIND[k]) : k);
const esc = (s) => String(s ?? '').replace(/[&<>"']/g, (c) => ({ '&': '&amp;', '<': '&lt;', '>': '&gt;', '"': '&quot;', "'": '&#39;' }[c]));
const dec1 = (n) => window.I18N.num(n, { minimumFractionDigits: 1, maximumFractionDigits: 1 });
const km2 = (a) => (a >= 1 ? dec1(a) + ' km²' : Math.round(a * 100) + ' ha');

export class NamesLayer extends ForgeCanvas {
  constructor() { super('fmNames', 590); this.features = []; this.boxes = []; this.on_ = layerState.placeNames !== false; }

  onAdd(map) { super.onAdd(map); map.on('click', this.click, this); }
  onRemove(map) { map.off('click', this.click, this); super.onRemove(map); this.boxes = []; }

  setOn(v) { this.on_ = v; this.request(); }

  // the walked places only (the server leaves the rest out), each written where it was walked:
  // lx, lz, and a river along its walked stretch
  async load() {
    try {
      const j = await MC.fetchJSON(MC.cfg.api, '/features');
      this.features = ((j && j.features) || []).map((f) => Object.assign({}, f, { x: f.lx ?? f.x, z: f.lz ?? f.z, line: f.wline ?? f.line }));
    } catch (e) { /* none yet */ }
  }

  paint(g, v, walked) {
    this.boxes = [];
    if (!this.on_ || !walked || !this.features.length) return;
    this.boxes = MC.drawNames(g, v, this.features, walked);
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
        await this.load(); this.request();
        const fresh = this.features.find((g) => g.id === p.id);
        if (fresh) { p.name = fresh.name; p.by = fresh.by; }
        render(false);
      } catch (e) { render(true, { bad: true, text: e.message || T('could not save') }); }
    };
    render(false);
    L.popup({ offset: [0, -4], className: 'fm-place-popup' }).setLatLng(latlng).setContent(el).openOn(this.map);
  }
}
