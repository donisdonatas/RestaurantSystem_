//A maximal subarray
function getContiguousArray() {
    let optionArr = document.getElementById("array");
    let selectedArr = optionArr.selectedIndex;
    let selectedValue = optionArr[selectedArr].value;
    
    let arr = getArray(selectedValue);
    let sortedArr = arr.sort(compareNumeric);
    let maxSubArrSum = splitToSubArrays(sortedArr);

    document.getElementById("sumOfArray").textContent = maxSubArrSum;
}

function getArray(arrIndex) {
    switch(arrIndex) {
        case "1":
            return arr = [-1, 2, 3, -9];
        case "2":
            return arr = [2, -1, 2, 3, -9];
        case "3":
            return arr = [-1, 2, 3, -9, 11];
        case "4":
            return arr = [-2, -1, 1, 2];
        case "5":
            return arr = [100, -9, 2, -3, 5];
        case "6":
            return arr = [1, 2, 3];
        case "7":
            return arr = [1, -2, 3, 4, -9, 6];
        default:
            break;
    }
}

function compareNumeric(a, b) {
    if (a > b) return 1;
    if (a == b) return 0;
    if (a < b) return -1;
}

  function getMaxSubSum(arr) {
        let sumOfSubArr = 0;
    for(let a of arr) {
        sumOfSubArr += a;
    }
    return sumOfSubArr;
  }

function splitToSubArrays(mainArray) {
    let arr1 = [];
    let arr2 = [];
    let arr3 = [];
    for(let i = 0; i < mainArray.length; i++) {
        if(i == 0 || arr1.at(-1) == mainArray[i] || arr1.at(-1) + 1 == mainArray[i]) {
            arr1.push(mainArray[i]);
        }
        else if(arr2.length == 0 || arr2.at(-1) == mainArray[i] || arr2.at(-1) + 1 == mainArray[i]) {
            arr2.push(mainArray[i]);
        }
        else {
            arr3.push(mainArray[i]);
        }
    }
    let sumSubArr1 = getMaxSubSum(arr1);
    let sumSubArr2;
    if(arr2.length > 0) {
        sumSubArr2 = getMaxSubSum(arr2);
    }
    let maxSumSubArr = sumSubArr1;
    if(arr3.length > 0) {
		let newArray = arr2.concat(arr3);
        sumSubArr2 = splitToSubArrays(newArray);
    }
    if(sumSubArr1 < sumSubArr2) {
        maxSumSubArr = sumSubArr2;
    }
    return maxSumSubArr;
}