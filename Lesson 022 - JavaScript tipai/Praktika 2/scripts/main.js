function checkAge() {
    const legalAge = 20;
    const clientAge = document.getElementById("clientAge").value;

    if(clientAge >= legalAge) {
        alert("Klientas jau pasiekęs legalAge.");
        document.getElementById("isLegalAge").innerHTML  = "Klientas jau pasiekęs legalAge.";
    }
    else {
        alert("Klientas nepasiekęs legalAge!");
        document.getElementById("isLegalAge").innerHTML  = "Klientas nepasiekęs legalAge!";
    }
}

function checkNameLenght() {
    const myName = document.getElementById("myName").value;
    if(myName.length > 6) {
        alert("Mano vardas yra ilgas");
        document.getElementById("nameLenght").innerHTML  = "Mano vardas yra ilgas";
    }
    else {
        document.getElementById("nameLenght").innerHTML  = "Mano vardas nėra ilgas";
    }
}

function checkAge2() {
    const myAge = document.getElementById("myAge").value;
    if(myAge > 100 || myAge < 0) {
        alert("Invalid age");
        document.getElementById("isLegalAge2").innerHTML  = "Invalid age";
    }
    else if(myAge >= 1 && myAge <= 18) {
        alert("Child");
        document.getElementById("isLegalAge2").innerHTML  = "Child";
    }
    else {
        alert("Adult");
        document.getElementById("isLegalAge2").innerHTML  = "Adult";
    }
}


function checkCarGroup() {
    const car = document.getElementById("carBrand").value;
    const vwGroup = ["VW", "Audi", "Bentley", "Bugatti", "Lamborghini", "Porsche"];
    const bmwGroup = ["BMW", "Mini", "Rolls-Royce"];
    let foundCar = false;

    for(let i = 0; i < vwGroup.length; i++) {
        if(car == vwGroup[i]) {
            alert("Brandas priklauso VW Grupei");
            document.getElementById("carGroup").innerHTML = "Brandas priklauso VW Grupei";
            foundCar = true;
        }
    }

    for(let j = 0; j < bmwGroup.length; j++) {
        if(car == bmwGroup[j]) {
            alert("Brandas priklauso BMW Grupei");
            document.getElementById("carGroup").innerHTML = "Brandas priklauso BMW Grupei";
            foundCar = true;
        }
    }

    if(!foundCar) {
        document.getElementById("carGroup").innerHTML = "Brandas nepriklauso nei vienai grupei";
    }
}