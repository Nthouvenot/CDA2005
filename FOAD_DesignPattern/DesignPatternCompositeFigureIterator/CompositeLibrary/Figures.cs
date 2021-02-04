using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CompositeLibrary
{
    public class Figures : Figure, IEnumerable, IEnumerable<Figure>
    {
        private List<Figure> figuresToDraw;

        public List<Figure> FiguresToDraw { get => figuresToDraw; protected set => figuresToDraw = value; }

        public Figures(Coordinate coordinate) : base(coordinate)
        {
            this.figuresToDraw = new List<Figure>();
        }

        public void AddFigure(Figure figure)
        {
            if(figure != this)
            this.figuresToDraw.Add(figure);
        }

        public override void Draw()
        {
            foreach(Figure figure in figuresToDraw)
            {
                figure.Draw();
            }
        }

        // Implementation for the GetEnumerator method.
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public FiguresEnumerator GetEnumerator()
        {
            return new FiguresEnumerator(this);
        }

        IEnumerator<Figure> IEnumerable<Figure>.GetEnumerator()
        {
            return (IEnumerator<Figure>)GetEnumerator();
        }
    }
}

