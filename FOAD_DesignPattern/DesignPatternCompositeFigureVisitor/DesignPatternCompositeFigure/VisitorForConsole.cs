using CompositeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCompositeFigure
{
    class VisitorForConsole : IVisitor
    {
        public void Visit(Circle circle)
        {
            Console.WriteLine("Je suis un cercle de centre " + circle.Coordinate + " et de rayon " + circle.Radius.ToString());
        }

        public void Visit(Figures figures)
        {
            Console.WriteLine("Je suis un ensemble de figure a la position " + figures.Coordinate);
        }
        
        public void Visit(Rectangle rectangle)
        {
            Console.WriteLine("Je suis un rectangle d'origine " + rectangle.Coordinate.ToString() + " et de deuxiéme point " + rectangle.CoordinateSecondDot.ToString());
        }
        
        public void Visit(Square square)
        {
            Console.WriteLine("Je suis un carré dont le point d'origine est " + square.Coordinate.ToString() + " et de coté " + square.Width.ToString());
        }
        
        public void Visit(Triangle triangle)
        {
            Console.WriteLine("Je suis un triangle de premier point " + triangle.Coordinate.ToString() + " de deuxiéme point  " + triangle.CoordinateSecondDot.ToString() + " et de troisiéme point " + triangle.CoordinateThirdDot.ToString());
        }
    }
}
