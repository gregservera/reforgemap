// ForgeMap: a layer of Munin's map drawn by ForgeMap's own canvas functions (map-core.js, the global
// MapCore): a canvas the size of the map in a pane of its own, drawn again at every move and zoom.
//
// MapCore draws in its texture's pixels (2048 of 12 m, north up); Leaflet in metres. Both are
// linear in x and z with north up, so the view is the screen point of the world's middle and the
// screen pixels per texture pixel: 12 m times Leaflet's pixels per metre.
//
// The fog, at its own 12 m (MapCore.explored reads it at 48 m), is shared by every such layer and
// fetched again each minute.

import { toLatLng } from '../crs.js';

// (MapCore is a classic script's top-level const: a global name, but not a property of window)
export const MC = MapCore;

let fog = null, fogAt = 0, fogLoading = null;
const fogUsers = new Set();
// (px, py) in MapCore's texture pixels -> walked; null until the fog has loaded
export function walkedFn() { return fog; }
function loadFog() {
  if (fogLoading || Date.now() - fogAt < 55000) return;
  fogLoading = new Promise((done) => {
    const img = new Image();
    img.onload = () => {
      const n = img.naturalWidth, c = document.createElement('canvas');
      c.width = c.height = n;
      const g = c.getContext('2d', { willReadFrequently: true });
      g.drawImage(img, 0, 0);
      try {
        const d = g.getImageData(0, 0, n, n).data, k = n / MC.geom.size;
        fog = (px, py) => { const x = Math.min(n - 1, Math.max(0, (px * k) | 0)), y = Math.min(n - 1, Math.max(0, (py * k) | 0)); return d[(y * n + x) * 4] > 127; };
        fogAt = Date.now();
      } catch (e) { /* unreadable: kept as it was */ }
      for (const l of fogUsers) l.fogChanged();
      done();
    };
    img.onerror = () => done();
    img.src = MC.cfg.api + '/fog?t=' + Date.now();
  }).finally(() => { fogLoading = null; });
}

export class ForgeCanvas extends L.Layer {
  constructor(pane, zIndex) { super(); this.paneName = pane; this.zIndex = zIndex; this.frame = 0; }

  onAdd(map) {
    this.map = map;
    if (!map.getPane(this.paneName)) { const p = map.createPane(this.paneName); p.style.zIndex = this.zIndex; p.style.pointerEvents = 'none'; }
    this.canvas = L.DomUtil.create('canvas', 'fm-canvas', map.getPane(this.paneName));
    this.g = this.canvas.getContext('2d');
    map.on('move zoom viewreset resize', this.request, this);
    fogUsers.add(this);
    this.tick();
    this.timer = setInterval(() => this.tick(), 60000);
    this.request();
  }

  onRemove(map) {
    map.off('move zoom viewreset resize', this.request, this);
    fogUsers.delete(this);
    clearInterval(this.timer);
    this.canvas.remove();
  }

  async tick() {
    try { await MC.fetchConfig(MC.cfg.api); } catch (e) { /* the default geometry */ }
    loadFog();
    await this.load();
    this.request();
  }
  async load() { /* the layer's own data */ }
  fogChanged() { this.request(); }

  request() { if (!this.frame) this.frame = requestAnimationFrame(() => { this.frame = 0; this.draw(); }); }

  // the view as MapCore takes it
  view() {
    const map = this.map, size = map.getSize(), pix = window.devicePixelRatio || 1;
    const geom = MC.geom, mid = map.latLngToContainerPoint(toLatLng(0, 0));
    const metre = map.latLngToContainerPoint(toLatLng(1, 0)).x - mid.x;   // screen px per metre
    const scale = metre * geom.pixel, half = geom.size / 2;
    return { scale, tx: mid.x - half * scale, ty: mid.y - half * scale, w: size.x, h: size.y, pix };
  }

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
    this.paint(this.g, this.view(), fog);
  }
  paint(_g, _v, _walked) { /* the layer's own drawing */ }
}
