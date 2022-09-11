function whenIsCristmas() {
    const enterDate = document.getElementById("enterDate").value;
    const kaledos  = new Date('2022-12-25');
    const usedDate = new Date(enterDate);
    let kiekLikoDienu = kaledos.getTime() - usedDate.getTime();
    kiekLikoDienu = kiekLikoDienu / (1000 * 60 * 60 * 24);
    console.log(kiekLikoDienu);
    if(kiekLikoDienu > 0) {
        document.getElementById("kadaKaledos").innerHTML  = "Kalėdos bus už " + kiekLikoDienu + " dienų";
    }
    else {
        document.getElementById("kadaKaledos").innerHTML  = "Kalėdos jau buvo";
    }
}