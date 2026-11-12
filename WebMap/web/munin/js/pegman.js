// ForgeMap: Street View's figure (ForgeMap 1.4's pegman), at the top of the map's buttons. Dragged
// onto walked ground and dropped, it stands you there in 3D at eye height (app.enterStreet); on a
// phone, tap it, then tap the map. Ground nobody has walked is refused: the 3D view has nothing there.

import { fromLatLng } from './crs.js';
import { walkedFn, MC } from './layers/forgecanvas.js';

const T = (s, v) => window.I18N.t(s, v);
const FIGURE = '<svg viewBox="0 0 24 24" aria-hidden="true"><circle cx="12" cy="4.6" r="2.6"/><path d="M8.6 9.2c0-1 .8-1.8 1.8-1.8h3.2c1 0 1.8.8 1.8 1.8v5.4h-1.6V22h-1.5v-6.2h-.6V22H10.2v-7.4H8.6z"/></svg>';

export class Pegman {
  constructor(app) {
    this.app = app; this.armed = false;
    const Ctl = L.Control.extend({
      options: { position: 'topleft' },
      onAdd: () => {
        const b = L.DomUtil.create('button', 'fm-pegman');
        b.type = 'button'; b.title = T('Drag onto the map to stand there in 3D'); b.innerHTML = FIGURE;
        L.DomEvent.disableClickPropagation(b);
        b.addEventListener('pointerdown', (e) => this.grab(e));
        this.btn = b;
        return b;
      },
    });
    new Ctl().addTo(app.map);
    app.map.on('click', (e) => { if (this.armed) { this.arm(false); this.drop(e.latlng); } });
  }

  arm(on) { this.armed = on; this.btn.classList.toggle('armed', on); this.app.map.getContainer().classList.toggle('fm-placing', on); }

  // a drag with the mouse; a touch only arms it (the next tap on the map is the spot)
  grab(e) {
    if (e.pointerType === 'touch') { e.preventDefault(); this.arm(!this.armed); return; }
    e.preventDefault();
    const ghost = document.createElement('div');
    ghost.className = 'fm-pegman-ghost'; ghost.innerHTML = FIGURE;
    document.body.appendChild(ghost);
    const at = (ev) => { ghost.style.left = ev.clientX + 'px'; ghost.style.top = ev.clientY + 'px'; };
    at(e);
    const move = (ev) => at(ev);
    const up = (ev) => {
      removeEventListener('pointermove', move); removeEventListener('pointerup', up);
      ghost.remove();
      const box = this.app.map.getContainer().getBoundingClientRect();
      if (ev.clientX < box.left || ev.clientX > box.right || ev.clientY < box.top || ev.clientY > box.bottom) return;
      if (Math.hypot(ev.clientX - e.clientX, ev.clientY - e.clientY) < 6) { this.arm(!this.armed); return; }   // a click on it: as a tap
      this.drop(this.app.map.containerPointToLatLng([ev.clientX - box.left, ev.clientY - box.top]));
    };
    addEventListener('pointermove', move); addEventListener('pointerup', up);
  }

  drop(latlng) {
    const { x, z } = fromLatLng(latlng), walked = walkedFn(), q = MC.toPx(x, z);
    if (walked && !walked(q.px, q.py)) { this.app.toast(T('Nobody has walked there yet')); return; }
    this.app.enterStreet(x, z, 0);
  }
}
