using System;
using System.Runtime.InteropServices;

namespace ExercicePOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // first stage
            Console.WriteLine("Stage 1 :");
            BankAccount c = new BankAccount();
            BankAccount c1 = new BankAccount(12345, "toto", 1000, -500);
            Console.WriteLine(c.ToString());
            Console.WriteLine(c1.ToString());
            //second stage
            Console.WriteLine("Stage 2 :");
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
            //third stage
            Console.WriteLine("Stage 3");
            BankAccount c2 = new BankAccount(45657, "titi", 2000, -1000);
            c1.Transfert(1300, c2);
            Console.WriteLine(c1.ToString());
            Console.WriteLine(c2.ToString());
        }
    }
}
