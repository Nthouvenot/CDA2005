using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeLibrary
{
    public class Coordinate
    {
        private int xCoordinnate;
        private int yCoordinnate;

        public Coordinate(int xCoordinnate, int yCoordinnate)
        {
            this.xCoordinnate = xCoordinnate;
            this.yCoordinnate = yCoordinnate;
        }

        public Coordinate(Coordinate coordinate)
        {
            this.xCoordinnate = coordinate.xCoordinnate;
            this.yCoordinnate = coordinate.yCoordinnate;
        }

        public override string ToString()
        {
            return this.xCoordinnate.ToString() + "," + this.yCoordinnate.ToString();
        }
    }
}
