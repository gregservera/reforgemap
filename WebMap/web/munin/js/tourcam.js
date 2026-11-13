// ForgeMap: the cinematic tour's camera (js/tour.js, ForgeMap 1.4's) on Munin's 3D view. tour.js
// speaks to a view with ForgeMap 1.4's moves -- circle a spot, dolly in, crane up, stand at eye
// height and turn, walk or fly a line -- and to the page that cuts into it and out again. Both are
// made here over View3D: the orbit through setPose, a frame at a time; the stands and lines through
// its Street View (stand, with an eye height of the shot's). Nothing the tour does is kept when it
// stops: the light goes back to the page's, the view back to the map.

import * as THREE from 'three';
import { prefabs } from './data.js';
import { walkedFn, MC } from './layers/forgecanvas.js';

const D2R = Math.PI / 180;

export class TourCam {
  constructor(app) {
    this.app = app; this.v3 = null;
    this.mode = 'street'; this.at = null;
    this.orbit = { dist: 140, pitch: 40, lift: 0, yaw: 30, spin: 0 };
    this.anims = []; this.walking = null; this.frame = 0;
  }
  get prefabs() { return prefabs.map; }
  get waterLevel() { return this.v3 ? this.v3.waterLevel : 30; }
  heightAt(x, z) { return this.v3 ? this.v3.heightAt(x, z) : null; }

  // ---- what tour.js asks of the page (its `street`)
  async load() { this.v3 = await this.app.ensureView3D(); return this; }
  get view() { return this.v3 ? this : null; }
  get on() { return this.app.mode === '3d'; }
  // into 3D over (x, z): once the ground there is in, the shot sets the camera (prep)
  async enter(x, z, heading, prep) {
    this.at = { x, z };
    this.orbit.yaw = (heading + 180) % 360;
    this.app.pendingPose = { x, z, dist: this.orbit.dist, yaw: this.orbit.yaw, pitch: this.orbit.pitch };
    // the map stays on screen while the ground under the shot comes in: never a cut into black
    const v3d = document.getElementById('view3d'), map = document.getElementById('map');
    v3d.style.opacity = '0';
    await this.app.setMode('3d');
    map.style.visibility = '';
    for (let t0 = performance.now(); this.heightAt(x, z) === null && performance.now() - t0 < 8000; ) await new Promise((r) => setTimeout(r, 150));
    if (this.app.mode !== '3d') { v3d.style.opacity = ''; return; }   // stopped meanwhile: the map is the viewer's again
    prep(this);
    await new Promise((r) => setTimeout(r, 600));          // a moment for what stands there
    if (this.app.mode === '3d') map.style.visibility = 'hidden';
    v3d.style.opacity = '';
    this.tick();
  }
  leave() {
    this.still();
    if (this.v3?.street) this.v3.street = null;
    if (this.v3) { this.v3.controls.enabled = true; this.v3.clockOverride = undefined; }
    document.getElementById('view3d').style.opacity = '';
    this.app.setMode('2d');
  }
  feed() {} markMode() {} armPeg() {} letGo() {}

  // ---- the view's moves (its `street.view`)
  // a shot only over walked ground (the 3D view has nothing elsewhere); Munin's view loads what the
  // camera looks at, and enter waits for it
  ready(view) {
    const walked = walkedFn(), p = view && (view.path ? { x: view.path[0][0], z: view.path[0][1] } : view);
    if (!walked || !p || p.x === undefined) return true;
    const q = MC.toPx(p.x, p.z);
    return walked(q.px, q.py);
  }
  prefetch() {}
  update() { this.v3?.scheduleUpdate(); }
  setMode(m) { this.mode = m; if (m === 'orbit' && this.v3?.street) { this.v3.street = null; this.v3.controls.enabled = true; } }
  setOrbit({ dist, pitch, lift = 0 }) { Object.assign(this.orbit, { dist, pitch, lift }); this.place(); }
  setOrbitDist(d) { this.orbit.dist = d; }
  setSpin(degPerSec) { this.orbit.spin = degPerSec || 0; }
  // from d0 to d1 over ms; crane: the camera's height over the spot from h0 to h1, as far across
  dolly(d0, d1, ms) { this.anim(ms, (e) => { this.orbit.dist = d0 + (d1 - d0) * e; }); }
  crane(h0, h1, ms) {
    const across = this.orbit.dist * Math.cos(this.orbit.pitch * D2R);
    this.anim(ms, (e) => { const h = h0 + (h1 - h0) * e; this.orbit.dist = Math.hypot(across, h); this.orbit.pitch = Math.atan2(h, across) / D2R; });
  }
  // stood at (x, z) facing h, an eye above the ground
  stand(x, z, h, { eye = 1.8, pitch = 0 } = {}) {
    this.at = { x, z };
    this.v3.stand(x, z, h);
    Object.assign(this.v3.street, { eye, pitch });
    this.v3.placeStreet();
  }
  pan(a, b, ms) { this.anim(ms, (e) => { if (this.v3.street) this.v3.street.heading = a + (b - a) * e; }); }
  // along the route at speed m/s, facing the way it goes
  walk(route, speed, { eye = 1.8, pitch = 0 } = {}) {
    const legs = [];
    let total = 0;
    for (let i = 1; i < route.length; i++) { const L = Math.hypot(route[i][0] - route[i - 1][0], route[i][1] - route[i - 1][1]); legs.push({ a: route[i - 1], b: route[i], L, from: total }); total += L; }
    if (!total) return;
    this.walking = { legs, total, speed, t0: performance.now(), eye, pitch };
    this.tick();
  }
  still() { this.anims = []; this.walking = null; this.orbit.spin = 0; }
  // the light of the shot: 0 to 1 of the day, null: the page's again
  setClock(frac) { if (this.v3) { this.v3.clockOverride = frac ?? undefined; this.v3.lastDayFraction = null; this.v3.invalidate(true); } }
  // how far the eye at (x, z), facing h, sees before something stands in the way (up to reach)
  clearance(x, z, h, eye, reach) {
    const v = this.v3; if (!v) return reach;
    if (!v.raycaster) return reach;
    const y = (v.heightAt(x, z) ?? v.waterLevel) + eye;
    v.raycaster.set(new THREE.Vector3(x, y, -z), new THREE.Vector3(Math.sin(h * D2R), 0, -Math.cos(h * D2R)));
    v.raycaster.far = reach;
    const hit = v.raycaster.intersectObjects([...v.objChunks.values()], true)[0];
    v.raycaster.far = Infinity;
    return hit ? hit.distance : reach;
  }

  // ---- the frames
  anim(ms, step) { this.anims.push({ t0: performance.now(), ms: Math.max(1, ms), step }); this.tick(); }
  tick() { if (!this.frame) this.frame = requestAnimationFrame((t) => { this.frame = 0; this.run(t); }); }
  run(now) {
    if (!this.v3 || this.app.mode !== '3d') return;
    const dt = Math.min(0.1, (now - (this.last || now)) / 1000); this.last = now;
    for (const a of this.anims) { const t = Math.min(1, (now - a.t0) / a.ms); a.step(t < 0.5 ? 2 * t * t : 1 - Math.pow(-2 * t + 2, 2) / 2); a.done = t >= 1; }
    this.anims = this.anims.filter((a) => !a.done);
    if (this.walking && this.v3.street) {
      const w = this.walking, d = Math.min(w.total, (now - w.t0) / 1000 * w.speed);
      const leg = w.legs.find((l) => d <= l.from + l.L) || w.legs[w.legs.length - 1], k = leg.L ? (d - leg.from) / leg.L : 1;
      const s = this.v3.street;
      s.x = leg.a[0] + (leg.b[0] - leg.a[0]) * k; s.z = leg.a[1] + (leg.b[1] - leg.a[1]) * k;
      s.heading = (Math.atan2(leg.b[0] - leg.a[0], leg.b[1] - leg.a[1]) / D2R + 360) % 360;
      s.eye = w.eye; s.pitch = w.pitch;
      if (d >= w.total) this.walking = null;
    }
    if (this.mode === 'orbit' && this.at) { this.orbit.yaw = (this.orbit.yaw + this.orbit.spin * dt + 360) % 360; this.place(); }
    else if (this.v3.street) this.v3.placeStreet();
    if (this.anims.length || this.walking || this.orbit.spin) this.tick();
  }
  place() {
    if (!this.v3 || !this.at || this.mode !== 'orbit') return;
    const o = this.orbit;
    this.v3.setPose({ x: this.at.x, z: this.at.z, dist: o.dist, yaw: o.yaw, pitch: o.pitch });
    if (o.lift) { this.v3.controls.target.y += o.lift; this.v3.camera.lookAt(this.v3.controls.target); }
  }
}
