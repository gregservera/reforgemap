// Munin's page over ForgeMap's websocket (munin/js/net.js): ForgeMap's "<type>\n<payload>" frames
// read as the {t, ...} frames Munin's layers listen for.
import { test } from "node:test";
import assert from "node:assert/strict";

const { frame } = await import("../../WebMap/web/munin/js/net.js");

// A re-drawn tile the page never hears of stays stale until a reload.
test("a tiles frame becomes Munin's, keys and status", () => {
  assert.deepEqual(frame('tiles\n{"keys":["5/12/34"],"status":"40/3"}'), {t: "tiles", keys: ["5/12/34"], status: "40/3"});
});

// Markers the page never hears of stay as they were at load: a boat stuck, a base under its old name.
test("a markers frame carries the server's markers rev", () => {
  assert.deepEqual(frame("markers\n42"), {t: "markers", rev: 42});
});

// The Events panel, the raid circle and the invasions only hear of the world through these.
test("events, raid and invasions frames carry their JSON", () => {
  assert.deepEqual(frame('events\n[{"type":"join","name":"W"}]'), {t: "events", data: [{type: "join", name: "W"}]});
  assert.deepEqual(frame("raid\nnull"), {t: "raid", data: null});
  assert.deepEqual(frame('invasions\n[{"id":1}]'), {t: "invasions", data: [{id: 1}]});
  assert.equal(frame("events\nnot json"), null);
});

test("reload is reload, and what the map does not use yet is nothing", () => {
  assert.deepEqual(frame("reload\n"), {t: "reload"});
  assert.equal(frame('players\n{"players":[]}'), null);
  assert.equal(frame("messages\n[]"), null);
  assert.equal(frame("tiles\nnot json"), null);
});

// Players the page never hears of are not on the map; the playback paces itself by ts.
test("a live frame is Munin's players frame, its data as sent", () => {
  const f = frame('live\n{"ts":1700000000000,"players":[{"id":7,"name":"Rurik","x":1.5,"z":-2,"yaw":90}]}');
  assert.equal(f.t, "players");
  assert.equal(f.data.ts, 1700000000000);
  assert.deepEqual(f.data.players[0], {id: 7, name: "Rurik", x: 1.5, z: -2, yaw: 90});
  assert.equal(frame("live\n{"), null);
});

// A pin placed or taken up anywhere shows on every open map at once.
test("pin and rmpin frames are Munin's, the text whole", () => {
  assert.deepEqual(frame("pin\nweb\nw17\nfire\nRurik\n12.5,-40\nCamp, by the lake"),
                   {t: "pin", id: "w17", type: "fire", name: "Rurik", x: 12.5, z: -40, text: "Camp, by the lake"});
  assert.deepEqual(frame("rmpin\nw17"), {t: "rmpin", id: "w17"});
  assert.equal(frame("pin\nweb\nw17"), null);
});

// A spot pinged on someone's map in game shows on every open map.
test("an in-game ping is Munin's ping frame", () => {
  assert.deepEqual(frame("ping\n76561198\nRurik\n12.5,-40"), {t: "ping", id: "76561198", name: "Rurik", x: 12.5, z: -40});
  assert.equal(frame("ping\nx"), null);
});
