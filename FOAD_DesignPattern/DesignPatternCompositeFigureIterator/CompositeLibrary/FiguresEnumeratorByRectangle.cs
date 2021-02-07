using System;
using System.Collections;
using System.Collections.Generic;

namespace CompositeLibrary
{
    // When you implement IEnumerable, you must also implement IEnumerator.
    public class FiguresEnumeratorByRectangle : IEnumerator, IEnumerator<Rectangle>
    {
        private Figures figures;
        // Enumerators are positioned before the first element
        // until the first MoveNext() call
        private int position = -1;

        public FiguresEnumeratorByRectangle(Figures figures)
        {
            this.figures = new Figures(figures.Coordinate);
            foreach (Figure figure in figures)
            {
                if(figure is Rectangle)
                {
                    this.figures.AddFigure(new Rectangle((Rectangle)figure));
                }
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Rectangle Current
        {
            get
            {
                try
                {
                    return (Rectangle)figures[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        //provide an mechanism for relase unmanaged ressource
        public void Dispose()
        {

        }

        public bool MoveNext()
        {
            position++;
            return (position < figures.Count);
        }

        public void Reset()
        {
            position = -1;
        }  
    }
}