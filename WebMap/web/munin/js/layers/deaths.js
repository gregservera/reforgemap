// ForgeMap: where people died, each death where it happened (the last 500 /state keeps), a red glow
// that fades over a month (MapCore.drawDeaths, ForgeMap 1.4's "deaths" detail). Off until asked for;
// a player's card can show theirs alone (setWho). Munin's Dangerous zones count them per zone.

import { ForgeCanvas, MC } from './forgecanvas.js';

export class DeathsLayer extends ForgeCanvas {
  constructor() { super('fmDeaths', 416); this.all = []; this.on_ = false; this.who = null; }

  setOn(v) { this.on_ = v; if (v) this.tick(); else this.request(); }
  // one player's deaths only (null: everyone's); turns the layer on
  setWho(name) { this.who = name || null; this.setOn(true); if (this.onWho) this.onWho(this.who); }

  async load() {
    if (!this.on_) return;
    try {
      const s = await MC.fetchState(MC.cfg.api);
      this.all = ((s.deaths || {}).deaths || []).map((d) => Object.assign({ name: d.n, t: d.t }, MC.toPx(d.x, d.z)));
    } catch (e) { /* none yet */ }
  }

  paint(g, v) {
    if (!this.on_ || !this.all.length) return;
    MC.drawDeaths(g, v, this.who ? this.all.filter((d) => d.name === this.who) : this.all);
  }
}
