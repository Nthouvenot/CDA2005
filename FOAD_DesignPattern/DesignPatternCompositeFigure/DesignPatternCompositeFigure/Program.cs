using CompositeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCompositeFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(new Coordinate(4, 5), 10);
            Console.WriteLine(circle.Draw());

            Square square = new Square(new Coordinate(1, 2), 5);
            Console.WriteLine(square.Draw());

            Rectangle rectangle = new Rectangle(new Coordinate(4, 5), new Coordinate(10, 10));
            Console.WriteLine(rectangle.Draw());
            Console.ReadLine();
        }
    }
}
