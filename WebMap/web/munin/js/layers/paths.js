// ForgeMap: where people walk, all told -- /trails, a picture of the world on the fog's grid, each
// walked pixel a faint blue that deepens with the walking (ForgeMap 1.4's "trails" detail) -- laid
// over Munin's map at the view. Munin's own Trails (the last hours, player by player) are another
// layer. Off until asked for, as in 1.4.

import { ForgeCanvas, MC } from './forgecanvas.js';

export class PathsLayer extends ForgeCanvas {
  constructor() { super('fmPaths', 415); this.img = null; this.on_ = false; this.rev = null; }

  setOn(v) { this.on_ = v; if (v) this.tick(); else this.request(); }

  async load() {
    if (!this.on_) return;
    try {
      const rev = ((await MC.fetchState(MC.cfg.api)).rev || {}).trails;
      if (rev === undefined || rev === this.rev) return;     // 503 until someone has walked: no rev yet
      const img = new Image();
      await new Promise((done) => { img.onload = done; img.onerror = done; img.src = MC.cfg.api + '/trails?v=' + rev; });
      if (img.naturalWidth) { this.img = img; this.rev = rev; }
    } catch (e) { /* none yet */ }
  }

  paint(g, v) {
    const img = this.img;
    if (!this.on_ || !img) return;
    const k = img.naturalWidth / MC.geom.size;               // picture px per texture px
    g.setTransform(v.pix, 0, 0, v.pix, 0, 0);
    g.imageSmoothingEnabled = true;
    g.drawImage(img, (-v.tx / v.scale) * k, (-v.ty / v.scale) * k, (v.w / v.scale) * k, (v.h / v.scale) * k, 0, 0, v.w, v.h);
  }
}
