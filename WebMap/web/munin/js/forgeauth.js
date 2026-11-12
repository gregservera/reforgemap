// ForgeMap: who writes from Munin's page. The same session as ForgeMap's other pages (map-core.js):
// the sign-in service sends the page back with #session=<token>, kept in this browser as
// xnv.session and sent as a bearer. Where sign-in is off, /auth/me answers 404.
//
// Without a session, the server's announce.token (the admin's own secret, typed once into the pin
// form) writes too, as the server lets a proxy holding it write (X-Announce-Token, X-User): the way
// to place pins on a server with no Discord sign-in, such as a test server.

let session = null, me = null, signInHere = false, asked = null;
try {
  const parts = location.hash.replace(/^#/, '').split('&').filter(Boolean);
  const got = parts.find((q) => q.startsWith('session='));
  if (got) {
    localStorage.setItem('xnv.session', got.slice(8));
    const rest = parts.filter((q) => q !== got).join('&');
    history.replaceState(null, '', location.pathname + location.search + (rest ? '#' + rest : ''));
  }
  session = localStorage.getItem('xnv.session');
} catch (e) { /* storage blocked: nobody signed in */ }

export function adminKey() {
  try { return localStorage.getItem('forgemap.adminkey') || ''; } catch (e) { return ''; }
}
export function setAdminKey(k) {
  try { if (k) localStorage.setItem('forgemap.adminkey', k); else localStorage.removeItem('forgemap.adminkey'); } catch (e) { /* this visit only */ }
}

// the signed-in member, {id, name, avatar, admin}, or null; asked once a page
export function whoami() {
  if (!asked) asked = (async () => {
    try {
      const r = await fetch('auth/me', { cache: 'no-store', headers: session ? { authorization: 'Bearer ' + session } : {} });
      if (r.status === 404) return null;                 // sign-in is off on this server
      signInHere = true;
      if (r.ok) { me = await r.json(); return me; }
      if (session) { session = null; try { localStorage.removeItem('xnv.session'); } catch (e) { /* none */ } }
    } catch (e) { /* no answer: as if signed out */ }
    return null;
  })();
  return asked;
}
export const canSignIn = () => signInHere;
export function signIn() { location.href = 'auth/login?to=' + encodeURIComponent(location.href); }

// the headers a write carries: the member's session, else the admin key; null when neither
export function writeHeaders() {
  if (session && me) return { authorization: 'Bearer ' + session };
  const k = adminKey();
  if (k) return { 'X-Announce-Token': k, 'X-User': 'admin' };
  return null;
}
