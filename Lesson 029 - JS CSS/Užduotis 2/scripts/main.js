//1. Write a function that takes two integers (hours, minutes), converts them to seconds, and adds them.
function timeConverter() {
    let hours = document.getElementsByName("hours")[0].value;
    let minutes = document.getElementsByName("minutes")[0].value;

    hours = Number(hours);
    minutes = Number(minutes);
    seconds = hours * 60 * 60 + minutes * 60;
    document.getElementById("seconds").textContent = seconds + "seconds";
}


//2. You need to create two functions to substitute toString() and parseInt();
//A function called intToString() that converts integers into strings and a function called stringToInt()
// that converts strings into integers.

function intToString() {
    let number = document.getElementsByName("integer")[0].value;
    number = String(number);
    document.getElementById("number").textContent = number + " - this is " + typeof number;
}

function stringToInt() {
    let text = document.getElementsByName("text")[0].value;
    text = Number(text);
    document.getElementById("text").textContent = text + " - this is " + typeof text;
}

//3. Create a function that takes a boolean variable flag and returns it as a string.

function boolToString() {
    let boolean = document.getElementsByName("boolean")[0].value;
    boolean = Boolean(boolean);
    document.getElementById("boolean1").textContent = boolean + " - this is " + typeof boolean;
    boolean = String(boolean);
    document.getElementById("boolean2").textContent = boolean + " - this is " + typeof boolean;
}