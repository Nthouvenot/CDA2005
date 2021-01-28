using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeLibrary
{
    public interface IVisitor
    {
        void Visit(Circle circle);
        void Visit(Figures figures);
        void Visit(Rectangle rectangle);
        void Visit(Square square);
        void Visit(Triangle triangle);
    }
}
