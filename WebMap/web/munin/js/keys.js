// ForgeMap: letters by where they sit on the keyboard (e.code), not what they type, so the moves
// sit under the left hand on any layout: W A S D on a QWERTY keyboard are Z Q S D on an AZERTY one
// (bug-controles-qwerty). Other keys (arrows, Shift, + -...) by their name.
export const keyOf = (e) => { const m = /^Key([A-Z])$/.exec(e.code || ''); return m ? m[1].toLowerCase() : e.key.length === 1 ? e.key.toLowerCase() : e.key; };
