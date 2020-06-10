const fs = require('fs');
const Employee = require('./Employee.js');

/**
 * Gestion d'employés
 */
class Enterprise {

    #employees

    constructor() {
        this.#employees = new Array();
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

}

module.exports = Enterprise;
