using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeLibrary
{
    public class Figures : Figure
    {
        private List<Figure> figuresToDraw;

        public Coordinate Coordinate { get => coordinate; protected set => coordinate = value; }

        public Figures(Coordinate coordinate) : base(coordinate)
        {
            this.figuresToDraw = new List<Figure>();
        }

        public void AddFigure(Figure figure)
        {
            this.figuresToDraw.Add(figure);
        }

        public override void AcceptVisitor(IVisitor visitor)
        {
            visitor.Visit(this);
            foreach (Figure figure in figuresToDraw)
            {
                figure.AcceptVisitor(visitor);
            }
        }
    }
}

