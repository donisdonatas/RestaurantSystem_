console.log("Connected");


function whatIsDayName() {
    const dienosNumeris = document.getElementById("dayNumber").value;
    console.log(dienosNumeris);
    switch(dienosNumeris) {
        case "1": console.log("Pirmadienis");
            break;
        case "2": console.log("Antradienis");
            break;
        case "3": console.log("Trečiadienis");
            break;
        case "4": console.log("Ketvirtadienis");
            break;
        case "5": console.log("Penktadienis");
            break;
        case "6": console.log("Šeštadienis");
            break;
        case "7": console.log("Sekmadienis");
            break;
        default: console.log("Tai nėra savaitės dienos numeris");
    }
}


function howDaysIsInMonth() {
    const metai = document.getElementById("yearNumber").value;
    const menuo = document.getElementById("monthNumber").value;

    switch(menuo) {
        case "1":
            console.log("sausis: 31");
            break;
        case "2": 
            if(metai % 4 == 0) {
                console.log("vasaris: 29");
            }
            else {
                console.log("vasaris: 28");
            }
            break;
            /*
        case "3": console.log("kovas: 31");
            break;
            */
        case "4": console.log("balandis: 30");
            break;
        case "5": console.log("gegužė: 31");
            break;
        case "6": console.log("birželis: 30");
            break;
        case "7": console.log("liepa: 31");
            break;
        case "8": console.log("rugpjūtis: 31");
            break;
        case "9": console.log("rugsėjis: 30");
            break;
        case "10": console.log("spalis: 31");
            break;
        case "11": console.log("lapkritis: 30");
            break;
        case "12": console.log("gruodis: 31");
            break;
        default: console.log("Toks mėnuo neegzisuotja.")
    }
}
