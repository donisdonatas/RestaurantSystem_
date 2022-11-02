
document.getElementById("genres").addEventListener("submit", task2);

function newfunction(event){
  event.preventDefoult();
  let Classic = document.createElement("option");
  option.value = "Classic";
  option.text = "Classic";
}
genres.append(Classic);


function task2() {
  let selectForm = document.getElementById("genres");
  let option = new Option("Classic", "classic");
  selectForm.appendChild(option);
}


document.getElementById("genres").addEventListener("change", addActivityItem, false);


function addActivityItem(){
  //option is selected
  alert("yeah");
}