const renderUserCard = (user) => {
    const img = document.createElement('img');
    img.src = user.picture.large;
    img.alt = `${user.name.first} profile picture`;
  
    const intro = document.createElement('h4');
    intro.innerText = `${user.name.first} ${user.name.last}, ${user.dob.age}`;
  
    const contacts = document.createElement('h5');
    contacts.innerText = user.email;
  
    const card = document.createElement('div');
    card.append(img, intro, contacts);
    document.body.append(card);
  };
  
  const fetchRandomUser = async () => {
    try {
      const response = await fetch('https://randomuser.me/api/');
      if (response.ok) {
        const data = await response.json();
        renderUserCard(data.results[0]);
      }
    } catch(error) {
      console.error(error);
    }
  };
  
function getRandomUser() {
    fetchRandomUser();
}
 


  /**
   * Peradryti pagal pavyzdį su callback ir async/await:
   * https://dev.to/ramonak/javascript-how-to-access-the-return-value-of-a-promise-object-1bck
   */

function getRandomUser2() {
  const address = fetch("https://randomuser.me/api/")
    .then((response) => response.json())
    .then((user) => {
      return user.address;
    });

  const printAddress = () => {
    address.then((a) => {
      console.log(a);
    });
  };

  printAddress();
}

/**
 * Uždavinys Nr. 1
 */

function getRandomUser3() {
  const connection = fetch("https://randomuser.me/api/")
    .then((response) => response.json())
    .then((user) => {
      return user.results[0];
    });

  const getUserData = async () => {
    const userData = await connection;
    createUserCard(userData);
  };

  getUserData();  
}

function createUserCard(userData) {
  console.log(userData);
  const img = document.createElement('img');
  img.src = userData.picture.large;
  img.alt = `${userData.name.first} ${userData.name.last} profile picture`;

  const fullName = document.createElement('h4');
  fullName.textContent = `${userData.name.first} ${userData.name.last}`;

  const age = document.createElement('span');
  age.textContent = ` ${userData.dob.age} years old.`;
  fullName.append(age);

  const email = document.createElement('h5');
  email.textContent = userData.email;

  let cardClass = document.createElement('div');
  cardClass.className = 'card';
  cardClass.append(img, fullName, email);
  let card = document.getElementById('card');
  card.append(cardClass);

  cardClass.style.marginTop = '20px';
  cardClass.style.width = '300px';
  cardClass.style.background = '#B3D6D4';
  cardClass.style.textAlign = 'center';
  img.style.width = '280px';
  img.style.paddingTop = '10px';
  fullName.style.color = 'fff';
  email.style.color = 'eee';
  email.style.paddingBottom = '10px';
}



/**
 * Uždavinys Nr. 2
 */

 function getRandomData() {
  const connection = fetch("https://boiling-reaches-93648.herokuapp.com/week-3/party")
    .then((response) => response.json())
    .then((data) => {
      return data;
    });

  const getData = async () => {
    const receivedData = await connection;
    transformData(receivedData);
  };

  getData();  
}

function transformData(data) {
  const person = 'Kristupas Lapeika';
  let status = '';
  for(let value of data) {
    if(value.name == person) {
      status += `${person} status is VIP (${value.vip})`;
    }
  }
  
  document.getElementById('lapeikaStatus').textContent = status;
}

/**
 * Uždavinys Nr. 3
 */

 function getListOfParticipants() {
  const connection = fetch("https://boiling-reaches-93648.herokuapp.com/week-3/wedding")
    .then((response) => response.json())
    .then((data) => {
      return data;
    });

  const getData = async () => {
    const receivedData = await connection;
    console.log(receivedData);
    readData(receivedData);
  };

  getData();  
}

function readData(data) {
  let table = document.createElement('table');
  let th = document.createElement('th');
  let th1 = createElement('td', 'Vardas Pavardė');
  let th2 = createElement('td', 'plusOne');
  let th3 = createElement('td', 'Dalyvavimas');
  th.append(th1, th2, th3);
  table.append(th);
  for(let value of data) {
    let tr = document.createElement('tr');
    let td1 = createElement('td', value.name);
    let td2 = createElement('td', value.plusOne);
    let td3 = createElement('td', value.attending);
    tr.append(td1, td2, td3);
    table.append(tr);
  }
  document.getElementById('weddingList').append(table);
  createButton();
}

function createElement(element, text) {
  let el = document.createElement(element);
  el.textContent = text;
  return el;
}

function createButton() {
  let button = document.createElement('button');
  button.type = 'button';
  button.onclick = function() {formatTable();};
  button.textContent = 'Suformatuoti lentelę';
  document.getElementById('wedding').after(button);
}

function formatTable() {
  //alert('formatTable');
  let table = document.getElementsByTagName('table');
  let td = document.getElementsByTagName('td');
  for(let cell of td) {
    cell.style.border = '1px solid black';
    //console.log(cell.textContent);
  }
  table[0].style.borderCollapse = 'collapse';

}