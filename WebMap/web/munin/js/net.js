// Server connection: JSON over websocket for live state, plain fetch for data.
//
// Frames from the server (see MapDataServer.Broadcast):
//   hello {version, worldRev, config}   players {data}   events {data, initial?}
//   tiles {keys[], status}   world {rev, stats}   ping {id,name,x,z}
//   pin {...}   rmpin {id}   reload
// The bus fans each frame out to listeners by its `t`.

const listeners = new Map();
let ws = null, backoff = 1000, closedByUs = false;
export const state = { connected: false, config: null, worldRev: 0 };

export function on(type, fn) {
  if (!listeners.has(type)) listeners.set(type, new Set());
  listeners.get(type).add(fn);
  return () => listeners.get(type).delete(fn);
}

export function emit(type, payload) {
  const set = listeners.get(type);
  if (set) for (const fn of set) { try { fn(payload); } catch (e) { console.error('listener', type, e); } }
}

// ForgeMap: its websocket is the page's own address, and its frames are "<type>\n<payload>" (the
// bundled pages read the rest from /state). The ones the map uses become Munin's {t, ...} frames.
export function connect() {
  const proto = location.protocol === 'https:' ? 'wss:' : 'ws:';
  const url = `${proto}//${location.host}${location.pathname.replace(/[^/]*$/, '')}`;
  try { ws = new WebSocket(url); } catch (e) { scheduleReconnect(); return; }
  // 'reconnected': open again after a gap (not the first time: the page has just fetched everything)
  ws.onopen = () => { state.connected = true; backoff = 1000; emit('connection', true); if (state.wasOpen) emit('reconnected'); state.wasOpen = true; };
  ws.onclose = () => { state.connected = false; emit('connection', false); if (!closedByUs) scheduleReconnect(); };
  ws.onerror = () => { try { ws.close(); } catch {} };
  ws.onmessage = (m) => {
    const f = frame(String(m.data));
    if (!f) return;
    if (f.t === 'reload') { location.reload(); return; }
    emit(f.t, f);
  };
}

// one ForgeMap frame as Munin's: live (the players, {ts, players}) as players {data}, tiles {keys,
// status}, markers {rev}, pin, rmpin, reload; the others are not used yet
export function frame(text) {
  const nl = text.indexOf('\n'), type = nl < 0 ? text : text.slice(0, nl), body = nl < 0 ? '' : text.slice(nl + 1);
  if (type === 'reload') return { t: 'reload' };
  // pin: placer, id, type, owner, "x,z", text (the text may hold new lines no more than commas)
  if (type === 'pin') {
    const f = body.split('\n'), [x, z] = (f[4] || '').split(',').map(Number);
    if (f.length < 5 || !isFinite(x) || !isFinite(z)) return null;
    return { t: 'pin', id: f[1], type: f[2], name: f[3], x, z, text: f.slice(5).join('\n') };
  }
  if (type === 'rmpin') return body ? { t: 'rmpin', id: body.trim() } : null;
  // ping: someone marked a spot on their map in game: id, name, "x,z"
  if (type === 'ping') {
    const f = body.split('\n'), [x, z] = (f[2] || '').split(',').map(Number);
    return f.length >= 3 && isFinite(x) && isFinite(z) ? { t: 'ping', id: f[0], name: f[1], x, z } : null;
  }
  if (type === 'live') { try { return { t: 'players', data: JSON.parse(body) }; } catch { return null; } }
  if (type === 'markers') return { t: 'markers', rev: +body };
  if (type === 'tiles') { try { return Object.assign({ t: 'tiles' }, JSON.parse(body)); } catch { return null; } }
  return null;
}

function scheduleReconnect() {
  setTimeout(connect, backoff);
  backoff = Math.min(backoff * 1.7, 15000);
}

// The startup data, requested by index.html's head before any script has loaded (window.__early):
// the first ask for one of those paths takes that response instead of fetching again.
export function fetchEarly(path, opts) {
  const e = window.__early && window.__early[path];
  if (e) { delete window.__early[path]; return e.then((r) => r || fetch(path, opts)); }
  return fetch(path, opts);
}

export async function getJSON(path, opts) {
  const r = await fetchEarly(path, Object.assign({ cache: 'no-cache' }, opts));
  if (!r.ok) throw new Error(`${path}: ${r.status}`);
  return r.json();
}

export async function getBuffer(path, opts) {
  const r = await fetchEarly(path, Object.assign({ cache: 'no-cache' }, opts));
  if (!r.ok) throw new Error(`${path}: ${r.status}`);
  return r.arrayBuffer();
}

export function loadImage(src) {
  return new Promise((resolve, reject) => {
    const img = new Image();
    img.crossOrigin = 'anonymous';
    img.onload = () => resolve(img);
    img.onerror = () => reject(new Error('image ' + src));
    img.src = src;
  });
}
