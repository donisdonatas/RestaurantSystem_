//1. Parašykite funkciją, kuri suskaičiuos ir išspausdins balses žodyje.
function countVowel() {
    let zodis = document.getElementById("zodis").value;
    console.log(zodis);
    let balses = "";
    for(let i = 0; i < zodis.length; i++) {
        let raide = zodis.charAt(i);
        if(raide === "a" || raide === "e" || raide === "i" || raide === "y" || raide === "o" || raide === "u" || 
           raide === "ą" || raide === "ę" || raide === "ė" || raide === "į" || raide === "ų" || raide === "ū") {
            balses += raide;
        }
        //console.log(raide);
        //console.log(zodis.length);
    }
    document.getElementById("lettesVovel").textContent = "Raidės - " + zodis.length + ". Balsės: " + balses;
}

//2. Parašykite 2 funkcijas, viena turi konvertuoti celsijų į farenheitą, kita farenheitą į celsijų.

function convertCtoF() {
    let celsius = document.getElementById("celcijus").value;
    let farenheit = Math.round((celsius * 1.8) + 32);
    document.getElementById("farenheitFromCelcius").textContent = farenheit + "F";
}

function convertFtoC() {
    let farenheit = document.getElementById("farenheitas").value;
    let celsius = Math.round((farenheit - 32) * (5/9));
    document.getElementById("celciusFromFarenheit").textContent = celsius + "C";
}