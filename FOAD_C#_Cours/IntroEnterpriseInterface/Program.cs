using IntroEnterprise.Models;
using System;

namespace IntroEnterprise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Enterprise ets = new Enterprise("CRM");
            Client c = new Client("DEV", "mike", 1);
            Employee employee = new Employee("John", "Doe");
            ets.CreateEmployees(employee);
            Console.WriteLine(ets.Employees);

            int i;
            for(i=0; i < ets.Employees.Count; i++)
            {

            }

            foreach(Employee item in ets.Employees)
            {
                Console.WriteLine(item);
            }

            ets.Name = "Doe";
            ets.Name = "hoe";
            ets.Name = "a";
        }

    }
}
