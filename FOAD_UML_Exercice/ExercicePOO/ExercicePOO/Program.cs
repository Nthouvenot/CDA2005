using System;

namespace ExercicePOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            BankAccount c = new BankAccount();
            BankAccount c1 = new BankAccount(12345, "toto", 1000, -500);
            Console.WriteLine(c.Print());
            Console.WriteLine(c1.Print());
        }
    }
}
