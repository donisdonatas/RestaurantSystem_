const kaledos  = new Date('2022-12-25');
const siandien = new Date('2022-09-08');
let likoDienu = kaledos.getTime() - siandien.getTime();
likoDienu = likoDienu / (1000 * 60 * 60 * 24);
console.log("Iki Kalėdų liko: " + likoDienu);