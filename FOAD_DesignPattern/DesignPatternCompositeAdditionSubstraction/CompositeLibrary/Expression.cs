using System;

namespace CompositeLibrary
{
    public abstract class Expression
    {
        public abstract int Evaluate();
        public abstract string Format();

        public static int operator +(Expression leftExpression, Expression rightExpression)
        {
            return rightExpression.Evaluate() + leftExpression.Evaluate();
        }

        public static int operator -(Expression leftExpression, Expression rightExpression)
        {
            return leftExpression.Evaluate() - rightExpression.Evaluate();
        }
    }
}
