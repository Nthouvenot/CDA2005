class formateur {
    //Définition d'un constructeur
    constructor(_nom, _prenom) {
        this.nom = _nom
        this.prenom = _prenom;
    }
    //Définition d'une méthode
    parler(_msg) {
        console.log("Le formateur " + this.nom + "dit " + _msg);
    }
};


let formateur1 = new formateur("DEVOLDERE", "Mike"); //Instancie un formateur
let formateur2 = new formateur("CHATELOT", "Franck");
let formateur3 = new formateur();
formateur2.prenom = "Franck"; //On modifie l'attribut prenom de formateur 2

console.log(formateur1);
console.log(formateur2);
console.log(formateur3);

formateur1.parler("Bonjour"); //appel de la méthode parler de l'objet formateur1
formateur2.parler("Bonjour");
formateur3.parler("Bonjour");

//Créer une collection d'objet de type formateur
formateurs.push(formateur1);
formateurs.push(formateur2);
formateurs.push(formateur3);
console.log(formateurs); //On afiche la collection de formateur