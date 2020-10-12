using System;
using System.Runtime.InteropServices;

namespace ExerciceFraction
{
    class Fraction
    {
        private int numerator;
        private int denominator;

        /// <summary>
        /// constructor with no parameter
        /// instanciate a null Fraction
        /// </summary>
        public Fraction()
        {
            this.numerator = 0;
            this.denominator = 1;
        }

        /// <summary>
        /// constructor with the numerator paramater
        /// instanciate a Fraction with 1 in denominator
        /// </summary>
        /// <param name="_numerator"></param>
        public Fraction(int _numerator)
        {
            this.numerator = _numerator;
            this.denominator = 1;
        }
        
        /// <summary>
        /// constructor with the two part of a Fraction
        /// instanciate a fraction with the numerator and the denominator in parameters
        /// </summary>
        /// <param name="_numerator"></param>
        /// <param name="_denominator"></param>
        public Fraction(int _numerator, int _denominator)
        {
            this.numerator = _numerator;
            this.denominator = _denominator;
        }

        /// <summary>
        /// constructor with Fraction parameter type
        /// instanciate a Fraction with an other fraction
        /// </summary>
        /// <param name="_fraction"></param>
        public Fraction(Fraction _fraction)
        {
            string[] fraction = _fraction.ToString().Split("/");
            this.numerator = Int32.Parse(fraction[0]);
            this.denominator = Int32.Parse(fraction[1]);
        }

        /// <summary>
        /// override of the ToString method return Fraction in x/x format
        /// </summary>
        /// <returns>String</returns>
        public override string ToString()
        {
            return this.numerator + "/" + this.denominator;
        }

        /// <summary>
        /// format the fraction depending of the value of the denominator and the numerator
        /// </summary>
        /// <returns>String</returns>
        public string ToDisplay()
        {
            if(this.numerator == 0)
            {
                return this.numerator.ToString();
            }
            if(this.denominator == 1)
            {
                return this.numerator.ToString();
            }
            return this.numerator.ToString() + "/" + this.denominator.ToString();
        }
        
        /// <summary>
        /// calculate the PGCD
        /// </summary>
        /// <returns>int</returns>
        private int GetPgcd()
        {
            int a = this.numerator;
            int b = this.denominator;
            int pgcd = 1;
            if (a != 0 && b != 0)
            {
                if (a < 0) 
                {
                    a = -a;
                }
                if (b < 0)
                {
                    b = -b;
                }
                while (a != b)
                {
                    if (a < b)
                    {
                        b = b - a;
                    }
                    else
                    {
                        a = a - b;
                    }
                    pgcd = a;
                }
            }
            return pgcd;
        }

        /// <summary>
        /// reverse the numerator
        /// </summary>
        public void Oppose()
        {
            this.numerator = -this.numerator;
        }

        /// <summary>
        /// reverse the denominator and the numerator
        /// </summary>
        public void Reverse()
        {
            int exchangeVariable;
            exchangeVariable = this.numerator;
            this.numerator = this.denominator;
            this.denominator = exchangeVariable;
        }

        /// <summary>
        /// simplifies the Fraction
        /// </summary>
        public void Reduce()
        {
            int pgcd = this.GetPgcd(); //calculate of the pgcd of the Fraction
            int numerator = this.numerator / pgcd; //reduce the numerator
            int denominator = this.denominator / pgcd; //reduce the denominator
            if ((this.numerator < 0 && this.denominator < 0) || (this.numerator > 0 && this.denominator < 0))
            {
                this.numerator = -numerator;
                this.denominator = -denominator;
            }
            this.numerator = numerator;
            this.denominator = denominator;
        }

        /// <summary>
        /// compare if the current Fraction is supérior to the fraction in parameter
        /// </summary>
        /// <param name="_fraction"></param>
        /// <returns>bool</returns>
        public bool IsSuperior(Fraction _fraction)
        {
            //we do reduce the two fraction before make the opération
            _fraction.Reduce();
            this.Reduce();
            string[] fraction = _fraction.ToString().Split("/");
            int numerator = Int32.Parse(fraction[0]);
            int denominator = Int32.Parse(fraction[1]);
            if (this.numerator > numerator && this.denominator > denominator) 
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// compare if the current Fraction is equal to the fraction in parameter
        /// </summary>
        /// <param name="_fraction"></param>
        /// <returns></returns>
        public bool IsEqual(Fraction _fraction)
        {
            //we do reduce the two fraction before make the opération
            _fraction.Reduce();
            this.Reduce();
            string[] fractionString = _fraction.ToString().Split("/");
            int numerator = Int32.Parse(fractionString[0]);
            int denominator = Int32.Parse(fractionString[1]);
            if (this.numerator == numerator && this.denominator == denominator)
            {
                return true;
            }
            return false;
        }
 
        /// <summary>
        /// addition two Fraction
        /// </summary>
        /// <param name="_fraction"></param>
        /// <returns>Fraction</returns>
        public Fraction Sums(Fraction _fraction)
        {
            //we do reduce the two fraction before make the opération
            _fraction.Reduce();
            this.Reduce();
            string[] fraction = _fraction.ToString().Split("/");
            int numerator = Int32.Parse(fraction[0]);
            int denominator = Int32.Parse(fraction[1]);
            numerator = this.numerator + numerator;
            return new Fraction(numerator, denominator);

        }

        /// <summary>
        /// sbstract two fraction
        /// </summary>
        /// <param name="_fraction"></param>
        /// <returns>Fraction</returns>
        public Fraction Substract(Fraction _fraction)
        {
            //we do reduce the two fraction before make the opération
            _fraction.Reduce();
            this.Reduce();
            string[] fraction = _fraction.ToString().Split("/");
            int numerator = Int32.Parse(fraction[0]);
            int denominator = Int32.Parse(fraction[1]);
            numerator = this.numerator - numerator;
            return new Fraction(numerator, denominator);
        }

        /// <summary>
        /// Multiply two Fraction
        /// </summary>
        /// <param name="_fraction"></param>
        /// <returns>Fraction</returns>
        public Fraction Multiply(Fraction _fraction)
        {
            //we do reduce the two fraction before make the opération
            _fraction.Reduce();
            string[] fraction = _fraction.ToString().Split("/");
            int numerator = Int32.Parse(fraction[0]);
            int denominator = Int32.Parse(fraction[1]);
            numerator = this.numerator * numerator;
            denominator = this.denominator * denominator;
            return new Fraction(numerator, denominator);
        }

        /// <summary>
        /// divide two Fraction
        /// </summary>
        /// <param name="_fraction"></param>
        /// <returns>Fraction</returns>
        public Fraction Divide(Fraction _fraction)
        {
            //we do reduce the two fraction before make the opération
            _fraction.Reduce();
            string[] fraction = _fraction.ToString().Split("/");
            int numerator = Int32.Parse(fraction[0]);
            int denominator = Int32.Parse(fraction[1]);
            numerator = this.numerator * numerator;
            denominator = this.denominator * denominator;
            return new Fraction(numerator, denominator);
        }
    }

}