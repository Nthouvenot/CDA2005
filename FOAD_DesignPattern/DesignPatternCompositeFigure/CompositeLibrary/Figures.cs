using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeLibrary
{
    public class Figures : Figure
    {
        private List<Figure> figuresToDraw;

        public Figures(Coordinate coordinate) : base(coordinate)
        {
            this.figuresToDraw = new List<Figure>();
        }

        public void AddFigure(Figure figure)
        {
            this.figuresToDraw.Add(figure);
        }

        public override void Draw()
        {
               foreach(Figure figure in figuresToDraw)
            {
                figure.Draw();
            }
        }
    }
}

