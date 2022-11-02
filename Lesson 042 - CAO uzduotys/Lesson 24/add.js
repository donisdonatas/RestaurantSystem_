
class Property {
    constructor(image, city, price, description) {
        this.image = image;
        this.city = city;
        this.price = price;
        this.description = description;
    }
}

const button = document.getElementById('add');
button.addEventListener("click", addItem);

function addItem(e) {
    e.preventDefault();
    const image = document.getElementById('image').value;
    const city = document.getElementById('city').value;
    const price = document.getElementById('price').value;
    const description = document.getElementById('description').value;
    let property = new Property(image, city, price, description);
    uploadProperty(property);
}

function uploadProperty(property) {
    fetch("https://robust-safe-crafter.glitch.me/", {
        method: "POST",
        headers: {'Content-Type': 'application/json'}, 
        body: JSON.stringify(property)
    }).then(res => {
        console.log("Request complete! response:", res);
        //writeMessage();
    });
}

function writeMessage() {
    document.getElementById('log').textContent = 'Modelis įkeltas į duombazę.';
}

/**
 * {
    image: string,
    city: string,
    price: number,
    description: string
}
 */

const buttonLink = document.getElementById('link');
buttonLink.addEventListener("click", openLink);

function openLink() {
    window.open("index.html", "_self");
}

/**
 * https://aruodas-img.dgn.lt/object_62_105586669/vilnius-santariskes-dangerucio-g-3.jpg
 * https://aruodas-img.dgn.lt/object_62_105282200/kaunas-zemieji-sanciai-kranto-al-3.jpg
 * https://aruodas-img.dgn.lt/object_62_98036379/vilnius-siaures-miestelis-j-galvydzio-g.jpg
 */