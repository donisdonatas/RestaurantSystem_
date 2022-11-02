//const buttons = document.getElementsByTagName("button");


class Car {
    constructor(brand, model) {
        this.brand = brand;
        this.model = model;
    }
}

function addItem(e) {
    e.preventDefault();
    const brand = document.getElementById('brand').value;
    const model = document.getElementById('model').value;
    //let carArr = [brand, model];
    let newCar = new Car(brand, model);
    uploadCar(newCar);
    //localStorage.setItem(localStorage.length + 1, carArr);
    //log.textContent = 'Automobilis įtrauktas į sąrašą';
}

form.addEventListener("submit", addItem);

function uploadCar(car) {
    fetch("https://olive-bead-glazer.glitch.me", {
        method: "POST",
        headers: {'Content-Type': 'application/json'}, 
        body: JSON.stringify(car)
    }).then(res => {
        console.log("Request complete! response:", res);
        writeMessage();
    });
}

function writeMessage() {
    document.getElementById('log').textContent = 'Modelis įkeltas į duombazę.';
}