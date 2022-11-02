function getAge() {
    let age = document.getElementById("age").value;
    checkAge1(age);
}


function checkAge(age) {
    if (age > 18) {
      return true;
    } else {
      return confirm('Did parents allow you?');
    }
  }

  function checkAge1(age) {
    return age > 18 ? true : confirm('Did parents allow you?');
  }


  function min(a , b) {
    if(a < b) {
        return a;
    }
    else {
        return b;
    }
  }

function getMin() {
    let par1 = parseInt(document.getElementById("par1").value);
    let par2 = parseInt(document.getElementById("par2").value);
    alert(min(par1, par2));
}

function pow(a , b) {
    return Math.pow(a, b);
}

function getPowerArguments() {
    let par1 = document.getElementById("par1").value;
    let par2 = document.getElementById("par2").value;
    alert(pow(par1, par2));
}


function ask(question, yes, no) {
    if (confirm(question)) yes();
    else no();
    }
  
    ask(
        "Do you agree?",
        function() { alert("You agreed."); },
        function() { alert("You canceled the execution."); }
);

let ask1 = (question, yes, no) => {
    if (confirm(question)) yes();
    else no();
}

function yes() {
    alert("You agreed.");
}

function no() {
    ("You canceled the execution.");
}