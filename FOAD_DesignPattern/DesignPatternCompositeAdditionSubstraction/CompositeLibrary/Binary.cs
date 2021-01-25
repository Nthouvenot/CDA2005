using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeLibrary
{
    public abstract class Binary : Expression
    {
        protected Expression rightExpression;
        protected Expression leftExpression;

        public Binary(Expression leftExpression, Expression rightExpression)
        {
            this.rightExpression = rightExpression;
            this.leftExpression = leftExpression;
        }
    }
}
