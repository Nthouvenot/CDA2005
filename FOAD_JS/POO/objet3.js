let obj = {}; //Syntaxe littérale
let obj2 = new Object();
let obj3 = Object(); //Non recomandé

let formateur = {};
console.log(formateur);
formateur.nom = "DEVOLDERE";
console.log(formateur);

formateur = {
    nom: "DEVOLDERE",
    prenom: "Mickaël",

    parler: function (_msg) {
        console.log(_msg);
    },
};
//Ajout d'une fonction dynamiquement
formateur.conduire = function() {
    console.log("Le formateur conduit");
}
console.log(formateur.nom);
console.log(formateur.prenom);
formateur.parler("Bonjour, aujourd'hui, JS");

formateur2 = {
    nom: "CHATELOT",
    prenom: "Franck",

    parler: function (_msg) {
        console.log(_msg);
    },

    conduire: function() {
        console.log("Le formateur conduit");
    },
};