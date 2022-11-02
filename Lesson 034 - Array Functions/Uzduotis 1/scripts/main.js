/**
 * https://javascript.info/array-methods
 */


//1. Translate border-left-width to borderLeftWidth
function camelize() {
    let text = document.getElementById("textWithDash").value;
    let textArray = text.split("-");
    let camelArray = textArray.map(word => word.charAt(0).toUpperCase() + word.slice(1));
    let camelizeText = camelArrayToText(camelArray);
    console.log("camelArray: " + camelArray);
    document.getElementById("camelizeText").textContent = camelizeText;
}

function camelArrayToText(camelArray) {
    let camelizeText = "";
    for(let word of camelArray) {
        camelizeText += word;
    }
    camelizeText = camelizeText.charAt(0).toLowerCase() + camelizeText.slice(1);
    return camelizeText;
}

//2. Filter range
function initializeFilter() {
    let arr = [5, 3, 8, 1];
    let filtered = filterRange(arr, 1, 4);
    document.getElementById("originalArray2").textContent = "originalArray: " + arr;
    document.getElementById("filteredArray2").textContent = "filteredArray: " + filtered;
}

function filterRange(array, minValue, maxValue) {
    return array.filter(item => (item >= minValue && item <= maxValue));
}

//3. Filter range "in place"
function initializeFilterRange() {
    let arr = [5, 3, 8, 1];
    let filteredArray = filterRangeInPlace(arr, 1, 4); // removed the numbers except from 1 to 4
    document.getElementById("originalArray3").textContent = "originalArray: " + arr.length;
    document.getElementById("filteredArray3").textContent = "filteredArray: " + filteredArray + ". Array length: " + filteredArray.length;
}

function filterRangeInPlace(arr, numFrom, numTo) {
    return arr.filter(item => (item >= numFrom && item <= numTo));
}

//4. Sort in decreasing order
function initializeSort() {
    let arr = [5, 2, 1, -10, 8];
    document.getElementById("originalArray4").textContent = "originalArray: " + arr;
    arr.sort(ascending);
    arr.reverse();
    document.getElementById("sortedArray4").textContent = "sortedArray: " + arr;
}

function ascending(a, b) {
    if (a > b) return 1;
    if (a == b) return 0;
    if (a < b) return -1;
}

//5. Copy and sort array
function initializeCopySort() {
    let arr = ["HTML", "JavaScript", "CSS"];
    let copy = arr.slice(0);
    let sorted = copySorted(copy);
    document.getElementById("originalArray5").textContent = "originalArray: " + arr;
    document.getElementById("sortedArray5").textContent = "sortedArray: " + sorted;
}

function copySorted(array) {
    let copyArray = array;
    return copyArray.sort();
}

//6. Create an extendable calculator
function makeCalculations() {
    let stringToCalculate = document.getElementById("mathString").value;
    let sumOperator = stringToCalculate.includes("+");
    let minusOperator = stringToCalculate.includes("-");
    let numbersArray = [];
    if(sumOperator) {
        numbersArray = stringToCalculate.split("+");
        let sum = calc(numbersArray, "+");
        console.log("Sum: " + sum);
        document.getElementById("mathOutput").textContent = "Sum: " + sum;
    }
    else if(minusOperator) {
        numbersArray = stringToCalculate.split("-");
        let delta = calc(numbersArray, "-");
        console.log("Delta: " + delta);
        document.getElementById("mathOutput").textContent = "Delta: " + delta;
    }
    console.log(numbersArray);
}

function calc(numbersArray, operator) {
    switch(operator) {
        case "+":
            return +numbersArray[0] + +numbersArray[1];
        case "-":
            return +numbersArray[0] - +numbersArray[1];
        default:
            return "Err";
    }
}


//7. Map to names
function mapNames() {
    let john = { name: "John", age: 25 };
    let pete = { name: "Pete", age: 30 };
    let mary = { name: "Mary", age: 28 };

    let users = [ john, pete, mary ];

    let names = users.map(user => user.name);

    document.getElementById("namesArray").textContent = "Names Array: " + names;
}


//8. Shuffle an array
function shufleArray() {
    let arr = [1, 2, 3];
    let shufle = [];
    let min = arr.length > 0 ? 1 : 0;
    let max = arr.length;
    
    while(shufle.length < arr.length) {
        let randomIndex = Math.floor(Math.random() * Number(max)) + Number(min) - 1;
        console.log("Random Index: " + randomIndex);
        if(shufle.indexOf(arr[randomIndex]) == -1) {
            shufle.push(arr[randomIndex]);
        }
        else {
            let indexIncluded = false;
            let i = 0;
            let ii = 0;
            do {
                let caseNr = randomIndex + 1 + i < arr.length ? "1" : "2";
                switch(caseNr) {
                    case "1":
                        if(shufle.indexOf(arr[randomIndex + 1 + i]) == -1) {
                            shufle.push(arr[randomIndex + 1 + i]);
                            indexIncluded = true;
                        }
                        else {
                            i++;
                        }
                        break;
                    case "2":
                        if(shufle.indexOf(arr[0 + ii]) == -1) {
                            shufle.push(arr[0 + ii]);
                            indexIncluded = true;
                        }
                        else {
                            ii++;
                        }
                        break;
                    default:
                        console.log("Err!");
                }
            } while (!indexIncluded);
        }
    }

    document.getElementById("originalArray8").textContent = "Original Array: " + arr;
    document.getElementById("shufleArray8").textContent = "Shufle Array: " + shufle;
}

function shuffle(arr) {
    //let arr = [1, 2, 3];
    let shufle = [];
    let min = arr.length > 0 ? 1 : 0;
    let max = arr.length;
    
    while(shufle.length < arr.length) {
        let randomIndex = Math.floor(Math.random() * Number(max)) + Number(min) - 1;
        if(shufle.indexOf(arr[randomIndex]) == -1) {
            shufle.push(arr[randomIndex]);
        }
        else {
            let indexIncluded = false;
            let i = 0;
            let ii = 0;
            do {
                let caseNr = randomIndex + 1 + i < arr.length ? "1" : "2";
                switch(caseNr) {
                    case "1":
                        if(shufle.indexOf(arr[randomIndex + 1 + i]) == -1) {
                            shufle.push(arr[randomIndex + 1 + i]);
                            indexIncluded = true;
                        }
                        else {
                            i++;
                        }
                        break;
                    case "2":
                        if(shufle.indexOf(arr[0 + ii]) == -1) {
                            shufle.push(arr[0 + ii]);
                            indexIncluded = true;
                        }
                        else {
                            ii++;
                        }
                        break;
                    default:
                        console.log("Err!");
                }
            } while (!indexIncluded);
        }
    }
    return shufle;
}

// counts of appearances for all possible permutations
let count = {
    '123': 0,
    '132': 0,
    '213': 0,
    '231': 0,
    '321': 0,
    '312': 0
};
  
for (let i = 0; i < 1000000; i++) {
    let array = [1, 2, 3];
    let shufle = shuffle(array);
    count[shufle.join('')]++;
}
  
// show counts of all possible permutations
for (let key in count) {
    console.log(`${key}: ${count[key]}`);
}


//9. Get average age
function getAverageAge() {
    let john = { name: "John", age: 25 };
    let pete = { name: "Pete", age: 30 };
    let mary = { name: "Mary", age: 29 };

    let arr = [john, pete, mary];
    let ages = arr.map(user => user.age);
    let totalAge = 0;
    for(let i = 0; i < ages.length; i++) {
        totalAge += ages[i];
    }

    document.getElementById("averageAge").textContent = "Average Age: " + totalAge/ages.length;
}

//10. Filter unique array members
function uniqueArray() {
    let strings = ["Hare", "Krishna", "Hare", "Krishna",
                    "Krishna", "Krishna", "Hare", "Hare", ":-O"
                ];
    let uniqueArray = [];
    for(let string of strings) {
        if(uniqueArray.indexOf(string) === -1) {
            uniqueArray.push(string);
        }
    }
    document.getElementById("uniqueArray").textContent = "Unique Array made with indexOf and for-of loop: " + uniqueArray;
}

function uniqueArray2() {
    let strings = ["Hare", "Krishna", "Hare", "Krishna",
                    "Krishna", "Krishna", "Hare", "Hare", ":-O"
                ];
    let uniqueSet = new Set(strings);
    uniqueArray = Array.from(uniqueSet);
    document.getElementById("uniqueArray2").textContent = "Unique Array with Set: " + uniqueArray;
}

//11. Create keyed object from array
function createObject() {
    let users = [
        {id: 'john', name: "John Smith", age: 20},
        {id: 'ann', name: "Ann Smith", age: 24},
        {id: 'pete', name: "Pete Peterson", age: 31},
    ];

    let newObject = {};

    for(let user of users) {
        let key = user.id;
        newObject[key] = user;
    }
    document.getElementById("object").textContent = newObject;
    console.log(newObject);
}