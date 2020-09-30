/**
 * @class Employee
 */

class Employee 
{

    /**
     * Constructeur@param {any} _id
     * @param {any} _lastname
     * @param {any} _firstname
     * @param {any} _role
     * @param {any} _salary
     * @param {any} _hiredate
     * 
     */
    constructor(_id, _lastname, _firstname, _role, _salary, _hiredate) {

        this.id = parseInt(_id); // NaN
        this.lastname = _lastname || "Ano";
        this.firstname = _firstname || "Nymous";
        this.role = _role || "Boulanger";
        this.salary = parseInt(_salary);
        this.hiredate = _hiredate;
        this.email = (this.firstname[0] + this.lastname).toLowerCase() + "@email.fr";
    }

    /**
     * Récupère le salaire mensuel de l'employé
     */
    getMonthlySalary() {
        //(salaire_mensuel = salaire_annuel / 12*0.75)
        return Math.round(this.salary/12*0.75);
    }

    getSeniority() {
        let now = new Date(); 
        let y = now.getFullYear() - this.hiredate.getFullYear(); // années
        let m = now.getMonth() - this.hiredate.getMonth(); // mois
        let d = now.getDate() - this.hiredate.getDate(); // jours
        let result = "";

        if(m < 0) {
            y--;
            m += 12;
        }

        if(d < 0) {
            m--;
            d = Math.floor(d + (365.25/12));
        }

        if(y > 0) {
            result += y + " année(s) ";
        }

        if(m > 0) {
            result += m + " mois ";
        }

        if(d > 0) {
            result += d + " jour(s) ";
        }

        return result;

    }
}



module.exports = Employee;
