let promise = new Promise((resolve) => {
    let randomNumber = Math.random();
    setTimeout(() => {
        if(randomNumber < 0.8) {
            resolve();
        }
        else {
            reject();
        }
    }, 5000)
});

promise.then(() => alert("yes, veikia!")).catch(() => alert("Erroras"));