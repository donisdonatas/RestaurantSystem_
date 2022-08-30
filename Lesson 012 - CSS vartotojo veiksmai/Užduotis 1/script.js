var input = document.getElementById("cnumber");

input.onkeydown = function () {
    if (input.value.length > 0) {
        if (input.value.length % 4 == 0) {
            input.value += "  ";
        }
    }
}