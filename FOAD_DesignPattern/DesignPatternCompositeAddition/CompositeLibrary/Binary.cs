using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeLibrary
{
    public abstract class Binary : Expression
    {
        protected Expression rightExpression;
        protected Expression leftExpression;

        public Binary(Expression rightExpression)
        {
            this.rightExpression = rightExpression;
        }

        public Binary(Expression rightExpression, Expression leftExpression)
        {
            this.rightExpression = rightExpression;
            this.leftExpression = leftExpression;
        }
    }
}
