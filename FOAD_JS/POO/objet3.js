let obj = {}; //Syntaxe litt�rale
let obj2 = new Object();
let obj3 = Object(); //Non recomand�

let formateur = {};
console.log(formateur);
formateur.nom = "DEVOLDERE";
console.log(formateur);

formateur = {
    nom: "DEVOLDERE",
    prenom: "Micka�l",

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