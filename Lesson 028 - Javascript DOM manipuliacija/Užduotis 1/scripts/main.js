/**
 * https://javascript.info/modifying-document
 */


//============ Clear element ===========

function clearElem() { 
    /* your code */
    setTimeout(() => document.getElementById("elem").remove(), 1000);
}

//============== The E-N-D =============

//============ Remove table ===========

function removeTable() {
    //alert(document.getElementById(table)); // the table, as it should be
    setTimeout(() => document.getElementById("table").remove(), 3000);
}

    //removeTable("table");
    //table.remove();
    // why there's still "aaa" in the document?

//============== The E-N-D =============

//============ Create a list ===========

  function getWishListItem() {
    let userListItem = messageToUser();
    if(userListItem !== "" && userListItem !== null) {
        creteWishList();
        while (userListItem !== "" && userListItem !== null) {
            addToWishList(userListItem);
            userListItem = messageToUser();
        }
    }
    else {
        alert("User Quit!");
    }
}

function messageToUser() {
    return prompt("Papildykite sąrašą");
}

function creteWishList() {
    let listPlace = document.getElementById("createList");
    let listCreate = document.createElement("ol");
    listCreate.id = "userList";
    listPlace.after(listCreate);
}

function addToWishList(listItem) {
    let userList = document.getElementById("userList");
    let userItem = document.createElement("li");
    userItem.textContent = listItem;
    userList.append(userItem);
}

//============== The E-N-D =============

//============ Create a Tree ===========

function treeInitialization() {
    let data = {
        "Fish": {
        "trout": {},
        "salmon": {}
        },
        "Tree": {
            "Huge": {
                "sequoia": {},
                "oak": {}
            },
            "Flowering": {
                "apple tree": {},
                "magnolia": {}
            }
        }
    };
    let container = document.getElementById('treeContainer');
    createTree(container, data); // creates the tree in the container
}

function createTree(container, data) {
    let ul = document.createElement("ul");
    for(let key in data) {
        let li = document.createElement("li");
        li.textContent = key;
        ul.append(li);
        if(Object.keys(data[key]).length) {
            createTree(li, data[key]);
        }
        
    }
    container.append(ul);
}
//============== The E-N-D =============

//============ Create a Calendar ===========
function calendarInitialization() {
    let year = parseInt(document.getElementsByName("year")[0].value);
    let month = parseInt(document.getElementsByName("month")[0].value);
    let cal = document.getElementById("calendar");
    createCalendar(cal, year, month);
}

function createCalendar(cal, year, month) {
    let weekDays = ["Mo", "Tu",	"We", "Th", "Fr", "Sa", "Su"];
    let table = document.createElement("table");
    let headerRow = document.createElement("tr");
	let day = 0;
    let daysInMonth = new Date(year, month, 0).getDate();
    let monthStartDay = new Date(year, month - 1, 0).getDay() + 0;
    
    for(let row = 0; row < 7; row++) {
		if(row == 0) {
			for(let i = 0; i < weekDays.length; i++) {
				let th = document.createElement("th");
				th.textContent = weekDays[i];
				headerRow.append(th);
			}
			table.append(headerRow);
		}
		else {
			let dataRow = document.createElement("tr");
			for(let n = 0; n < 7; n++) {
				let td = document.createElement("td");
				if(day < daysInMonth && (monthStartDay <= n || row > 1)) {
					td.textContent = day + 1;
					day++;
				}
				else {
					td.textContent = "";
				}
				dataRow.append(td);
			}
			table.append(dataRow);
		}
    }
    cal.append(table);
}


//============== The E-N-D =============


//============ Colored clock with setInterval ===========

setInterval(clock, 1000);

function clock() {
    let hours = document.getElementById("hours");
    let minutes = document.getElementById("minutes");
    let seconds = document.getElementById("seconds");
    let time = new Date();
    hours.textContent = time.getHours();
    minutes.textContent = time.getMinutes();
    seconds.textContent = time.getSeconds();
}

