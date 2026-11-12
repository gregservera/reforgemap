// ForgeMap: up close, a base as a floor plan -- every placed piece where it stands, walls as lines,
// floors a tint, furniture solid (MapCore.drawPieces, as in ForgeMap 1.4) -- in place of Munin's
// building footprints, which fade out at that zoom. A click on a piece says who built it. Apart from
// the zoom, the lights: torches, fires and hearths that burn glow, a burnt-out one is a grey ring
// (MapCore.drawFires), off until asked for.
//
// The pieces come from /pieces each minute; one on ground nobody has walked is never drawn.

import { ForgeCanvas, MC } from './forgecanvas.js';
import { layerState } from '../layerstate.js';

const T = (s, v) => window.I18N.t(s, v);
const esc = (s) => String(s ?? '').replace(/[&<>"']/g, (c) => ({ '&': '&amp;', '<': '&lt;', '>': '&gt;', '"': '&quot;', "'": '&#39;' }[c]));

export class PlanLayer extends ForgeCanvas {
  // structures: Munin's buildings layer, faded out where the plan takes over; names: the names
  // layer, whose clicks come first
  constructor(o) {
    super('fmPlan', 420);
    this.o = o || {}; this.all = []; this.shown = []; this.builders = []; this.lights = false; this.planOn = false;
    this.shownOf = null;
  }

  onAdd(map) {
    super.onAdd(map); map.on('click', this.click, this);
    this.offState = layerState.onChange((k) => { if (k === 'buildings') this.request(); });
  }
  onRemove(map) { map.off('click', this.click, this); this.offState?.(); this.fade(false); super.onRemove(map); }

  setLights(v) { this.lights = v; this.request(); }

  async load() {
    try {
      const j = await MC.fetchJSON(MC.cfg.api, '/pieces');
      this.all = MC.parsePieces(j);
      this.builders = Array.isArray(j && j.players) ? j.players : [];
      this.shownOf = null;
    } catch (e) { /* none yet */ }
  }

  // Munin's footprints out while the plan is drawn, back when it is not
  fade(plan) {
    if (plan === this.planOn) return;
    this.planOn = plan;
    const s = this.o.structures;
    if (s && s.setOpacity) s.setOpacity(plan ? 0 : 0.95);
  }

  paint(g, v, walked) {
    if (this.shownOf !== walked) { this.shownOf = walked; this.shown = walked ? this.all.filter((p) => walked(p.px, p.py)) : []; }
    const plan = layerState.buildings !== false && v.scale >= MC.PLAN_ZOOM;
    this.fade(plan);
    this.view_ = v;
    if (plan) MC.drawPieces(g, v, this.shown, { plan: true });
    if (this.lights) MC.drawFires(g, v, this.shown);
  }
  fogChanged() { this.shownOf = null; super.fogChanged(); }

  // the top piece under a click, at the plan's zoom: who built it
  click(e) {
    const v = this.view_;
    if (!this.planOn || !v) return;
    const names = this.o.names;
    if (names && names.boxes && MC.hitName(names.boxes, e.containerPoint.x, e.containerPoint.y)) return;
    const px = (e.containerPoint.x - v.tx) / v.scale, py = (e.containerPoint.y - v.ty) / v.scale;
    let hit = null;
    for (const p of this.shown) {
      // inside the turned footprint: its corners, around its centre, in texture px
      const q = p.o, dx = px - p.px, dy = py - p.py;
      let pos = 0, neg = 0;
      for (let i = 0; i < 4; i++) {
        const ax = q[i * 2], ay = q[i * 2 + 1], bx = q[(i * 2 + 2) % 8], by = q[(i * 2 + 3) % 8];
        const c = (bx - ax) * (dy - ay) - (by - ay) * (dx - ax);
        if (c > 0) pos++; else if (c < 0) neg++;
      }
      const inside = !(pos && neg);   // on the same side of every edge, whichever way they turn
      if (inside) hit = p;   // the last drawn wins: roofs over walls over floors
    }
    if (!hit) return;
    const who = hit.by >= 0 && this.builders[hit.by] ? this.builders[hit.by] : null;
    const el = document.createElement('div');
    el.innerHTML = `<small>${esc(T(KINDS[hit.kind] || hit.kind))}</small><b>${who ? esc(T('Built by {name}', { name: who })) : esc(T('Builder unknown'))}</b>`;
    L.popup({ offset: [0, -4] }).setLatLng(e.latlng).setContent(el).openOn(this.map);
  }
}

const KINDS = { floor: 'Floor', wall: 'Wall', pole: 'Pole', prop: 'Furniture', crop: 'Crop', roof: 'Roof' };
