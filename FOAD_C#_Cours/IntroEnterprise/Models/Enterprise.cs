using System;
using System.Collections.Generic;
using System.Text;

namespace IntroEnterprise.Models
{
    class Enterprise
    {
        private string name;
        private List<Person>employees;

        /// <summary>
        /// contructor with the name attribute in parameter
        /// </summary>
        /// <param name="_name"></param>
        public Enterprise(string _name)
        {
            this.name = _name;
            employees = new List<Person>();
            //employees[0] = new Client("", "", 1);
        }

        /// <summary>
        /// create the List<Person>employee propertie
        /// </summary>
        internal List<Person> Employees { get => employees; }

        /// <summary>
        /// add a new employee at the collection
        /// </summary>
        /// <param name="_employee"></param>
        public void CreateEmployees(Employee _employee)
        {
            this.employees.Add(_employee);

        }
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 9a39fcc... Update Enterprise.cs and Person.cs

        /// <summary>
        /// calculate the bonus of the employee
        /// </summary>
        /// <param name="_employee"></param>
        /// <returns>int</returns>
        public int CalculateBonus(Employee _employee)
        {
            Employee p = (Employee)_employee;
            return 0;
        }

<<<<<<< HEAD
    }

=======
    }
>>>>>>> e99e87d... Create FOAD_C#_Cours/IntroEnterprise
=======
    }

>>>>>>> 9a39fcc... Update Enterprise.cs and Person.cs
}
