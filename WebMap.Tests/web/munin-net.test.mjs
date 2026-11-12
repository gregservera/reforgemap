// Munin's page over ForgeMap's websocket (munin/js/net.js): ForgeMap's "<type>\n<payload>" frames
// read as the {t, ...} frames Munin's layers listen for.
import { test } from "node:test";
import assert from "node:assert/strict";

const { frame } = await import("../../WebMap/web/munin/js/net.js");

// A re-drawn tile the page never hears of stays stale until a reload.
test("a tiles frame becomes Munin's, keys and status", () => {
  assert.deepEqual(frame('tiles\n{"keys":["5/12/34"],"status":"40/3"}'), {t: "tiles", keys: ["5/12/34"], status: "40/3"});
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
