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
            ets.PropertyChanged += MyEvent;
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

        static void MyEvent(object Sender, EventArgs e)
        {
            Enterprise ets = Sender as Enterprise;
            if(ets == null)
            {
                return;
            }
            Console.WriteLine("Le nom de l'entreprise a changé " + ets.Name);
        }
    }
}
