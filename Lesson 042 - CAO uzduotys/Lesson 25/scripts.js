/**
 * https://codeacademy.online/dashboard/modules/js1/OcTbn3MwBK45RrtIFkZ2/YMm_mBEAACQAd368
 */

const products = {};

async function fetchData() {
    try {
        let response = await fetch('https://golden-whispering-show.glitch.me');
        if (response.ok) {
            products.arr = await response.json();
            loadDataToPage(products.arr);
        }
    } catch (error) {
        console.error(error);
    }
}
   
fetchData();

function loadDataToPage(productShelf) {
    const shelf = document.querySelector('.productShelf');
    productShelf.forEach(product => {
        const card = document.createElement('div');
        card.className = 'card';
        

        const figure = document.createElement('figure');
        figure.className = 'image-prop';

        const picture = document.createElement('img');
        picture.setAttribute('src', product.image);
        picture.setAttribute('alt', product.title);

        const contentArea = document.createElement('div');
        contentArea.className = 'card-content';

        const prodTitle = document.createElement('p');
        prodTitle.className = 'title';
        prodTitle.textContent = product.title;

        const prodPrice = document.createElement('p');
        prodPrice.className = 'price';
        prodPrice.textContent = `\u20AC${product.price}`;

        const deleteButton = document.createElement('button');
        deleteButton.id = product.id;
        deleteButton.textContent = 'Ištrinti';

        figure.append(picture);
        contentArea.append(prodTitle, prodPrice, deleteButton);
        card.append(figure, contentArea);
        shelf.append(card);
    });
    const delBtns = document.querySelectorAll('button');
        delBtns.forEach(delBtn => {
            delBtn.addEventListener('click', e => {
                deleteButton(e);
            });
        });
}



function deleteButton(e) {
    //e.preventDefault();
    //alert(e.target.parentNode.parentNode);
    e.target.parentNode.parentNode.style.display = 'none';
    const id = e.target.id;
    fetch('https://golden-whispering-show.glitch.me/' + id, {
        method: 'DELETE',
    })
    .then(res => res.text()) // or res.json()
    .then(res => console.log(res))
}

function removeProduct() {

}