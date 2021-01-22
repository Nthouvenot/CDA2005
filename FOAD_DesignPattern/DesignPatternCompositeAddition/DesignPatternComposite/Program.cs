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
            NumberExpression numberOne = new NumberExpression(5);
            NumberExpression numberTwo = new NumberExpression(2);

            Console.WriteLine("5+2 = ");
            Addition addition = new Addition(numberOne, numberTwo);
            Console.WriteLine(addition.Evaluate());
            Console.ReadLine();

            Console.WriteLine("8+2+5");
            Addition addition1 = new Addition(new NumberExpression(8), new Addition(numberTwo, numberOne));
            Console.WriteLine(addition1.Evaluate());
            Console.ReadLine();

            Console.WriteLine("8+9+4");
            Addition addition2 = new Addition(new NumberExpression(8), new Addition(new NumberExpression(9), new NumberExpression(4)));
            Console.WriteLine(addition2.Evaluate());
            Console.ReadLine();
        }
    }
}
