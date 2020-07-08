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
        }
    }
}
