using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeLibrary
{
    public class Square : Figure
    {
        public Square(Coordinate coordinate):base(coordinate)
        {

        }

        public override void Draw()
        {
            throw new NotImplementedException();
        }
    }
}
