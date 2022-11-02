function getBonus() {
    let stazas = parseInt(document.getElementById("stazas").value);
    let bonusas = 50;
    if(stazas >= 10 && stazas < 20) {
        bonusas += 50;
    }
    else if(stazas > 20) {
        bonusas += 150;
    }
    else {
        bonusas = bonusas;
    }
    document.getElementById("bonusas").textContent = "Jūsų bonusas: " + bonusas + " eurų";
}


function getDaysNumber() {
    let metai = parseInt(document.getElementById("metai").value);
    if(metai % 4 === 0) {
        if(metai % 100 === 0) {
            if(metai % 400 === 0) {
                document.getElementById("dienos").textContent = "Šiais metais yra 366 dienos";
            }
            else {
                document.getElementById("dienos").textContent = "Šiais metais yra 365 dienos";
            }
        }
        else {
            document.getElementById("dienos").textContent = "Šiais metais yra 366 dienos";
        }
    }
    else {
        document.getElementById("dienos").textContent = "Šiais metais yra 365 dienos";
    }
}


function convertCtoF() {
    let celsius = document.getElementById("celcijus").value;
    let farenheit = Math.round((celsius * 1.8) + 32);
    document.getElementById("farenheitFromCelcius").textContent = farenheit + "F";
}


function createRegistration() {
    let email = document.getElementById("email").value;
    let sutinku = document.getElementById("sutinku");

    if(sutinku.checked == true) {
        alert("El. paštas " + email + " sėkmingai užregistruotas");
    }
    else {
        alert("Registracija nesėkminga");
    }
}


function createList() {
    let ulList = document.getElementById("sarasas");
    let vardas = document.getElementById("vardas").value;
    let skaicius = parseInt(document.getElementById("skaicius").value);

    for(let i = skaicius; i > 0; i--) {
        let createLi = document.createElement("li");
        ulList.appendChild(createLi);
        createLi.textContent = (vardas);
    }
}


function createTriangle() {
    let trikampis = parseInt(document.getElementById("trikampis").value);
    let div = document.getElementById("viewTriangle");

    for(let i = 1; i <= trikampis; i++) {
        let createP = document.createElement("p");
        div.appendChild(createP);
        createP.textContent = repeter(i);
    }
}

function repeter(k) {
    let starText = "";
    for(let i = 0; i < k; i++) {
        starText += "*";
    }
    return starText;
}