const path = require('path');
const fs = require('fs');
const Employee = require('./Employee.js');

/**
 * Gestion d'employés
 */
class Enterprise {

    #employees
    #filename;

    /**
     * @param {string} _name nom du fichier de sauvegarde de l'entreprise
     */
    constructor(_name) {
        if (typeof _name != 'string') {
            _name = "CRM";
            this.filename;
        }
        this.#employees = new Array();
        this.#filename = path.resolve(__dirname, "./savedData/" + _name + ".json");
        if (fs.existsSync(this.#filename)) {
            let rawFile = fs.readFileSync(this.#filename);
            let jsonFile = JSON.parse(rawFile); //Converti les donnée JSON en objet litéral JavaScript
            for (let i = 0; i < jsonFile.length; i++) { //On copie les objet litéraux dans des instances d'Employee et on les ajoute a la collection
                let employee = new Employee(jsonFile[i]);
                this.#employees.create(employee);
            } 
        } else {
            fs.writeFileSync(this.#filename, "[]");
            console.log("le fichier " + _name + "n'existe pas : création d'un fichier vide");
        }
    }
    

   /**
    * @returns {Array} copie de la collection d'employee => respet de l'encapsulation
    * */
    getEnterprise() {
        let copyEnterprise = new Array();
        for (let i = 0; i < this.#employees.length; i++) {
            copyEnterprise.push(new Employee());
        }
        for (let i = 0; i < this.#employees.length; i++) {
            Object.assign(copyEnterprise[i], this.#employees[i]);
        }
        return copyEnterprise;
    }

    /**
     * Permet de valider _employee
     * @param {Employee} _employee
     */
    isValid(_employee) {
        if (!(_employee instanceof Employee)) {
            _employee = new Employee();
        }
        if (typeof _employee.id != 'number' || _employee.id == undefined) {
            _employee.id = 0;
        }
        if (typeof _employee.lastname != 'string' || _employee.lastname == undefined) {
            _employee.lastname = "Doe";
        }
        if (typeof _employee.firstname != 'string' || _employee.firstname == undefined) {
            _employee.lastname = "John";
        }
        if (typeof _employee.role != 'string' || _employee.role == undefined) {
            _employee.role = "???";
        }
        if (typeof _employee.salary != 'number' || _employee.salary == undefined) {
            _employee.salary = "14000";
        }
        if (_employee.hiredate instanceof Date || _employee.hiredate == undefined) {
            _employee.hiredate = new Date(Date.now());
        }
        _employee.email = (_employee.firstname[0].toLowerCase() + _employee.lastname).toLowerCase() + "@email.fr";
        return 0;
    }

    /**
     * Retourne la collection d'Employee trié en fonction d'un filtre
     * @param  _filter 
     * @returns {Employee}
     */
    readAll(_filter) {
        if (typeof _filter != 'string') {
            return undefined;
        }
        switch (_filter) {
            case "id":
                return this.#employees.sort((a, b) => a.id - b.id);
                break;
            case "lastname":
                return this.#employees.sort((a, b) => a.lastname - b.lastname);
                break;
            case "firstname":
                return this.#employees.sort((a, b) => a.firstname - b.firstname);
                break;
            case "salary":
                return this.#employees.sort((a, b) => a.salary - b.salary);
                break;
            case "hiredate":
                return this.#employees.sort((a, b) => a.hiredate - b.hiredate);
                break;
            default:
                return undefined;
        }
    }

    /**
     * Créer un employé
     * @param Employee _employee
     * @returns {Employee}
     */
    create(_employee) {
        if (!(_employee instanceof Employee)) {
            return false;
        }
        this.#employees.push(_employee);
        return this.getEnterprise()
    }

    /**
     * Retourne l'employé correspondant a l'id
     * @param int _id
     * @returns {Employee}
     */
    read(_id) {
        if (typeof _id != 'number') {
            return undefined;
        }
        let employee = this.#employees.find(employee => employee.id == _id);
        if (employee != undefined) {
            return Object.assign(new Employee(), employee);
        } else {
            return undefined;
        }
    }

    /**
     * Met à jour un employé
     * @param Employee _employee
     * @returns {Employee}
     */
    update(_employee) {
        this.isValid(_employee);
        let employeeToUpdate = this.read(_employee.id);
        if (employeeToUpdate == undefined) {
            return undefined;
        }
        return this.getEnterprise()

    }

    /**
     * Supprime un employé
     * @param int _id
     * @returns {boolean}
     */
    delete(_id) {
        if (typeof _id != 'number') {
            return false;
        }
        let index = this.#employees.indexOf('id', _id);
        if (index == undefined) {
            return false;
        }
        this.#employees.splice(index, 1);
        return true;
    }


    /**
     * retourne l'employé qui a le salaire le plus élevé
     * @returns {Employee}
     **/
    getHigherSalary() {
        let higherSalary = Math.max(...this.#employees.map(emp => emp.salary));
        let employeeBySalary = this.#employees.find(employee => employee.salary == higherSalary);
        return Object.assign(new Employee(), employeeBySalary);
    }

    /**
     * retourne l'employé qui a le salaire le plus bas
     * @returns {Employee}
     */
    getLowerSalary() {
        let lowerSalary = Math.min(...this.#employees.map(emp => emp.salary));
        let employeeBySalary = this.#employees.find(employee => employee.salary == lowerSalary);
        return Object.assign(new Employee(), employeeBySalary);
    }

    /**
     * retourne la différence entre le salaire le plus élevé et le plus bas
     * @returns {number}
     */
    getSalaryGap() {
        return (this.getHigherSalary().salary - this.getLowerSalary().salary);
    }

    /**
     * sauvegarde la collection d'employee au format JSON
     * */
    save() {
        let jsonFile = JSON.stringify(this.#employees); // conversion de la collection d'employes vers le format JSON
        fs.writeFileSync(this.#filename, jsonFile); // ecriture des donnees JSON dans une sauvegarde
    }

}

module.exports = Enterprise;
