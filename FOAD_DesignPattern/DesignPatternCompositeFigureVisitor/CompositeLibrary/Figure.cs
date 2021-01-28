using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeLibrary
{
    public abstract class Figure
    {
        protected Coordinate coordinate;

        public Figure(Coordinate coordinate)
        {
            this.coordinate = new Coordinate(coordinate);
        }

        public abstract void AcceptVisitor(IVisitor visitor);
    }
}
