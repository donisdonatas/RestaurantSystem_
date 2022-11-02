//1.
//Ne visos funkcijos turi return statement (nors dažniausiai taip yra).
//Sukurkite funkciją, į kurią paduosite vardą ir jį pa'alert'ins jį :)
function alertName(name) {
    alert(name);
}

function getName() {
    let vardas = document.getElementById("vardas").value;
    alertName(vardas);
}

//2.
//Ir ne visos funkcijos turi parametrus - sukurkite funkciją, kuri sugeneruos ir grąžins random skaičių tarp 1 ir 5.
function getRandomNumber() {
    let number = Math.random();
    number = number * 5;
    number = Math.floor(number) + 1;
    document.getElementById("randomNumber").textContent = number;
}

//3.
//Sukurkite funkciją, kuri paims du parametrus - vardą ir pavardę
// - ir grąžins sumą šių žodžių ilgių (t.y. "Petras", "Slekys" => 12).
function lengthOfFullName() {
    let vardas = document.getElementById("vardas1").value;
    let pavarde = document.getElementById("pavarde1").value;

    document.getElementById("kiekRaidziu").textContent = vardas.length + pavarde.length;
}

//4.
//Sukurkite funkciją, kuri pagal paduotą skaičių grąžins abecelės raidę (pvz. 0 => A; 1 => B; 2 => C ir t.t.).
//Hint: Jums reikės pirma sukurti Array su visomis raidėmis (["A", "B", C",..."Z"]),
// o funkcija paims pagal indeksą atitinkamą raidę.
function getLetter() {
    let raideId = document.getElementById("raidesId").value;
    let abecele = ["A", "B", "C", "D", "E", "F", "G", "H", "I", "J",
                    "K", "L", "M", "N", "O", "P", "R", "S", "T",
                    "U", "V", "X", "Y", "Z"];
    document.getElementById("kokiaRaide").textContent = abecele[raideId - 1];
}


//5.
//Sukurkite funkciją, kuri paims tris parametrus (n1, n2, operator).
// Operator gali būti "sum", "sub", "div", "multi" (matematinės reikšmės - sudėti, atimti, padalinti, padauginti).
//n1 ir n2 bus skaičiai. Turite grąžinti atsakymą, kur n1 ir n2 atlikta matematinė operacija
// (pvz.: 5, 1, "sub" => 4; 6, 3, "sum" => 9...). Hint: Reikės funkcijoje naudoti if-else arba switch.
function makeCalculations() {
    let n1 = document.getElementById("n1").value;
    let n2 = document.getElementById("n2").value;
    let operator = document.getElementById("operator").value;
    let atsakymas;
    switch(operator) {
        case "sum":
            atsakymas = n1 * 1 + n2 * 1;
            break;
        case "sum1":
            atsakymas = n1 + n2;
            break;
        case "sub":
            atsakymas = n1 - n2;
            break;
        case "div":
            atsakymas = n1 / n2;
            break;
        case "multi":
            atsakymas = n1 * n2;
            break;
        default: 
            atsakymas = "Error";
    }
    document.getElementById("atsakymas").textContent = atsakymas;
}

//6.
//Sukurkite dvi funkcijas: viena grąžina random skaičių nuo 1 iki 10 (įskaitant),
// kita - gautą skaičių pakelia kvadratu. Iškviesk abi funkcijas vienoje eilutėje
// (pvz. squareNum(generateRandomNumber()) => 1...100).
function randomSquare() {
    document.getElementById("randomKvadratas").textContent = square(generateRandomNumber());
}

function square(number) {
    let square = number * number;
    return square;
}

function generateRandomNumber() {
    let randomNumber = Math.random();
    randomNumber = randomNumber * 10;
    randomNumber = Math.floor(randomNumber) + 1;
    return randomNumber;
}