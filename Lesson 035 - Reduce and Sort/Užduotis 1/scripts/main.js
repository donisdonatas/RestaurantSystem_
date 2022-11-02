//1. Pasirašyk sąrašą su savo draugų vardais. A-Z tvarka išrykiuok.
let draugai = ["Tadas", "Mantas", "Donatas", "Ovidijus", "Darius", "Karolis"];
let skaiciai = [5, 10, 20, 11, 12, 1, 0, 14, 25];
let array = [10, 5, 20, 4];
let auto = ["BMW", "MCB", "VWG", "Toyota", "AUDI"];

function sortNames() {
    draugai.sort();
    document.getElementById("draugaiAZ").textContent = draugai;
}

function sortNamesDescending() {
    draugai.sort((a, b) => b > a ? 1 : -1);
    document.getElementById("draugaiZA").textContent = draugai;
}

function sortNumbers() {
    skaiciai.sort((a, b) => b > a ? 1 : -1);
    document.getElementById("numbersZA").textContent = skaiciai;
}

function getMaxNumber() {
    array.sort((a, b) => b - a);
    document.getElementById("maxNumber").textContent = array[array.length-1];
}

function sumNumbers() {
    let suma = skaiciai.reduce((a, b) => b + a);
    document.getElementById("suma").textContent = suma;
}

function countElements() {
    elementai = auto.reduce(function (accumulator, currentValue) {
        if (currentValue.length === 3) {
            accumulator.push(currentValue);
        }
            return accumulator;
    }, []);
    document.getElementById("elements").textContent = elementai.length;
}

function countElementLenghts(accumulator, currentValue) {
    if(accumulator.length == 3) {
        accumulator.push(currentValue);
    }
    return accumulator;
}

function getMaxReduce() {
    let maxReduce = skaiciai.reduce((a,v) => a > v ? a : v);
    document.getElementById("maxReduce").textContent = maxReduce;
}

const people = [
    {
      name: "Petras",
      age: "18"
    },
    {
      name: "Jonas",
      age: 15
    },
    {
      name: "Antanas",
      age: 20
    },
    {
      name: "Urtė",
      age: 10
    },
    {
      name: "Diana",
      age: 25
    },
    {
      name: "Ieva",
      age: 16
    }
];

function filterByAge() {
    console.log(people.filter(x => x.age >= 18));
}

function showNames() {
    console.log(people.map(mapNames));
}

function mapNames(x) {
    if(x.age >= 18) {
        return x.name;
    }
    return;
}

const products = [
    {name: "lemonade", price: 50},
    {name: "lime", price: 10},
    {name: "milk", price: 4},
    {name: "potatos", price: 10},
    {name: "bread", price: 15}
];

function getMinMaxProduct() {
    products.sort((a, b) => a.price - b.price);
    let minMaxProducts = [];
    minMaxProducts.push(products[products.length - 1]);
    minMaxProducts.push(products[0]);

    console.log(minMaxProducts);
}