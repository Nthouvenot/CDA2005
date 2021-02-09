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

        /// <summary>
        /// return thre current element of the collection
        /// </summary>
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

        /// <summary>
        /// Move to the next element of the collection ans return the element
        /// </summary>
        /// <returns></returns>
        public bool MoveNext()
        {
            position++;
            return (position < figures.Count);
        }

        /// <summary>
        /// Reset the pointer
        /// </summary>
        public void Reset()
        {
            position = -1;
        }
    }
}
