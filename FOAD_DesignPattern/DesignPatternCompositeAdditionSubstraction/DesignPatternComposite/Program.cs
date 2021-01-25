using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompositeLibrary;

namespace DesignPatternComposite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Addition :");
            NumberExpression numberOne = new NumberExpression(5);
            NumberExpression numberTwo = new NumberExpression(2);

            Console.WriteLine("5+2 = ");
            Addition addition = new Addition(numberOne, numberTwo);
            Console.WriteLine(addition.Evaluate());
            Console.WriteLine(addition.Format());
            Console.ReadLine();

            Console.WriteLine("8+2+5");
            Addition addition1 = new Addition(new NumberExpression(8), new Addition(numberTwo, numberOne));
            Console.WriteLine(addition1.Evaluate());
            Console.WriteLine(addition1.Format());
            Console.ReadLine();

            Console.WriteLine("8+9+4");
            Addition addition2 = new Addition(new NumberExpression(8), new Addition(new NumberExpression(9), new NumberExpression(4)));
            Console.WriteLine(addition2.Evaluate());
            Console.WriteLine(addition2.Format());
            Console.ReadLine();

            Console.WriteLine("Soustraction");
            Console.WriteLine("5-2= ");
            Substraction substraction = new Substraction(numberOne, numberTwo);
            Console.WriteLine(substraction.Evaluate());
            Console.WriteLine(substraction.Format());
            Console.ReadLine();

            Console.WriteLine("8-2-5");
            Substraction substraction1 = new Substraction(new Substraction(new NumberExpression(8), numberTwo), numberOne); 
            Console.WriteLine(substraction1.Evaluate());
            Console.WriteLine(substraction1.Format());
            Console.ReadLine();

            Console.WriteLine("8-9-4");
            Substraction substraction2 = new Substraction(new Substraction(new NumberExpression(8), new NumberExpression(9)), new NumberExpression(4));
            Console.WriteLine(substraction2.Evaluate());
            Console.WriteLine(substraction2.Format());
            Console.ReadLine();


        }
    }
}
