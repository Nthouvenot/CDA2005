using ConsoleAppCreationDUneException.ExceptionOfFraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCreationDUneException
{
    class Program
    {
        static void Main(string[] args)
        {
            #region tester la construction de la Fraction

            // cas normal
            try
            {
                Fraction f2 = new Fraction(1, 2);
                Console.WriteLine("le code fonctionne");
            }
            catch (Exception e)
            {

            }

            // cas denominateur vaut 0
            try
            {
                Fraction f2 = new Fraction(1, 0);
            }
            catch (ZeroDenominatorImpossibleException e)
            {
                Console.WriteLine("le code fonctionne");
            }

            #endregion

            #region tester Evaluer

            //cas normal evaluer
            try
            {
                Fraction f = new Fraction(1, 2);
                f.Evaluer();
                Console.WriteLine("le code fonctionne");
            }
            catch (ImpossibleEvaluationOfFraction e)
            {
            }

            //cas denominateur vaut zero
            try
            {
                Fraction f = new Fraction(1, 2);
                f.Denominator = 0;
                f.Evaluer();
            }
            catch (ImpossibleEvaluationOfFraction e)
            {
                Console.WriteLine("le code fonctionne");
            }

            #endregion

            #region tester Inverser

            //cas normal inverser
            try
            {
                Fraction f = new Fraction(1, 2);
                f.Inverser();
                Console.WriteLine("le code fonctionne");
            }
            catch (ImpossibleDInverserLaFraction e)
            {
            }

            //cas numerateur vaut 0
            try
            {
                Fraction f = new Fraction(1, 2);
                f.Numerator = 0;
                f.Inverser();
            }
            catch (ImpossibleDInverserLaFraction e)
            {
                Console.WriteLine("le code fonctionne");
            }

            #endregion

            Console.ReadLine(); //on fait une pause pour avoir le temps de lire le résultat de l'execution du programme
        }
    }
}
