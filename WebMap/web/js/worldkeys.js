// The world's keys in words (Munin Map's stats panel, ported for ForgeMap's Monde page; ticket
// fonctions-munin-hors-carte): the world modifiers it runs with ("resourcerate 200", "nomap", the
// preset picked when it was made), Hildir's quests done, and what first kills unlocked. The keys come
// as the game has them, in /stats/players' globalKeys. A classic script: the global WorldKeys.
// (ForgeMap's own boss board already shows the bosses; their keys are left out here.)
const WorldKeys = (() => {
  const T = (s, v) => (window.I18N ? I18N.t(s, v) : s);
  const BOSS_KEYS = new Set(["defeated_eikthyr", "defeated_gdking", "defeated_bonemass", "defeated_dragon", "defeated_goblinking", "defeated_queen",
    "defeated_fader", "defeated_frozenking", "defeated_frozenking_p3", "activebosses"]);
  // Hildir's sisters, each the boss of one of her quest dungeons
  const MINI_BOSSES = {
    bosshildir1: ["Brenna", "Smouldering Tomb, Black Forest"],
    bosshildir2: ["Geirrhafa", "Howling Cavern, Mountains"],
    bosshildir3: ["Zil & Thungr", "Sealed Tower, Plains"],
  };
  const HILDIR_QUESTS = {
    hildir1: ["Brenna's chest returned", "Hildir's first quest done"],
    hildir2: ["Geirrhafa's chest returned", "Hildir's second quest done"],
    hildir3: ["Zil & Thungr's chest returned", "Hildir's third quest done"],
  };
  // rare creatures, not bosses: their kill keys are not shown (the Writhan, the Eyeless One)
  const NOT_SHOWN_KILLS = new Set(["writhan", "elakingmole"]);
  const KILL_NAMES = {elakingmole: "Eyeless One"};
  // world keys the game sets as a world goes on (each widens what can attack you)
  const PROGRESS_KEYS = {
    killedtroll: ["Troll raids", "The first troll was killed: trolls can now raid bases"],
    killed_surtling: ["Surtling raids", "The first surtling was killed: surtlings can now raid bases"],
    killedbat: ["Bat raids", "The first bat was killed: bats can now raid bases"],
    stonecircle: ["Stone circle", "The stone circle event has happened"],
    ashlandsocean: ["Ashlands sea", "Someone has sailed the Ashlands sea"],
  };
  // a world modifier key in words
  const MODIFIERS = {
    playerdamage: "Player damage", enemydamage: "Enemy damage", worldlevel: "World level", eventrate: "Raid rate", resourcerate: "Resources",
    staminarate: "Stamina use", adrenalinerate: "Adrenaline", eitrrate: "Eitr use", durabilityrate: "Durability loss", foodrate: "Food duration",
    movestaminarate: "Movement stamina", staminaregenrate: "Stamina regen", skillgainrate: "Skill gain", skillreductionrate: "Skill loss on death",
    enemyspeedsize: "Enemy speed & size", enemylevelupyrate: "Enemy level-ups", enemyleveluprate: "Enemy level-ups", carryweightrate: "Carry weight",
    playerevents: "Raids follow each player", fire: "Fire spreads", deathkeepequip: "Keep equipment on death", deathdeleteitems: "Items lost on death",
    deathdeleteunequipped: "Unequipped items lost on death", deathskillsreset: "All skills lost on death", deathkeepinventory: "Keep inventory on death",
    nobuildcost: "No build cost", nocraftcost: "No craft cost", allpiecesunlocked: "All pieces unlocked", noworkbench: "No workbench needed",
    allrecipesunlocked: "All recipes unlocked", worldlevellockedtools: "Tools locked by world level", passivemobs: "Passive enemies", nomap: "No map",
    noportals: "No portals", nobossportals: "No portals near bosses", dungeonbuild: "Building in dungeons", teleportall: "Portals carry everything",
    nopseudodrops: "No extra drops", nobuildingfall: "Buildings never collapse", noheavysnow: "No heavy snow", allheavysnow: "Heavy snow everywhere",
  };
  // the keys the world-settings presets set; any other key was set on its own
  const PRESET_KEYS = new Set(["playerdamage", "enemydamage", "enemyspeedsize", "enemyleveluprate", "enemylevelupyrate",
    "deathkeepequip", "deathdeleteitems", "deathdeleteunequipped", "deathskillsreset", "deathkeepinventory", "skillreductionrate",
    "resourcerate", "eventrate", "teleportall", "noportals", "nobossportals"]);
  const PRESET_NAMES = {combat: "Combat", deathpenalty: "Death penalty", resources: "Resources", raids: "Raids", portals: "Portals"};
  const LEVELS = {default: "Normal", veryeasy: "Very easy", easy: "Easy", hard: "Hard", veryhard: "Very hard", casual: "Casual", hardcore: "Hardcore",
    more: "More", muchmore: "Much more", most: "Most", less: "Less", muchless: "Much less", none: "None"};
  // a preset's level: its own keys ("level:more"), as the bare words mean other things elsewhere
  const lvl = (level) => { const k = "level:" + level, t = T(k); return t !== k ? t : LEVELS[level] || level || ""; };
  const pretty = (s) => s.replace(/_/g, " ").replace(/([a-z])([A-Z])/g, "$1 $2").replace(/^./, (c) => c.toUpperCase());

  // [text, hover, key]
  function modifier(name, val) {
    const label = T(MODIFIERS[name] || name.replace(/_/g, " "));
    if (!val) return [label, name, name];
    const n = Number(val);
    // a scale on the game's normal amount (skill loss 15: 15% of what a death normally costs)
    const shown = Number.isFinite(n) && (name.endsWith("rate") || ["playerdamage", "enemydamage", "enemyspeedsize"].includes(name)) ? T("{n}% of normal", {n}) : val;
    return [T("{label}: {value}", {label, value: shown}), `${name} ${val}`, name];
  }

  // the keys -> {mods, quests, minis, progress, kills}, each a list of [text, hover] (minis: [name, where, beaten])
  function read(keys) {
    const gk = (keys || []).map(String), set = new Set(gk.map((k) => k.split(" ")[0].toLowerCase()));
    const mods = [], effects = [], quests = [], progress = [], kills = [];
    let preset = null;
    for (const k of gk) {
      const [name, ...rest] = k.split(" "), low = name.toLowerCase(), val = rest.join(" ");
      if (BOSS_KEYS.has(low) || MINI_BOSSES[low]) continue;
      if (PROGRESS_KEYS[low]) { progress.push(PROGRESS_KEYS[low].map((s) => T(s))); continue; }
      if (HILDIR_QUESTS[low]) { quests.push(HILDIR_QUESTS[low].map((s) => T(s))); continue; }
      if (low === "preset") { preset = val; continue; }
      // any other "beaten" key (other bosses, often from mods): defeated_x, x_defeated, x_killed, killedx
      const m = low.match(/^defeated_(.+)$|^(.+)_defeated$|^(.+)_killed$|^killed_?(.+)$/);
      if (m && !MODIFIERS[low]) { const who = m[1] || m[2] || m[3] || m[4]; if (!NOT_SHOWN_KILLS.has(who)) kills.push(KILL_NAMES[who] || pretty(who)); continue; }
      effects.push(modifier(low, val));
    }
    // the preset picked when the world was made ("combat_hard:raids_more"), the exact effects on hover;
    // keys no preset sets get chips of their own
    if (preset) {
      const fx = effects.filter((e) => PRESET_KEYS.has(e[2])).map((e) => e[0]).join(", ");
      for (const part of preset.split(":")) {
        const [what, level] = part.split("_");
        if (!what) continue;
        mods.push([T("{label}: {value}", {label: T(PRESET_NAMES[what] || what), value: lvl(level)}), fx ? T("In effect: {fx}", {fx}) : part]);
      }
      mods.push(...effects.filter((e) => !PRESET_KEYS.has(e[2])));
    } else mods.push(...effects);
    const minis = Object.entries(MINI_BOSSES).map(([k, [n, where]]) => [n, T(where), set.has(k)]);
    return {mods, quests, minis, progress, kills};
  }
  return {read};
})();
