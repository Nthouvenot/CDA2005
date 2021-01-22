using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeLibrary
{
    public class NumberExpression : Expression
    {
        private int number;

        public NumberExpression(int number)
        {
            this.number = number;
        }

        public int Number { get; /*set;*/ }

        public override int Evaluate()
        {
            return this.number;
        }

        public override string Format()
        {
            return this.number.ToString();
        }
    }
}
