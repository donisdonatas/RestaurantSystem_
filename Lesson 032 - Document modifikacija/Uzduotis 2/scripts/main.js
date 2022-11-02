function addItemToList() {
    const ul = document.querySelector("ul");
    
    const span = document.createElement("span");
    const input = document.getElementById("item").value;
    span.textContent = input;
    const li = document.createElement("li");
    const button = document.createElement("button");
    button.textContent = "Delete";
    button.className = "deleteButton";
    //button.onclick = () => {deleteItem();};
    
    clearInput();
    focusInput();
    
    li.appendChild(span);
    li.appendChild(button);
    ul.appendChild(li);
    button.addEventListener('click', () => {
        ul.removeChild(li);
    });
}

function clearInput() {
    document.getElementById("item").value = "";
}

function focusInput() {
    document.getElementById("item").focus();
}



function deleteItem() {
    //kaip padaryti, kad šita funcija veiktų?
    console.log("Delete button clicked!!!");
    const ul = document.querySelector("ul");
    const li = document.getElementsByTagName("li");
    console.log(li);
    ul.removeChild(li[1]);  //Čia vietoje 1 reikia, kažkaip įdėti eilės numerį
}

