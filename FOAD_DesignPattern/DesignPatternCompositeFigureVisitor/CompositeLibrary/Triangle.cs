 using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeLibrary
{
    public class Triangle : Figure
    {
        private Coordinate coordinateSecondDot;
        private Coordinate coordinateThirdDot;

        public Coordinate Coordinate { get => coordinate; protected set => coordinate = value;  }
        public Coordinate CoordinateSecondDot { get => coordinateSecondDot; set => coordinateSecondDot = value; }
        public Coordinate CoordinateThirdDot { get => coordinateThirdDot; set => coordinateThirdDot = value; }

        public Triangle(Coordinate coordinateFirstDot, Coordinate coordinateSecondDot, Coordinate coordinateThirdDot) : base(coordinateFirstDot)
        {
            this.coordinateSecondDot = new Coordinate(coordinateSecondDot);
            this.coordinateThirdDot = new Coordinate(coordinateThirdDot);
        }

        public override void AcceptVisitor(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
