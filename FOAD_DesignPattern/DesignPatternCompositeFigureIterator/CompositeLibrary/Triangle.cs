 using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeLibrary
{
    public class Triangle : Figure
    {
        private Coordinate coordinateSecondDot;
        private Coordinate coordinateThirdDot;

       public Triangle(Coordinate coordinateFirstDot, Coordinate coordinateSecondDot, Coordinate coordinateThirdDot) : base(coordinateFirstDot)
        {
            this.coordinateSecondDot = new Coordinate(coordinateSecondDot);
            this.coordinateThirdDot = new Coordinate(coordinateThirdDot);
        }

        public override void Draw()
        {
            Console.WriteLine("Je suis un triangle de premier point " + this.coordinate.ToString() + " de deuxiéme point  " + this.coordinateSecondDot.ToString() + " et de troisiéme point " + this.coordinateThirdDot.ToString());
        }
    }
}
