using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeLibrary
{
    public class Rectangle : Figure
    {
        private Coordinate coordinateSecondDot;

        public Coordinate Coordinate { get => coordinate; protected set => coordinate = value; }
        public Coordinate CoordinateSecondDot { get => coordinateSecondDot; protected set => coordinateSecondDot = value; }

        public Rectangle(Coordinate coordinateFirstDot, Coordinate coordinateSecondDot) : base(coordinateFirstDot)
        {
            this.coordinateSecondDot = new Coordinate(coordinateSecondDot);
        }

        public override void AcceptVisitor(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
