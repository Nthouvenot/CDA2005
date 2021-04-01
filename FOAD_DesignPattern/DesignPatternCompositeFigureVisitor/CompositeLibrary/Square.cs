using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeLibrary
{
    public class Square : Figure
    {
        int width;

        public Coordinate Coordinate { get => coordinate; protected set  => coordinate = value; }
        public int Width { get => width; protected set => width = value; }

        public Square(Coordinate coordinate, int width):base(coordinate)
        {
            this.width = width;
        }

        public override void AcceptVisitor(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
