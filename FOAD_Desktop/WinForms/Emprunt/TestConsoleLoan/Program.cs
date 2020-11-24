using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryLoan;

namespace TestConsoleLoan
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Loan loan = new Loan();

            //Test NumberOfMont property
            loan.NumberOfMonth = 120;
            Console.WriteLine("valeur de NumberOfMonth : " + loan.NumberOfMonth); //we exept 120
            loan.NumberOfMonth = 560;
            Console.WriteLine(); Console.WriteLine("valeur de NumberOfMonth : " + loan.NumberOfMonth); //we exept 120


            //Test 
            loan.Amount = 160000;
            Console.WriteLine("Valeur de Amount : " + loan.Amount); //We expect 160000
            loan.Amount += Int32.MaxValue;
            Console.WriteLine("Valeur de Amount : " + loan.Amount); //We expect 160000

            Console.ReadLine(); //pause
        }
    }
}
