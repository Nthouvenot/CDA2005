using System;

namespace CompositeLibrary
{
    public  class Circle : Figure
    {
        private int radius;

        public Circle(Coordinate coordinate, int radius) : base(coordinate)
        {
            this.coordinate = new Coordinate(coordinate);
            this.radius = radius;
        }

        public override void Draw()
        {
            Console.WriteLine("Je suis un cercle de centre " + this.coordinate.ToString() + " et de rayon " + this.radius.ToString());
        }
    }
}
