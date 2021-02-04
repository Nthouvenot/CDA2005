using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CompositeLibrary
{
    public class Figures : Figure, IEnumerable, IEnumerable<Figure>
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

        //Implementation for the GetEnumerator method
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        //Generic Enumerator
        IEnumerator<Figure> IEnumerable<Figure>.GetEnumerator()
        {
            return (IEnumerator<Figure>)GetEnumerator();
        }

        public FiguresEnumerator GetEnumerator()
        {
            return new FiguresEnumerator(this);
        }

        ////Rectangle enumerator
        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    return (IEnumerator)GetEnumeratorByRectangle();
        //}


        //IEnumerator<Rectangle> IEnumerable<Figure>.GetEnumerator()
        //{
        //    return (IEnumerator<Rectangle>)GetEnumeratorByRectangle();
        //}

        //public FiguresEnumeratorByRectangle GetEnumeratorByRectangle()
        //{
        //    return new FiguresEnumeratorByRectangle(this);
        //}
    }
}

