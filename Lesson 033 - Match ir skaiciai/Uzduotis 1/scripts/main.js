function readNumber() {
    let number;
  
    do {
      number = prompt("Enter any number:");
    } while ( !isFinite(number) );
  
    if (number === null || number === '') {
        number = null;
    }
  
    document.getElementById("number").textContent = "You entered: " + number;
}
  
function getRandomNumber() {
    let min = document.getElementById("min").value;
    let max = document.getElementById("max").value;
    let randomNumber = Math.random() * (Number(max) - Number(min)) + Number(min);
    document.getElementById("random").textContent = randomNumber;
}


let clicksHistory = [];

function getRandomInteger() {
    let min = document.getElementById("minInt").value;
    let max = document.getElementById("maxInt").value;
    let randomInteger = Math.floor(Math.random() * Number(max)) + Number(min);
    clicksHistory.push(randomInteger);
    document.getElementById("randomInt").textContent = randomInteger;
}



function showHistory() {
    console.log(clicksHistory);
    let uniqueList = new Set(clicksHistory);
    let uniqueArray = Array.from(uniqueList).sort();
    let uniqueCountArray = [];
    for(let i = 0; i < uniqueArray.length; i++) {
        uniqueCountArray.push(0);
    }
    for(let i = 0; i < clicksHistory.length; i++) {
        uniqueCountArray[uniqueArray.indexOf(clicksHistory[i])]++;
    }
    let table = document.getElementsByTagName("table");
    let trh = document.createElement("tr");
    let trd = document.createElement("tr");
    let trp = document.createElement("tr");
    for(let i = 0; i < uniqueArray.length; i++) {
        let th = document.createElement("th");
        th.textContent = uniqueArray[i];
        trh.appendChild(th);

        let td = document.createElement("td");
        td.textContent = uniqueCountArray[i];
        trd.appendChild(td);

        let tdp = document.createElement("td");
        tdp.textContent = Math.round(td.textContent / clicksHistory.length * 100) + "%";
        trp.appendChild(tdp);
    }
    th = document.createElement("th");
    th.textContent = "Total";
    trh.appendChild(th);

    let td = document.createElement("td");
    td.textContent = clicksHistory.length;
    trd.appendChild(td);
    trd.style.fontStyle = "bold";

    let tdp = document.createElement("td");
    tdp.textContent = "100%";
    trp.appendChild(tdp);
    trp.style.fontStyle = "bold";

    table[0].appendChild(trh);
    table[0].appendChild(trd);
    table[0].appendChild(trp); 

    table[0].style.borderCollapse = "collapse";
    let thtd = table[0].querySelectorAll("th, td");
    for(let i = 0; i < thtd.length; i++) {
        thtd[i].style.border = "1px solid black";
        thtd[i].style.textAlign = "center";
        thtd[i].style.padding = "2px 5px";
    }
}