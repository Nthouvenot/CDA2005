//Appel d'une fonction sans paramétre qui retourne rien
function hello() {
    console.log("Hello Wolrd !");
}

hello();
hello();

//Retour d'une variable
function welcome() {
    return "Welcome";
}

var w = welcome();
console.log(w);
console.log(welcome());

//fonction avec paramétre sans retour de variable
function talk(_message) {
    console.log(_message);
}

talk("Bonjour !");
talk("Bonjour 2 !");

//Fonction littérale
const hi = function {
    console.log("hi !");
}

hi();
hi();

//Fonction fonctionnelle
const bye = () => {
    console.log("bye !");
}

bye();
bye();
