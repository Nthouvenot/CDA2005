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
        
    }

    /**
     * Créer un employé
     * @param Employee _employee 
     */
    create(_employee) {
        if (typeof _employee == 'Employee') {
            this.employees.push(new Employee(_employee));
            return true;
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
        let salaryHeight = 0;
        let position = 0;
        for (let i = 0; i > this.employees.length; i++) {
            if (tableauEmployee[i].getMonthlySalary() < salaryHeight) {
                salaryHeight = this.employee[i].getMonthlySalary();
                position = i;
            }
        }
        return this.employees[position];
    }

    /**
     * retourne l'employé qui a le salaire le plus bas
     */
    getLowerSalary() {
        let salaryMin = 0;
        let position = 0;
        for (let i = 0; i < this.employees.length; i++) {
            if (this.employees[i].getMonthlySalary() < salaryMin) {
                salaryMin = this.employees[i].getMonthlySalary();
                position = i;
            }
        }
        return this.employees[position];
    }

    /**
     * retourne la différence entre le salire le plus élevé et le plus bas
     */
    getSalaryGap() {
        return this.getLowerSalary().salary - this.getHigherSalary().salary;
    }

}

module.exports = Enterprise;