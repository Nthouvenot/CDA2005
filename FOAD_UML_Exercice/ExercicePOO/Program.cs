using System;

namespace ExercicePOO
{
    class Program
    {
        static void Main(string[] args)
        {
           // first stage
            BankAccount c = new BankAccount();
            BankAccount c1 = new BankAccount(12345, "toto", 1000, -500);
            Console.WriteLine(c.ToString());
            Console.WriteLine(c1.ToString());
            //second stage
            BankAccount b = new BankAccount(545454, "laurent", 2000, 500);
            b.Credit(100);
            Console.WriteLine(b);
            bool ok = b.Debit(100000);
            Console.WriteLine(b.ToString());
            if(ok)
            {
                Console.WriteLine("Débit réussi !");
            }
            else
            {
                Console.WriteLine("Débit pas réussi !");
            }
        }
    }
}
