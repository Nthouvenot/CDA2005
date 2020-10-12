using System;

namespace ExercicePoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.Move(1, 5);
            Point p2 = new Point(5, 6);
            Console.WriteLine("point symétrique sur abscisse");
            Console.WriteLine(p1.CreateSymetricalAbscissaPoint());
            Console.WriteLine("point symétrique sur ordonné");
            Console.WriteLine(p1.CreateSymetricalOrdinatePoint());
            Console.WriteLine("point symétrique sur origine");
            Console.WriteLine(p1.CreateSymetricalOriginPoint());
            Console.WriteLine("permuter les coordonnées");
            Console.WriteLine("avant : " + p2.ToString());
            p2.MoveSymetrical();
            Console.WriteLine("aprés " + p2.ToString());
        }
    }
}
