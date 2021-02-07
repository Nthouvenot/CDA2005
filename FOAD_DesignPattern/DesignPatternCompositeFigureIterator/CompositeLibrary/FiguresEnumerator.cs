using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CompositeLibrary
{
    public class FiguresEnumerator : IEnumerator, IEnumerator<Figure>
    {

        private Figures figures;
        // Enumerators are positioned before the first element
        // until the first MoveNext() call.
        private int position = -1;

        public FiguresEnumerator(Figures figures)
        {
            this.figures = figures;
        }

        //provide an mechanism for relase unmanaged ressource
        public void Dispose()
        {

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
                    return figures[position];
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
            return (position < figures.Count);
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
