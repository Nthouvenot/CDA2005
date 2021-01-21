using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeLibrary
{
    public class Addition : Binary
    {
        public Addition(Expression rightExpression, Expression leftExpression) : base(rightExpression, leftExpression)
        {

        }

        public override int Evaluate()
        {
            return this.rightExpression + this.leftExpression;
        }
    }
}
