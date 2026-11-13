// ForgeMap: Munin's map as the ground under the Portails and Plan pages (ticket pages-moteur-munin).
//
// Those pages keep their own view (MapCore.view: the pointer, the wheel, the zoom limits, all in
// MapCore's texture pixels) and draw what is theirs on a canvas over it. Under that canvas this is
// a Leaflet map with Munin's tiles that never moves by itself: each frame the view is painted,
// the map is set to the same centre and zoom (sync). Ground nobody has walked comes from the server
// transparent (Tiles/FogMask.cs), so the page's dark shows there; no fog veil is needed. The
// page's websocket says which tiles were drawn since (a first look at new ground asks the server
// for tiles it has not drawn yet) and where the fog lifted, and the tiles come again (net.js).
//
// o.veg: the tree and rock tiles over the ground (setVeg turns them on and off)
// o.look: 'chart': the matte, cool chart the portal network is drawn on (a CSS filter and tint)

import { ValheimCRS, toLatLng, OVER_ZOOM, MAX_ZOOM } from './crs.js';
import { FallbackTileLayer } from './layers/tiles.js';
import { connect } from './net.js';

const MC = MapCore;
let connected = false;

export function mount(el, o = {}) {
  if (!connected) { connected = true; connect(); }
  el.classList.add('fm-ground');
  if (o.look) el.classList.add('fm-ground-' + o.look);
  const map = L.map(el, {
    crs: ValheimCRS, minZoom: -6, maxZoom: OVER_ZOOM, zoomSnap: 0,
    zoomControl: false, attributionControl: false, dragging: false, touchZoom: false, scrollWheelZoom: false,
    doubleClickZoom: false, boxZoom: false, keyboard: false, tap: false, zoomAnimation: false, fadeAnimation: false,
    markerZoomAnimation: false, inertia: false,
  });
  map.setView(toLatLng(0, 0), 0, { animate: false });
  // below zoom 0 the zoom-0 tiles, scaled down
  const tiles = (path, opts) => new FallbackTileLayer(`tiles/${path}/{z}/{x}/{y}.png`, Object.assign({ minZoom: -6, minNativeZoom: 0, updateWhenIdle: false, keepBuffer: 1 }, opts));
  const ground = tiles('map', { zIndex: 100 }).addTo(map);
  const terra = tiles('terra', { zIndex: 100.5, minNative: 5 }).addTo(map);
  const veg = tiles('veg', { zIndex: 101, minNative: 5, className: 'maptiles vegtiles' });
  if (o.veg) veg.addTo(map);
  let w = 0, h = 0;

  return {
    map,
    // the view (scale: screen px per texture px, tx/ty: the texture's corner on screen) as Leaflet's
    sync(v) {
      const W = el.clientWidth, H = el.clientHeight;
      if (!W || !H) return;
      if (W !== w || H !== h) { w = W; h = H; map.invalidateSize({ animate: false, pan: false }); }
      const c = MC.toWorld((W / 2 - v.tx) / v.scale, (H / 2 - v.ty) / v.scale);
      const zoom = MAX_ZOOM + Math.log2(v.scale / MC.geom.pixel);
      map.setView(toLatLng(c.x, c.z), Math.min(OVER_ZOOM, zoom), { animate: false });
    },
    setVeg(on) { if (on) veg.addTo(map); else veg.remove(); },
    // the ground as it is on screen, into g (its transform: screen px), for a picture of the page
    paintInto(g) {
      const box = el.getBoundingClientRect();
      g.save();
      if (o.look === 'chart') g.filter = getComputedStyle(el).getPropertyValue('--fm-chart-filter').trim() || 'none';
      for (const layer of [ground, terra, veg]) {
        if (!layer._map) continue;
        const pane = layer.getContainer(); if (!pane) continue;
        for (const img of pane.querySelectorAll('.tile-wrap img')) {
          if (!img.complete || !img.naturalWidth) continue;
          const r = img.getBoundingClientRect();
          if (r.right < box.left || r.bottom < box.top || r.left > box.right || r.top > box.bottom) continue;
          try { g.drawImage(img, r.left - box.left, r.top - box.top, r.width, r.height); } catch (e) { /* not drawable: left out */ }
        }
      }
      g.restore();
    },
  };
}
