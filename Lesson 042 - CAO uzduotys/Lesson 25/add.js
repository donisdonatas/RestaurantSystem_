class Product {
    constructor(image, title, price) {
        this.image = image;
        this.title = title;
        this.price = price;
    }
}

const addButton = document.getElementById('addProductButton');
addButton.addEventListener("click", addItem);

function addItem(e) {
    e.preventDefault();
    const image = document.getElementById('image').value;
    const title = document.getElementById('title').value;
    const price = document.getElementById('price').value;
    const product = new Product(image, title, price);
    uploadProduct(product);
}

function uploadProduct(product) {
    fetch("https://golden-whispering-show.glitch.me", {
        method: "POST",
        headers: {'Content-Type': 'application/json'}, 
        body: JSON.stringify(product)
    }).then(res => {
        console.log("Request complete! response:", res);
        writeMessage();
    });
}

function writeMessage() {
    const message = document.createElement('p');
    message.textContent = "Produktas įkeltas į prekių katalogą sėkmingai.";
    const form = document.querySelector('form');
    form.append(message);
    redirectPage();
}

function redirectPage() {
    let tID = setTimeout(function () {
        window.open('index.html', '_self');
        window.clearTimeout(tID);		// clear time out.
    }, 2000);
}