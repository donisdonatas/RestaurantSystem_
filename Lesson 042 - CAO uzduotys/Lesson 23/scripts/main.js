/**
 * https://codeacademy.online/dashboard/modules/js1/1Je1ZU6V8QLBTicu7XXD/YMcmzxQAACUAdsuW
 */

    const connection = fetch("https://olive-bead-glazer.glitch.me")
      .then((response) => response.json())
      .then((data) => {return data;})
      .catch(error => console.error(error));
  
    const getData = async () => {
      const receivedData = await connection;
      console.log(receivedData);
      createTable(receivedData);
    };
  
    getData();

const createTable = (data) => {
    const table = document.createElement('table');
    const tr = document.createElement('tr');
    const rowTopics = ['Brand', 'Model'];
    for(let rowTopic of rowTopics) {
        tr.append(createElement('td', rowTopic));
    }
    table.append(tr);
    data.forEach(car => {
        const tr = document.createElement('tr');
        const brand = createElement('td', car.brand);
        const model = createElement('td', car.model);
        tr.append(brand, model);
        table.append(tr);
    });
    document.querySelector('body').append(table);
    //readLocalStorage();
}

function createElement(element, text) {
    let el = document.createElement(element);
    el.textContent = text;
    return el;
}


function readLocalStorage() {
    for (let i = 0; i < localStorage.length; i++) {
        let storage = localStorage.getItem(localStorage.key(i));
        let car = storage.split(',');
        let newCar = new Car(car[0], car[1]);
        addNewCarToTable(newCar);
    }
}

function addNewCarToTable(car) {
    const table = document.getElementsByTagName('table');
    const tr = document.createElement('tr');
    const brand = createElement('td', car.brand);
    const model = createElement('td', car.model);
    tr.append(brand, model);
    table[0].append(tr);
}

