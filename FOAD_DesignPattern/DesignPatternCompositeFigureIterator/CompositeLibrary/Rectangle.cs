using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeLibrary
{
    public class Rectangle : Figure
    {
        private Coordinate coordianteSecondDot;

        public Rectangle(Coordinate coordinateFirstDot, Coordinate coordianteSecondDot) : base(coordinateFirstDot)
        {
            this.coordianteSecondDot = new Coordinate(coordianteSecondDot);
        }

        public Rectangle(Rectangle rectangle) : base(rectangle.coordinate)
        {
            this.coordianteSecondDot = new Coordinate(rectangle.coordianteSecondDot);
        }

        public override void Draw()
        {
            Console.WriteLine("Je suis un rectangle d'origine " + this.coordinate.ToString() + " et de deuxiéme point " + this.coordianteSecondDot.ToString());
        }
    }
}
