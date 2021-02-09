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
            //Test Iterator
            Console.WriteLine("**********test itérateur sur Rectangle**********\n");
            Figures figuresRectangleTest = new Figures(new Coordinate(0, 0));
            Triangle triangleRectangleTest = new Triangle(new Coordinate(10, 100), new Coordinate(40, 10), new Coordinate(100, 100));
            Rectangle rectangleRectangleTest = new Rectangle(new Coordinate(10, 100), new Coordinate(40, 150));
            Rectangle rectangleRectangleTest2 = new Rectangle(new Coordinate(60, 100), new Coordinate(100, 150));
            Square squareRectangleTest = new Square(new Coordinate(10, 150), 100);
            Circle circleRectanglesTest = new Circle(new Coordinate(60, 300), 100);
            Rectangle rectangleRectangleTest3 = new Rectangle(new Coordinate(10, 350), new Coordinate(100, 450));
            figuresRectangleTest.AddFigure(triangleRectangleTest);
            figuresRectangleTest.AddFigure(rectangleRectangleTest);
            figuresRectangleTest.AddFigure(rectangleRectangleTest2);
            figuresRectangleTest.AddFigure(squareRectangleTest);
            figuresRectangleTest.AddFigure(circleRectanglesTest);
            figuresRectangleTest.AddFigure(rectangleRectangleTest);

            //print all the figure
            Console.WriteLine("  *******affichage tout les figures avec methode Draw********");
            figuresRectangleTest.Draw();

            //Print to the console only the rectangles with the Figures enumerator
            Console.WriteLine("\n  **affichage tout les rectangles de figures avec iterateur**");
            foreach(Rectangle rectangleIterate in figuresRectangleTest)
            {
               rectangleIterate.Draw();
            }
            Console.ReadLine();
        }
    }
}
