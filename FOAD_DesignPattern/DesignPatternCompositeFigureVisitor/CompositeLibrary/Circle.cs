using System;

namespace CompositeLibrary
{
    public  class Circle : Figure
    {
        private int radius;

        public Coordinate Coordinate { get => coordinate; protected set => coordinate = value; }
        public int Radius { get => radius; protected set => radius = value; }

        public Circle(Coordinate coordinate, int radius) : base(coordinate)
        {
            this.coordinate = new Coordinate(coordinate);
            this.radius = radius;
        }

        public override void AcceptVisitor(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
