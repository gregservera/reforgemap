// ForgeMap: the card a player opens with on the map (decision D9) -- ForgeMap's own, as the players
// page and the tour draw a player (js/card.js, the global PlayerCard): the class, the pentagon, the
// four figures and the ping; with Munin's live health and its Follow, which keeps the map (and the
// 3D view) on them. The same face as Munin's card (show, showByName, update, hide), so the page opens
// it where it opened that one. Gear in detail stays on the players page, one link away.
//
// The tallies come from /stats/players, fetched when the card opens and each minute while it is.

const MC = MapCore, PC = PlayerCard, T = (s, v) => window.I18N.t(s, v);
const esc = (s) => String(s ?? '').replace(/[&<>"']/g, (c) => ({ '&': '&amp;', '<': '&lt;', '>': '&gt;', '"': '&quot;', "'": '&#39;' }[c]));

// a weather's name: its own keys ("weather:Clear"), as the bare words mean other things elsewhere
const weatherWord = (w) => { const k = 'weather:' + w, t = T(k); return t !== k ? t : T(w); };
// the wind's strength (0 to 1, as the game has it) in words
const windWord = (w) => T(w < 0.2 ? 'calm wind' : w < 0.45 ? 'light wind' : w < 0.7 ? 'fresh wind' : 'strong wind');

export class ForgeCard {
  constructor(app) {
    this.app = app;
    this.name = null; this.roster = []; this.rosterAt = 0;
    this.el = document.createElement('div');
    this.el.className = 'player-card fm-card';
    this.el.hidden = true;
    document.getElementById('app').appendChild(this.el);
    this.el.addEventListener('click', (e) => e.stopPropagation());
    document.addEventListener('keydown', (e) => { if (e.key === 'Escape') this.hide(); });
    document.addEventListener('pointerdown', (e) => { if (!this.el.hidden && !this.el.contains(e.target) && !e.target.closest('.mk-player') && !e.target.closest('#panel-players')) this.hide(); });
  }

  live(name) { return (this.app.layers.players.players || []).find((q) => q.name === name); }

  async tallies(force) {
    if (!force && Date.now() - this.rosterAt < 60000) return;
    this.rosterAt = Date.now();
    try { this.roster = ((await MC.fetchJSON(MC.cfg.api, '/stats/players')).players) || []; PC.rim(this.roster); } catch (e) { /* the live part alone */ }
  }

  async show(player, x, y) {
    this.name = player.name;
    this.render();
    this.el.hidden = false;
    const w = this.el.offsetWidth, h = this.el.offsetHeight;
    let left = x + 16, top = y - h / 2;
    if (left + w > innerWidth - 8) left = x - w - 16;
    if (left < 8) left = 8;
    this.el.style.left = left + 'px';
    this.el.style.top = Math.max(8, Math.min(innerHeight - h - 8, top)) + 'px';
    await this.tallies(true);
    if (this.name === player.name) this.render();
  }
  showByName(name) { this.show({ name }, innerWidth / 2 - 160, innerHeight / 2); }
  hide() { this.el.hidden = true; this.name = null; }

  // the players feed, every second: health and state as they are now
  update() { if (this.name !== null && !this.el.hidden) { this.render(); this.tallies(false).then(() => this.name && this.render()); } }

  render() {
    const name = this.name, p = this.live(name), st = this.roster.find((s) => s.name === name);
    if (!p && !st) { this.el.innerHTML = `<b>${esc(name)}</b>`; return; }
    const cls = st ? PC.classify(st, this.roster) : null;
    const PL = this.app.layers.players, following = p && PL.following === p.id;
    const state = p ? [p.dead ? T('dead') : '', p.inBed ? T('sleeping') : '', p.pvp ? 'PvP' : ''].filter(Boolean) : [];
    const head = `<div class="fm-card-head"><span class="dot${p ? ' ok' : ''}"></span><b>${esc(name)}</b>${PC.pill(cls)}</div>`
      + `<div class="fm-card-state">${p ? T('online now') + PC.ping(p.ping) : esc(PC.seen(st && +st.last_seen))}${state.length ? ' · ' + esc(state.join(' · ')) : ''}`
      + `${p && p.x === undefined ? ' · ' + esc(T('Position hidden')) : ''}${cls ? ` <i>· ${esc(cls.why)}</i>` : ''}</div>`
      + (p && p.x !== undefined && (p.biome || p.weather) ? `<div class="fm-card-state">${esc([p.biome && T(p.biome), p.weather && weatherWord(p.weather), p.wind !== undefined ? windWord(p.wind) : ''].filter(Boolean).join(' · '))}</div>` : '');
    const hp = p && p.maxHealth > 0
      ? `<div class="pc-bar"><span>${T('Health')}</span><div class="hp"><i class="${p.health / p.maxHealth < 0.3 ? 'low' : ''}" style="width:${Math.round(100 * Math.max(0, Math.min(1, p.health / p.maxHealth)))}%"></i></div><b>${Math.round(p.health)} / ${Math.round(p.maxHealth)}</b></div>` : '';
    const body = st ? `<div class="fm-card-body">${PC.figures(st)}${PC.radar(st, 150, true)}</div>` : '';
    const acts = `<div class="pin-actions">`
      + (p && p.x !== undefined ? `<button class="btn small" type="button" data-act="follow">${following ? T('Unfollow') : T('Follow')}</button>` : '')
      + (st && +st.deaths > 0 && this.app.layers.deaths ? `<button class="btn small" type="button" data-act="deaths">${T('Their deaths')}</button>` : '')
      + `<a class="btn small" href="players.html#p=${encodeURIComponent(name)}">${T('Their page')}</a></div>`;
    this.el.innerHTML = `<button class="fm-card-x" type="button" title="${T('Close')}">×</button>` + head + hp + body + acts;
    this.el.querySelector('.fm-card-x').addEventListener('click', () => this.hide());
    this.el.querySelector('[data-act=deaths]')?.addEventListener('click', () => setTimeout(() => this.app.layers.deaths.setWho(name), 0));
    this.el.querySelector('[data-act=follow]')?.addEventListener('click', () => setTimeout(() => { PL.follow(following ? null : p.id); this.render(); }, 0));
  }
}
