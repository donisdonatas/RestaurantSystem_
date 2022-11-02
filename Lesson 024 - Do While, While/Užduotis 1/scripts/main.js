//1.
for(let i=0; i<=15; i++) {
    if(i % 2 === 0) {
        console.log(i + " - lyginis");
    }
    else {
        console.log(i + " - nelyginis");
    }
}

console.log("=======================");
//2.
let j = 1;
do {
    if((j % 3 == 0) && (j % 5 == 0)) {
        console.log(j + " - FizzBuzz");
    }
    else if(j % 3 == 0) {
        console.log(j + " - Fizz");
    }
    else if(j % 5 == 0) {
        console.log(j + " - Buzz");
    }
    else {
        //Nothing
    }
    j++;
} while(j <= 100);

console.log("=======================");
//3.
var arr = [2, 45, 3, 67, 34, 567, 34, 345, 123];
let max = arr[0];
for(let a = 1; a < arr.length; a++) {
    if(max < arr[a]) {
        max = arr[a];
    }
}
console.log("Array max is: " + max);