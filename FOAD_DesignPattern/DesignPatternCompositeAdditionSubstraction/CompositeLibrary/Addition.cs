using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeLibrary
{
    public class Addition : Binary
    {
        public Addition(Expression leftExpression, Expression rightExpression) : base(leftExpression, rightExpression)
        {

        }

        public override int Evaluate()
        {
            return this.leftExpression + this.rightExpression;
        }

        public override string Format()
        {
            if(this.leftExpression is NumberExpression && this.rightExpression is NumberExpression)
            {
                return this.leftExpression.Format() + "+" + this.rightExpression.Format() + "=" + this.Evaluate().ToString();
            }
            else
            {
                return this.leftExpression.Format() + "+" + this.rightExpression.Format();
            }
        }
    }
}