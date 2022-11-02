function getNumber(e) {
    let monitorView = document.getElementById("monitor").textContent;
    let number = e.textContent;
    document.getElementById("monitor").textContent = monitorView + number;
}

function getSign(e) {
    //let equation = isAnswer();
    document.getElementById("monitor").textContent = isAnswer();
    let monitorViewText = document.getElementById("monitor").textContent;
    let sign = e.textContent;
    
    //console.log(equation);
    if(monitorViewText.slice(-1) == "+" || monitorViewText.slice(-1) == "-" || monitorViewText.slice(-1) == "*" || monitorViewText.slice(-1) == "/") {
        document.getElementById("monitor").textContent = monitorViewText.slice(0, -1) + sign;
    }
    else if(monitorViewText.includes("+") || monitorViewText.includes("-") || monitorViewText.includes("*") || monitorViewText.includes("/")) {
        document.getElementById("monitor").textContent = getAnswer() + sign;
    }
    else {
        document.getElementById("monitor").textContent = monitorViewText + sign;
    }
}

function addDecimal() {
    let monitorViewText = document.getElementById("monitor").textContent;
    if(monitorViewText.slice(-1) != ".") {
        document.getElementById("monitor").textContent = monitorViewText + ".";
    }
}


function getAnswer() {
    let monitorView = document.getElementById("monitor");
    let monitorViewText = monitorView.textContent;
    if(monitorViewText.includes("...")) {
        monitorViewText = monitorViewText.replace("...", "");
    }

    let numbers = [];
    let answer = "";
    let firstIsNegative = false;
    if(monitorViewText.charAt(0) == "-") {
        monitorViewText = monitorViewText.slice(1);
        firstIsNegative = true;
    }

    if(monitorViewText.includes("+")) {
        numbers = monitorViewText.split("+");
        answer = (firstIsNegative ? -1 : 1) * Number(numbers[0]) + Number(numbers[1]);
    }
    else if(monitorViewText.includes("-")) {
        numbers = monitorViewText.split("-");
        answer = (firstIsNegative ? -1 : 1) * Number(numbers[0]) - Number(numbers[1]);
    }
    else if(monitorViewText.includes("*")) {
        numbers = monitorViewText.split("*");
        answer = (firstIsNegative ? -1 : 1) * Number(numbers[0]) * Number(numbers[1]);
    }
    else if(monitorViewText.includes("/")) {
        numbers = monitorViewText.split("/");
        answer = (firstIsNegative ? -1 : 1) * Number(numbers[0]) / Number(numbers[1]);
    }
    else {
        answer = (firstIsNegative ? -1 : 1) * Number(monitorViewText);
    }

    let decimals = Math.floor(answer) === answer ? 0 : answer.toString().split(".")[1].length;
    if(decimals > 5) {
        answer = Number(answer).toFixed(5) + "...";
    }
    return answer;
    
}

function printAnswer() {
    let monitorView = document.getElementById("monitor");
    let monitorViewText = monitorView.textContent;
    let answer = getAnswer();
    let sign = "=";
    document.getElementById("monitor").textContent = monitorViewText + sign;
    answerField = document.createElement("span");
    answerField.id = "answer";
    answerField.textContent = answer;
    monitorView.append(answerField);
}

function clearMonitor() {
    document.getElementById("monitor").textContent = "";
}


function backSpace() {
    let monitorView = document.getElementById("monitor");
    document.getElementById("monitor").textContent = monitorView.textContent.slice(0, -1);
}

function isAnswer() {
    let span = document.getElementById("answer");
    if(span) {
        let spanText = span.textContent;
        let answer = spanText.replace("...", "");
        return answer;
    }
    else {
        let monitorView = document.getElementById("monitor");
        let monitorViewText = monitorView.textContent;
        monitorViewText = monitorViewText.replace("...", "");
        return monitorViewText;
    }
}