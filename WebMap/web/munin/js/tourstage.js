// ForgeMap: the cinematic tour (js/tour.js, ForgeMap 1.4's, the global Tour) on Munin's map. The
// tour flies a view of its own, in MapCore's texture pixels (scale, tx, ty: what the 1.4 map
// drew with), and reads the world as the 1.4 page held it. This gives it both on this page:
//   - V, that view, driving Leaflet: each frame's scale and offset become a centre and a zoom;
//   - WORLD, filled from /state, /features, /pieces, /stats/players and the fog;
//   - a legend whose details are ForgeMap's layers here (deaths, trails);
//   - the world's figures (js/spot.js, Spot.world).
//   - the 3D cuts, through tourcam.js (ticket tour-cinematique-3d).
// Started by its button in the bar, or by #tour in the address.

import { toLatLng, fromLatLng } from './crs.js';
import { TourCam } from './tourcam.js';

const MC = MapCore, API = MC.cfg.api, T = (s, v) => window.I18N.t(s, v);

export function setupTour(app) {
  if (typeof Tour === 'undefined' || typeof Spot === 'undefined') return;
  const map = app.map, stage = map.getContainer();

  // ---- the view, in texture pixels: screen = tx + px*scale (the same as layers/forgecanvas.js)
  const V = {
    get scale() { return MC.geom.pixel * map.options.crs.scale(map.getZoom()); },
    set scale(s) { this._s = s; },
    get tx() { return this.read().tx; }, set tx(v) { this._tx = v; },
    get ty() { return this.read().ty; }, set ty(v) { this._ty = v; },
    get fit() { const W = stage.clientWidth, H = stage.clientHeight; return Math.min(W, H) / MC.geom.size; },
    read() {
      const zoom = map.getZoom(), s = MC.geom.pixel * map.options.crs.scale(zoom), half = MC.geom.size / 2;
      const mid = map.project(toLatLng(0, 0), zoom).subtract(map.getPixelOrigin()).add(map._getMapPanePos());
      return { tx: mid.x - half * s, ty: mid.y - half * s };
    },
    // the screen point (sx, sy) as texture pixels
    at(sx, sy) { const w = fromLatLng(map.containerPointToLatLng([sx, sy])); return MC.toPx(w.x, w.z); },
    // what the tour set this frame, as a centre and a zoom
    request() {
      if (this._s === undefined) return;
      const s = this._s, W = stage.clientWidth, H = stage.clientHeight;
      const px = (W / 2 - this._tx) / s, py = (H / 2 - this._ty) / s, w = MC.toWorld(px, py);
      const zoom = Math.max(map.getMinZoom(), Math.min(map.getMaxZoom(), 7 + Math.log2(s / MC.geom.pixel)));
      map.setView(toLatLng(w.x, w.z), zoom, { animate: false });
      // a tour that stays in 3D flies the 3D camera the same way (tourcam.js)
      if (street.follow) street.follow(w.x, w.z, W / s * MC.geom.pixel);
    },
    fitWorld() { map.setView(toLatLng(0, 0), map.getMinZoom(), { animate: false }); },
  };

  // ---- the world, as the 1.4 page held it (what tour.js and Spot.world read)
  const WORLD = { state: null, rev: null, players: {}, vehicles: [], portals: [], graves: [], traders: [], deaths: [], forest: {}, pins: [],
    stats: null, pieces: null, builders: [], features: null, explored: null, box: null };
  const LAYERS = MC.layers(API, (k) => { if (k === 'fog') takeWalked(); });
  function takeWalked() { const w = MC.walked(LAYERS.imgs.fog); if (w) { WORLD.explored = w.share; WORLD.box = w.box; } }
  async function refresh() {
    try {
      const s = await MC.fetchState(API), px = (o) => MC.toPx(o.x, o.z);
      WORLD.players = s.players || {};
      WORLD.vehicles = ((s.vehicles || {}).vehicles || []).map((v) => ({ kind: v.kind, name: v.name, ...px(v) }));
      WORLD.portals = ((s.portals || {}).portals || []).map((p) => ({ id: p.id, name: p.name, to: p.to, ...px(p) }));
      WORLD.graves = ((s.graves || {}).graves || []).map((g) => ({ name: g.name, age: g.age, ...px(g) }));
      WORLD.traders = ((s.traders || {}).traders || []).map((t) => ({ name: t.name, ...px(t) }));
      WORLD.deaths = ((s.deaths || {}).deaths || []).map((d) => ({ name: d.n, t: d.t, ...MC.toPx(d.x, d.z) }));
      if (s.forest) WORLD.forest = s.forest;
      WORLD.pins = MC.parsePins(s.pins);
      WORLD.rev = s.rev; WORLD.state = s;
      await LAYERS.sync(s.rev, {
        features: (list) => { WORLD.features = list; },
        chart: true,
        pieces: (list, pj) => { WORLD.pieces = list; WORLD.builders = (pj && Array.isArray(pj.players)) ? pj.players : []; },
        onFog: () => setTimeout(takeWalked, 60),
      });
      try { WORLD.stats = await MC.fetchJSON(API, '/stats/players'); } catch (e) { /* the tallies later */ }
    } catch (e) { /* again in a moment */ }
  }

  // ---- the legend: the details a stop switches on are ForgeMap's layers here
  const LY = app.layers;
  const detailLayer = { deaths: LY.deaths, trails: LY.paths };
  const legend = {
    details: new Set(), off: new Set(), hidden: new Set(),
    showDetail(d) { const l = detailLayer[d]; return !l || l.on_; },
    setDetail(d, on) { const l = detailLayer[d]; if (l) { if (!on && l.who) l.who = null; l.setOn(on); } },
    showLayer() {}, applyHidden() {}, markDetails() {}, close() {},
  };
  const keep = {};   // the detail layers as they were when the tour began, put back as it stops

  // ---- the 3D: Munin's view, with the 1.4 tour's camera moves (tourcam.js); none when the server has it off
  const street = app.config?.enable_3d === false
    ? { view: null, on: false, load: () => Promise.reject(new Error('3D off')), feed() {}, armPeg() {}, letGo() {}, markMode() {}, leave() {} }
    : new TourCam(app);

  // ---- the page: its button, the caption, the figure card, the player card
  const box = document.createElement('div');
  box.className = 'fm-tour';
  box.innerHTML = '<div class="tourcap glass" id="tourcap" hidden><div class="eyebrow"></div><div class="tt"></div><div class="tl"></div><div class="ts"></div><div class="tp spot"></div></div>'
    + '<div class="spot glass tourfig" id="tourfig" hidden></div><div class="pcard glass fm-card" id="pcard" hidden></div>';
  stage.appendChild(box);
  const btn = document.createElement('button');
  btn.id = 'tourBtn'; btn.type = 'button'; btn.className = 'icon-btn fm-tour-btn';
  btn.title = T("Cinematic: a tour of the world's places, in 3D where the ground is walked. Any touch ends it.");
  btn.innerHTML = '&#9654;';
  const home = document.getElementById('btn-home');
  home.parentElement.insertBefore(btn, home);

  Tour.init({ stage, V, layers: LAYERS, api: API, world: WORLD, figures: () => Spot.world(WORLD), drawRaster: () => {},
    closeCard: () => app.playerCard?.hide?.(), street, legend });

  // the map has to take any zoom while the tour flies, and the sidebar is out of the way
  let snap = null, sideWas = null;
  const begin = () => {
    street.stay3d = app.mode === '3d';   // begun in 3D: it all happens there, and ends there
    snap = [map.options.zoomSnap, map.options.zoomDelta]; map.options.zoomSnap = 0;
    sideWas = !document.body.classList.contains('sidebar-hidden'); app.toggleSidebar(false);
    for (const [d, l] of Object.entries(detailLayer)) keep[d] = l && l.on_;
  };
  const end = () => {
    street.shooting = false; street.stay3d = false;
    if (snap) { map.options.zoomSnap = snap[0]; map.options.zoomDelta = snap[1]; snap = null; map.setZoom(Math.round(map.getZoom()), { animate: false }); }
    for (const [d, l] of Object.entries(detailLayer)) if (l && keep[d] !== undefined && l.on_ !== keep[d]) l.setOn(keep[d]);
  };
  new MutationObserver(() => { if (document.body.classList.contains('tour')) { if (!snap) begin(); } else if (snap) end(); })
    .observe(document.body, { attributes: true, attributeFilter: ['class'] });

  // the world, read now and every 20 s (the tour plans from it)
  refresh(); setInterval(refresh, 20000);
  // #tour: the cinematic from the start, once the world has come in
  if (/(^|[#&])tour\b/.test(location.hash)) setTimeout(() => Tour.start(), 5000);
}
