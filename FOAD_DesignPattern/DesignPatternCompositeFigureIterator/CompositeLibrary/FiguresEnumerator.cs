using System;
using System.Collections;
using System.Collections.Generic;

namespace CompositeLibrary
{
    // When you implement IEnumerable, you must also implement IEnumerator.
    public class FiguresEnumerator : IEnumerator
    {
        private List<Figure> figuresToDraw;
        // Enumerators are positioned before the first element
        // until the first MoveNext() call.
        private int position = -1;

        public FiguresEnumerator(List<Figure> figuresToDraw) //here implement the export of rectangles figure
        {
            this.figuresToDraw = new List<Figure>();
            foreach (Figure figure in figuresToDraw)
            {
                if(figure is Rectangle)
                {
                    this.figuresToDraw.Add(new Rectangle((Rectangle)figure));
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

        public Figure Current
        {
            get
            {
                try
                {
                    return figuresToDraw[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        public bool MoveNext()
        {
            position++;
            return (position < figuresToDraw.Count);
        }

        public void Reset()
        {
            position = -1;
        }
    }
}