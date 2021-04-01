using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeLibrary
{
    public class Square : Figure
    {
        int width;

        public Square(Coordinate coordinate, int width):base(coordinate)
        {
            this.width = width;
        }

        public override void Draw()
        {
            Console.WriteLine("Je suis un carré dont le point d'origine est " + this.coordinate.ToString() + " et de coté " + this.width.ToString());
        }
    }
}
