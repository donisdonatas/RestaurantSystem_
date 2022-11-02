export function raceCondition() {
    let xhr = new XMLHttpRequest();
    let statuses = [];
    xhr.open("GET", "http://localhost:3000/orderStatuses");
    xhr.onload = () => {
        statuses = JSON.parse(xhr.responseText);
    };

    xhr.send();

    let xhr2 = new XMLHttpRequest();
    xhr2.open("GET", "http://localhost:3000/orders/1");
    xhr2.onload = () => {
        const order = JSON.parse(xhr2.responseText);
        const description = statuses.map(t=>{
            if(t.id === order.orderStatusId) {
                return t.description;
            }
        })[0];

        setText(`Order Status: ${description}`)
    };

    xhr2.send();
}


//Callback Pyramid of Doom
export function callbacks(){
    let xhr = new XMLHttpRequest();
    let statuses = [];
    xhr.open("GET", "http://localhost:3000/orderStatuses");

    xhr.onload = () => {
        statuses = JSON.parse(xhr.responseText);

        let xhr2 = new XMLHttpRequest();
        xhr2.open("GET", "http://localhost:3000/orders/1");

        xhr2.onload = () => {
            const order = JSON.parse(xhr2.responseText);

            const description = statuses.map(t=> {
                if(t.id === order.orderStatusId) {
                    return t.description;
                }
            })[0];

            setText(`Order Status:  ${description}`);
        };
        xhr2.send();
    }
}


//Callback pyramid of doom 

a("test", (err, aResult) => {
    b(aResult, (err, bResult) =>{
        c(bResult, (err, cResult) => {
            d(cResult);
        });
    });
});