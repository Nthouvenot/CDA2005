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

            //print all the figure with Draw method
            Console.WriteLine("  **********affichage tout les figures avec methode Draw***********");
            figuresRectangleTest.Draw();

            //print all the figure with for and the index of the Figures collection
            Console.WriteLine("\n  **********affichage tout les figures avec indexation***********");
            for (int i=0; i < figuresRectangleTest.Count; i++)
            {
                figuresRectangleTest[i].Draw();
            }

            //Print to the console all figure with the iterator
            Console.WriteLine("\n  **affichage de toutes les figures avec iterateur(foreach)**");
            foreach (Figure figure in figuresRectangleTest)
            {
                figure.Draw();
            }

            //Print to the console only the rectangles with the Figures enumerator
            //Console.WriteLine("\n  **affichage tout les rectangles de figures avec iterateur(foreach)**");
            //foreach (Rectangle rectangle in figuresRectangleTest)
            //{
            //    rectangle.Draw();
            //}
            Console.ReadLine();
        }
    }
}
