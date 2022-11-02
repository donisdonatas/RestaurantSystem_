console.log("Connected");


function checkAge() {
    const personAge = document.getElementById("age").value;
    
    personAge >= 21 ? console.log("Jūs pilnametis") : console.log("Jūs nepilnametis");
}

function checkPrice() {
    let haveCard = document.getElementById("card").value;
    let discount;
    haveCard === "true" ? discount = true : discount = false;
    console.log(haveCard);
    console.log(Boolean(haveCard));
    console.log(typeof haveCard);
    discount ? console.log("2€") : console.log("5€");
}


function sumNumbers() {
    const number = document.getElementById("enterNUmber").value;
    let sumNumber = 0;

    for(let i=0; i <= number; i++) {
        sumNumber += i;
    }
    console.log("Skaičių suma: " + sumNumber);
}
