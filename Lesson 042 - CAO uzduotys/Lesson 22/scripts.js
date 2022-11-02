/**
 * https://codeacademy.online/dashboard/modules/js1/l3FncshkRWtUHw8UE1wH/YMHuvRQAACYAX9gM
 */



function initiateTableData() {
    const connection = fetch("https://magnetic-melon-yam.glitch.me")
      .then((response) => response.json())
      .then((data) => {return data;})
      .catch(error => console.error(error));
  
    const getData = async () => {
      const carList = await connection;
      console.log(carList);
      createTable(carList);
    };
  
    getData();
}

function createTable(data) {
    let table = document.createElement('table');
    let th = document.createElement('tr');
    let tableHeadings = ['ID', 'Picture', 'Name', 'Lastname', 'City', 'Fav color'];
    for(let heading of tableHeadings) {
        th.append(createElement('td', heading));
    }
    table.append(th);
    data.forEach(cell => {
        let tr = document.createElement('tr');
        const id = createElement('td', cell.id);
        const image = document.createElement('img');
        image.setAttribute('src', cell.image);
        image.setAttribute('alt', `Profile picture of ${cell.name}`);
        let fullName = cell.name.split(' ');
        const firstName = createElement('td', fullName[0]);
        const lastName = createElement('td', fullName[1]);
        const city = createElement('td', cell.city);
        const color = createElement('td', cell.fav_color);
        tr.append(id, image, firstName, lastName, city, color);
        table.append(tr);
    })
    document.getElementById('results').append(table);
}

function createElement(element, text) {
    let el = document.createElement(element);
    el.textContent = text;
    return el;
}

const createCheckbox2 = () => {
    const checkbox = document.createElement('input');
    checkbox.setAttribute('type', 'checkbox');
    checkbox.setAttribute('id', 'vip');
    const cbLabel = document.createElement('label');
    cbLabel.setAttribute('for', 'vip');
    cbLabel.innerText = 'VIP';
    const cbDiv = document.createElement('div');
    cbDiv.append(checkbox, cbLabel);
    //document.getElementById('results').after(cbDiv);
}

createCheckbox2();

const createCheckbox = () => {
    const checkbox = document.createElement('INPUT');
    checkbox.setAttribute('type', 'checkbox');
    checkbox.setAttribute('id', 'isVipCheckbox');
    document.body.append(checkbox);
  
    const checkboxLabel = document.createElement('label');
    checkboxLabel.setAttribute('for', 'isVipCheckbox');
    checkboxLabel.innerText = 'VIP';
    document.body.append(checkboxLabel);
}

createCheckbox();