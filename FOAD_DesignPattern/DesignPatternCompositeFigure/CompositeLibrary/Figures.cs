using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeLibrary
{
    public class Figures : Figure
    {
        private Figure figureToDraw;

        public Figures(Coordinate coordinate) : base(coordinate)
        {

        }

        public Figure FigureToDraw { get => figureToDraw; /*set => figureToDraw = value;*/ }

        public override string Draw()
        {
            throw new NotImplementedException();
        }
    }
}