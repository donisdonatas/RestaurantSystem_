/**
 * Užduotis Nr. 1
 */

console.log("Hello world");
alert("I Love JavaScript");
window.alert("Ready to learn more?");
let skaicius = prompt("Įveskite skaičių nuo 1 iki 10");
console.log(skaicius);


/**
 * Užduotis Nr 2
 */

let birthDay = "Kovo 18";
let inputMessage = "Įveskite vardą";

let nameD = prompt(inputMessage);
console.log(nameD + " yra gimęs " + birthDay);


/**
 * Užduotis nr. 3
 */

let bazynisDydis = prompt("Įveskite bazinį užmokesčio dydį");
let partBudget = 1761463 * bazynisDydis / 8487300000 * 100;
console.log(partBudget + "%");
document.write(Math.round(partBudget) + "%");

