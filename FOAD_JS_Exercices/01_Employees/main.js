const Employee = require('./Employee.js');
const Enterprise = require('./Enterprise.js');

//Création de l'entreprise
let myEnterprise = new Enterprise();

//Création des employees
let employee1 = new Employee(1, 'Devoldere', 'Mickael', 'manager', 82000, new Date('2015-01-28'));
let employee2 = new Employee(2, 'Boudier', 'Aurélien', 'Project chief', 41000, new Date('2017-09-16'));
let employee3 = new Employee(3, 'Shmitt', 'Joanna', 'Déveloper designer', 30000, new Date('2016-05-14'));
let employee4 = new Employee(4, 'Hamza', 'Reda', 'Déveloper', 26000, new Date('2015-01-28'));
let employee5 = new Employee(5, 'Brown', 'Tim', 'Déveloper', 26000, new Date('2018-01-25'));

//Ajout des employees dans l'entreprise
myEnterprise.create(employee1);
myEnterprise.create(employee2);
myEnterprise.create(employee3);
myEnterprise.create(employee4);
myEnterprise.create(employee5);

//salaire minimum, maximum  et différence entre le haut et le plus bas salaire des employees
let lowerSalary = myEnterprise.getLowerSalary();
let highterSalary = myEnterprise.getHigherSalary();
let differencySalary = myEnterprise.getSalaryGap();

//Affichage des employees avec la méthode read(_id)
console.log("Affichage de la liste des Employées avec la méthode read(_id)")
console.log(myEnterprise.read(1));
console.log(myEnterprise.read(2));
console.log(myEnterprise.read(3));
console.log(myEnterprise.read(4));
console.log(myEnterprise.read(5));

//Affichage des résultats
console.log('le plus bas salaire est : ' + lowerSalary.firstname + " " + lowerSalary.lastname);
console.log('le plus haut salaire est : ' + highterSalary.firstname + " " + highterSalary.lastname);
console.log('Différence entre le plus haut et le plus bas salaire : ' + differencySalary + " euros");
