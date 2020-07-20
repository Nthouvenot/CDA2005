using System;
using System.Buffers;

namespace ExerciceFraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction(12, 7);
            Fraction f2 = new Fraction(9);
            Fraction f3 = new Fraction(0);

            //test print
            Console.WriteLine("valeur de f1 : " + f1.ToDisplay());
            Console.WriteLine("valeur de f2 : " + f2.ToDisplay());
            Console.WriteLine("valeur de f2 : " + f3.ToDisplay());

            //test oppose and reverse
            Fraction f4 = new Fraction(4, 7);
            f4.Oppose();
            Console.WriteLine("Valeur de f4 aprés methode oppose : " + f4.ToDisplay());
            Fraction f5 = new Fraction(4, 7);
            f5.Reverse();
            Console.WriteLine("valeur de f5 aprés methode reverse : " + f5.ToDisplay());

            //test compare
            Fraction f6 = new Fraction(11, 7);
            Fraction f7 = new Fraction(5, 4);
            bool isSuperior = f6.IsSuperior(f7);
            Console.WriteLine("f6 > f7 : " + isSuperior);
        }
    }
}
