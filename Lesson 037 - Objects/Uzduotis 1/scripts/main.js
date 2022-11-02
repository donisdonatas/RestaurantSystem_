function startAccumulator() {
    let accumulator = new Accumulator(1); // initial value 1

    accumulator.read(); // adds the user-entered value
    accumulator.read(); // adds the user-entered value

    alert(accumulator.value); // shows the sum of these values
}


function Accumulator(startingValue) {
    this.value = startingValue;
    this.read = function() {
        this.value += +prompt("Add value:", "");
    };
}


//2. Movie

class Movie {
    constructor(name, year, director, budget, income) {
        this.name = name;
        this.year = year;
        this.director = director;
        this.budget = budget;
        this.income = income;
    }
    getIntroduction() {
        return "Movie: " + this.name + ". Year: " + this.year + ". Director: " + this.director;
    }
    getProfit() {
        return "Movie profit: " + (this.income - this.budget);
    }
}

let titanic = new Movie("Titanic", 1997, "James Cameron", 200_000_000, 2_201_647_264);
let forestGump = new Movie("Forrest Gump", 1994, "Robert Zemeckis", 55_000_000, 678_226_465);

console.log(titanic.getIntroduction());
console.log(forestGump.getProfit());


//3.a Car

class Car {
    constructor(brand, model, engine) {
        this.brand = brand;
        this.model = model;
        this.engine = engine;
    }
    turnOn() {
        alert("vrooOm");
    }
}

let volvo = new Car("Volvo", "S80", "diesel");

volvo.turnOn();

//3.b Car
class Car2 {
    constructor(brand, model, engine) {
        this.brand = brand;
        this.model = model;
        this.engine = engine;
        this.basePrice = 45_000;
    }
    turnOn() {
        alert("vrooOm");
    }
    getPrice() {
        switch(this.engine) {
            case "diesel":
                return this.basePrice += 5_000;
            case "electric":
                return this.basePrice += 10_000;
            case "petrol":
                return this.basePrice;
            default:
                return "No such engine";
        }
    }
}

let volvo2 = new Car2("Volvo", "S80", "diesel");

console.log(volvo2.getPrice());