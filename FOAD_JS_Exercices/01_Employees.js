/**
 * JAVASCRIPT:  Exercices
 * 
 * Listing d'employés
 * 
 * Consignes : 
 * A l'aide de la syntaxe orientée "classes", modélisez un objet "Employee" possédant les caractéristiques suivantes :
 *  Attributs: 
 *  - id (int): identifiant
 *  - lastname (string): nom
 *  - firstname (string): prénom
 *  - email (string): calculé automatiquement dans le constructeur (exemple: John Doe => jdoe@email.fr)
 *  - role (string): poste occupé
 *  - salary (int): salaire annuel BRUT
 *  - hiredate (Date): date d'embauche au format YYYY-MM-DD
 * 
 *  Méthodes:
 *  - getMonthlySalary() : retourne un entier -> le salaire mensuel NET calculé à partir du salaire annuel (salaire_mensuel = salaire_annuel / 12 * 0.75)
 *  - getSeniority() : renvoie une chaine -> l'ancienneté de l'employé (exemples: "19 jours", "3 mois et 2 jours", "2 ans 7 mois et 8 jours") 
 * 
 * Une fois modélisé et testé, complétez le tableau "employees" pour qu'il contienne 5 employés au total (ni plus, ni moins).
 * Parcourir ensuite le tableau complété et afficher chaque employé dans la console (nom, prénom, email, ancienneté, salaire mensuel NET)
 * Afficher ensuite, individuellement : 
 *  - L'employé ayant le plus d'ancienneté
 *  - L'employé avec le plus haut salaire
 *  - L'employé avec le plus bas salaire
 *  - La différence de salaire entre les 2 précédents 
 * 
 * Documentation Javascript complète: https://developer.mozilla.org/fr/docs/Web/JavaScript
 * Tutoriel Javascript: https://www.pierre-giraud.com/javascript-apprendre-coder-cours/introduction/ 
 */



/* COMPLÉTEZ LE PROGRAMME... */

/**
 * @class Employee
 */
class Employee
{
    // A vous de jouer...
    constructor(id, lastName, firstName, role, salary, hireDate) {
        this.id = id;
        this.lastName = new String(lastName);
        this.firstName = new String(firstName); 
        this.email = this.firstName.charAt(0).toLowerCase() + this.lastName.toLowerCase() + "@email.fr";
        this.role = new String(role);
        this.salary = salary;
        this.hireDate = new Date(hireDate);
    }

    getMonthlySalary() {
        return (this.salary / 12) * 0.75;
    }

    getSeniority() {
        const options = { year: 'numeric', month: 'long', day: 'numeric' };
        return this.hireDate.toLocaleDateString('fr-FR', options);
    }

}

/** DÉBUT ZONE NON EDITABLE (Ne pas modifier les lignes suivantes) */


/** @var Employee employee1 */
var employee1 = new Employee(1, 'Doe', 'John', 'manager', 82000, new Date('2020-12-28')); // création d'un nouvel employé

/** @var array employees */
const employees = [employee1]; // tableau contenant les employés

console.log(employee1); // doit afficher l'objet "employee1"
console.log("Il y a " + employees.length + " employé(e)s."); // doit afficher "Il y a 5 employé(e)s."
console.log(employees); // export des employés dans la console


/** FIN ZONE NON EDITABLE (Ne pas modifier les lignes précédentes) */



// Écrivez votre code à partir de la ligne suivante...

//Test des méthodes créer et de la génération de l'e-mail
console.log("******Test de la classEmployee******");
console.log();

console.log("L'employée " + employee1.firstName + " " + employee1.lastName + " est arrivé le " + employee1.getSeniority());
console.log("L'employée " + employee1.firstName + " " + employee1.lastName + " touche " + String(employee1.getMonthlySalary()) + " euros par mois");
console.log("L'email de l'employé est : " + employee1.email);

//Création de 5 employé
let tableauEmployee = new Array(5);

tableauEmployee[0] = new Employee(1, 'Devoldere', 'Mickael', 'manager', 82000, new Date('2020-12-28'));
tableauEmployee[1] = new Employee(2, 'Boudier', 'Aurélien', 'Project chief', 41000, new Date('2020-12-28'));
tableauEmployee[2] = new Employee(3, 'Shmitt', 'Joanna', 'Déveloper designer', 30000, new Date('2020-12-28'));
tableauEmployee[3] = new Employee(4, 'Hamza', 'Reda', 'Déveloper', 26000, new Date('2020-12-28'));
tableauEmployee[4] = new Employee(5, 'Brown', 'Tim', 'Déveloper', 26000, new Date('2020-12-28'));

//Afichage des employés
console.log();
console.log("********Afichage des employées********");
console.log();

for (let i = 0; i < tableauEmployee.length; i++) {
    console.log("Employé " + i + ":")
    console.log("Nom : " + tableauEmployee[i].firstName);
}