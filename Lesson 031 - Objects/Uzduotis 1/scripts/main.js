/*
function makeUser() {
    return {
      name: "John",
      ref: this
    };
  }
  
  let user = makeUser();
  
  alert( user.ref.name ); // What's the result?
*/

function makeCalculations() {
    let calculator = {
        // ... your code ...
        read() {
            this.a = prompt("Įveskite raikšmę a", "");
            this.b = prompt("Įveskite raikšmę b", ""); 
        },
        sum() {
            return Number(this.a) + Number(this.b);
        },
        mul() {
            return Number(this.a) * Number(this.b);
        },
    };

    calculator.read();
    alert( calculator.sum() );
    alert( calculator.mul() );
}


function makeChaining() {
    let ladder = {
        step: 0,
        up() {
          this.step++;
        },
        down() {
          this.step--;
        },
        showStep: function() { // shows the current step
          alert( this.step );
        }
      };

    /*
    ladder.up();
    ladder.up();
    ladder.down();
    ladder.showStep(); // 1
    ladder.down();
    ladder.showStep(); // 0
    */
   
    ladder.showStep(ladder.down(ladder.showStep(ladder.down(ladder.up(ladder.up())))));
}