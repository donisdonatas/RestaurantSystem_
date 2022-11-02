if(checkNameInCookies()) {
	let writeForm = document.getElementById("writeCookies");
	let deleteForm = document.getElementById("deleteCookies");
	writeForm.style.display = false;
	deleteForm.style.display = true;
	document.getElementById("nameInCookies").textContent = checkNameInCookies();
}


function writeToCookies() {
	checkNameInCookies();
	document.cookie = "name=Donatas";
}

function checkNameInCookies() {
	let cookies = document.cookie;
	if(cookies.length > 0) {
		cookie = cookies.split("=");
		let nameInCookie = cookie[1];
		console.log(nameInCookie);
		return nameInCookie;
	}
	return null;
}

function deleteCookies() {
	const d = new Date();
	d.setTime(d.getTime() + (1 * 24 * 60 * 60 * 1000));
	let expires = "expires=" + d.toUTCString();
	document.cookie = "name=Donatas" + ";" + expires + ";";
	//document.cookie = "name=; expires=Thu, 01 Jan 1970 00:00:00 UTC; path=/;";
}

