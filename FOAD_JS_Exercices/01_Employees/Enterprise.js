const Employee = require('./Employee.js');

/**
 * Gestion d'employés
 */
class Enterprise 
{
    constructor() {
        this.employees = [];
    }

    /**
     * 
     * @param  _filter 
     */
    readAll(_filter) {
        if (typeof _filter != 'string') {
            return false;
        } else {
            let copyEmployees = this.employees;
            if (_filter == "id") {
                copyEmployees.sort(function (a, b) { return a.id < b.id; });
                return copyEmployee;
            } else if (_filter == 'lastName') {
                copyEmployees.sort(function (a, b) { return a.lastName < b.lastName; });
                return copyEmployee;
            } else if (_filter == 'firstName') {
                copyEmployees.sort(function (a, b) { return a.firstName < b.firstName; });
                return copyEmployees;
            } else if (_filter == 'salary') {
                copyEmployees.sort(function (a, b) { return a.salary < b.salary; });
                return copyEmployees
            } else if (_filter == 'hireDate') {
                copyEmployees.sort(function (a, b) { return a.hireDate < b.hireDate; });
                return copyEmployees;
            } else {
                return false;
            }
        }
    }

    /**
     * Créer un employé
     * @param Employee _employee 
     */
    create(_employee) {
        if (_employee instanceof Employee) {
            this.employees.push(_employee);
        } else {
            return false;
        }
        
    }

    /**
     * Retourne l'employé correspondant a l'id
     * @param int _id 
     */
    read(_id) { 
        if (typeof _id == 'number') {
            let i = 0;
            while (_id != this.employees[i].id) {
                i++;
            }
            return this.employees[i];
        } else {
            return false;
        }
    }

    /**
     * Met à jour un employé
     * @param Employee _employee 
     */
    update(_employee) { // on réutilise les méthodes qui sont déja sécurisé donc inutile de vérifier le type de l'entrée 
        if (this.delete(_employee.id)) {
            this.create(_employee);
        } else {
            return false;
        }
    }
    
    /**
     * Supprime un employé
     * @param int _id 
     */
    delete(_id) {
        if (typeof _id == 'number') {
            let i = 0;
            while (_id != this.employees[i].id) {
                i++;
            }
            this.employees.delete(i);
            return true;
        } else {
            return false;
        }
    }


    /**
     * retourne l'employé qui a le salaire le plus élevé
     **/
    getHigherSalary() {
        let i = 0;
        let higherSalary = Math.max(...this.employees.map(emp => emp.salary));
        while (this.employees[i].salary != higherSalary) {
            i++;
        }
        return this.employees[i];
    }

    /**
     * retourne l'employé qui a le salaire le plus bas
     */
    getLowerSalary() {
        let i = 0;
        let lowerSalary = Math.min(...this.employees.map(emp => emp.salary));
        while (this.employees[i].salary != lowerSalary) {
            i++;
        }
        return this.employees[i];
    }

    /**
     * retourne la différence entre le salaire le plus élevé et le plus bas
     */
    getSalaryGap() {
        return (this.getHigherSalary().salary - this.getLowerSalary().salary);
    }

}

module.exports = Enterprise;
