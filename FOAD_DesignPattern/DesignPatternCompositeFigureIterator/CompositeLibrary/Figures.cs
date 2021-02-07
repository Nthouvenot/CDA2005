using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CompositeLibrary
{
    public class Figures : Figure, IEnumerable, IEnumerable<Figure>, IEnumerable<Rectangle>
    {
        // Collection count number is positioned at 0
        // until the first AddFigure() call
        private List<Figure> figuresToDraw;

        //Properties
        // Add an index to the collection.
        public Figure this[int index]
        {
            get { return figuresToDraw[index]; }
            set { figuresToDraw[index] = value; }
        }
        public Coordinate Coordinate
        { get { return this.coordinate; } }
        //Implementation du Count
        public int Count
        {
            get { return figuresToDraw.Count; }
        }

        public Figures(Coordinate coordinate) : base(coordinate)
        {
            this.figuresToDraw = new List<Figure>();
        }

        public void AddFigure(Figure figure)
        {
            if (figure != this)
            {
                this.figuresToDraw.Add(figure);
            }
        }

        public override void Draw()
        {
            foreach (Figure figure in figuresToDraw)
            {
                figure.Draw();
            }
        }

        //implementation for the GetEnumerator method
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        IEnumerator<Figure> IEnumerable<Figure>.GetEnumerator()
        {
            return new FiguresEnumerator(this);
        }

        IEnumerator<Rectangle> IEnumerable<Rectangle>.GetEnumerator()
        {
            return (IEnumerator<Rectangle>)new FiguresEnumeratorByRectangle(this);
        }

        public FiguresEnumerator GetEnumerator()
        {
            return new FiguresEnumerator(this);
        }

        public FiguresEnumeratorByRectangle GetEnumeratorByRectangle()
        {
            return new FiguresEnumeratorByRectangle(this);
        }
    }
}