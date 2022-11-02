function js_style() {
    const textas = document.getElementById("text");
    textas.style.color = "blue";
    textas.style.fontSize = "3em";
    textas.style.fontFamily = "Arial, black";
}

function getFormValue() {
    const getForm = document.forms["form1"];
    const forname = getForm.fname.value;
    const lastname = getForm.lname.value;

    document.getElementById("fullName").innerHTML = forname + " " + lastname;
    console.log(forname + " " + lastname);
}

function addRow() {
    const tbody = document.getElementsByTagName("tbody");   //Ok
    let child_tr = document.createElement("tr");            //Ok
    let child_th = document.createElement("th");            //OK
    let child_td1 = document.createElement("td");
    let child_td2 = document.createElement("td");
    let child_td3 = document.createElement("td");
    const getRows = tbody[0].getElementsByTagName("tr");
    child_tr.appendChild(child_th);                         //Ok
    child_th.innerHTML = ("Papildoma eilutė");
    child_tr.appendChild(child_td1);
    child_td1.innerHTML = getRows.length + 1 + "1";
    child_tr.appendChild(child_td2);
    child_td2.innerHTML = getRows.length + 1 + "2";
    child_tr.appendChild(child_td3);
    child_td3.innerHTML = getRows.length + 1 + "3";
    tbody[0].appendChild(child_tr);                         //Ok
    console.log("Body Rows Count: " + getRows.length);      //Ok
}
