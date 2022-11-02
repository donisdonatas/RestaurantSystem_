/**
 * https://codeacademy.online/dashboard/modules/js1/Lv8eqyizQ3LvSmYUPfiI/YMhrSBEAACIAcZqO
 */



const connection = fetch("https://robust-safe-crafter.glitch.me/")
    .then((response) => response.json())
    .then((data) => {return data;})
    .catch(error => console.error(error));

const getData = async () => {
    const receivedData = await connection;
    console.log(receivedData);
    loadDataToPage(receivedData);
};

getData();


function loadDataToPage(data) {
    data.forEach(property => {
        const divColumn = document.createElement('div');
        divColumn.className = 'column';

        const divCard = document.createElement('div');
        divCard.className = 'card';

        const divCardImage = document.createElement('div');
        divCardImage.className = 'card-image';

        const figure = document.createElement('figure');
        figure.className = 'image is-3by2';

        const image = document.createElement('img');
        image.setAttribute('src', property.image);
        image.setAttribute('alt', 'Placeholder image');

        const divCardContent = document.createElement('div');
        divCardContent.className = 'card-content';

        const divMedia = document.createElement('div');
        divMedia.className = 'media';

        const divMediaContent = document.createElement('div');
        divMediaContent.className = 'media-content';

        const pTitle = document.createElement('p');
        pTitle.className = 'title is-4';
        pTitle.textContent = `€${property.price}`;

        const pSubtitle = document.createElement('p');
        pSubtitle.className = 'subtitle is-6';
        pSubtitle.textContent = `${property.city}`;

        const pContent = document.createElement('p');
        pContent.className = 'content';
        pContent.textContent = `${property.description}`;

        divMediaContent.append(pTitle, pSubtitle);
        divMedia.append(divMediaContent);
        divCardContent.append(divMedia, pContent);

        figure.append(image);
        divCardImage.append(figure);
        divCard.append(divCardImage, divCardContent);
        divColumn.append(divCard);

        const divColumns = document.getElementsByClassName('columns');
        divColumns[0].append(divColumn);
    });
}

const buttonLink = document.getElementById('link');
buttonLink.addEventListener("click", openLink);

function openLink() {
    window.open("add.html", "_self");
}