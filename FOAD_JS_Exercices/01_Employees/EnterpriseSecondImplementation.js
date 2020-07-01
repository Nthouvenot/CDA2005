
const Employee = require('./Employee.js');

/**
 * Gestion d'employés
 */
class Enterprise {
    constructor() {
        this.employees = [];
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
                return this.employees.sort((a, b) => a.id - b.id);
                break;
            case "lastname":
                return this.employees.sort((a, b) => a.lastname - b.lastname);
                break;
            case "firstname":
                return this.employees.sort((a, b) => a.firstname - b.firstname);
                break;
            case "salary":
                return this.employees.sort((a, b) => a.salary - b.salary);
                break;
            case "hiredate":
                return this.employees.sort((a, b) => a.hiredate - b.hiredate);
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
        this.employees.push(_employee);
        return _employee;
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
        let employee = this.employees.find(employee => employee.id == _id);
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
    update(_employee) { // on réutilise les méthodes qui sont déja sécurisé donc inutile de vérifier le type de l'entrée 
        if (this.delete(_employee.id)) {
            return this.create(_employee);
        } else {
            return undefined;
        }

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
        let index = this.employees.indexOf('id', _id);
        if (index == undefined) {
            return false;
        }
        this.employees.splice(index, 1);
        return true;
    }


    /**
     * retourne l'employé qui a le salaire le plus élevé
     * @returns {Employee}
     **/
    getHigherSalary() {
        let higherSalary = Math.max(...this.employees.map(emp => emp.salary));
        let employeeBySalary = this.employees.find(employee => employee.salary == higherSalary);
        return Object.assign(employeeBySalary);
    }

    /**
     * retourne l'employé qui a le salaire le plus bas
     * @returns {Employee}
     */
    getLowerSalary() {
        let lowerSalary = Math.min(...this.employees.map(emp => emp.salary));
        let employeeBySalary = this.employees.find(employee => employee.salary == lowerSalary);
        return Object.assign(employeeBySalary);
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
