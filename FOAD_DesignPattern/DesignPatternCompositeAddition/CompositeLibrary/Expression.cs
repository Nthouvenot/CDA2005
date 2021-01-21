using System;

namespace CompositeLibrary
{
    public abstract class Expression
    {
        public abstract int Evaluate();

        public static int operator +(Expression rightExpression, Expression leftExpression)
        {
            return rightExpression.Evaluate() + leftExpression.Evaluate();
        }
    }
}
