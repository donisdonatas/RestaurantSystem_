//Use JavaScript to:

//1. Show the value and the text of the selected option.
//Add an option: <option value="classic">Classic</option>.
//Make it selected.
//Note, if you’ve done everything right, your alert should show blues.

function task1() {
    let options = document.getElementsByTagName("option");
    for(let i = 0; i < options.length; i++) {
        if(options[i].selected === true) {
            alert(options[i].value + " - " + options[i].textContent);
        }
    }
}

document.getElementById("genres").addEventListener("change", task2);

function task2() {
    let selectForm = document.getElementById("genres");
    let option = new Option("Classic", "classic");
    selectForm.appendChild(option);
}

function task3() {
    let selectForm = document.getElementsByTagName("option");
    selectForm[1].selected = false;
    selectForm[2].selected = true;
}