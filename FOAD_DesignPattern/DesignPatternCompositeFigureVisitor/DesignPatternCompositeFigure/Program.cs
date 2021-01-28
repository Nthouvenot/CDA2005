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
            VisitorForConsole console = new VisitorForConsole();
            //test figure
            Console.WriteLine("test méthode figure :");
            Triangle triangle = new Triangle(new Coordinate(5, 5), new Coordinate(7, 12), new Coordinate(9, 5));
            triangle.AcceptVisitor(console);
            Circle circle = new Circle(new Coordinate(4, 5), 10);
            circle.AcceptVisitor(console);
            Square square = new Square(new Coordinate(1, 2), 5);
            square.AcceptVisitor(console);
            Rectangle rectangle = new Rectangle(new Coordinate(4, 5), new Coordinate(10, 10));
            rectangle.AcceptVisitor(console);
            Console.ReadLine();

            //instantiate second figures
            Rectangle rectangle2 = new Rectangle(new Coordinate(6, 5), new Coordinate(12, 7));
            Circle circle2 = new Circle(new Coordinate(4, 2), 5);
            Figures figures2 = new Figures(new Coordinate(2, 2));
            figures2.AddFigure(rectangle2);
            figures2.AddFigure(circle2);


            //test print figures
            Console.WriteLine("test méthodes figures (3 figures + 1 figures composé de 2 figures :");
            Figures figures = new Figures(new Coordinate(0, 0));
            figures.AddFigure(circle);
            figures.AddFigure(square);
            figures.AddFigure(rectangle);
            figures.AddFigure(figures2);
            figures.AcceptVisitor(console);
            Console.ReadLine();
        }
    }
}
