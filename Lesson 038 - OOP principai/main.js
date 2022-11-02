class Vehicle {
    _model;
    _speed;

    constructor() {
        this._model = "Tesla";
        this._speed = 100;
    }
    getModel() {
        return this._model;
    }
    getSpeed() {
        return this._speed;
    }
}

class Car extends Vehicle {
    constructor() {
        super();
    }
    setDetails(name) {
        this.name = name;
    }
    getDetails(carName) {
        return carName + ", " + this.getModel() + ", " + this.getSpeed();
    }
}

let x = new Car();
let y = new Car();

x.setDetails("X");
y.setDetails("Y");

console.log(x.getDetails("X"));
console.log(x.getDetails("Y"));