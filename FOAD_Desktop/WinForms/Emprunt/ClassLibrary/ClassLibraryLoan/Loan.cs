using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLoan
{
    public class Loan
    {
        private int rate;
        int numberOfMonth;
        private int amount;
        private float amountPerMonth;

        private enum reimbursementPeriod { monthly = 1, biMonthly = 2, triMonthly = 3, biAnnual = 6, annual = 12 };

        public Loan()
        {
            this.rate = 3;
            this.numberOfMonth = 1;
            this.amount = 0;
            this.amountPerMonth = 0;
            reimbursementPeriod currentReimbursementPeriod = reimbursementPeriod.monthly;
        }

        /// <summary>
        /// Property of the rate attribute
        /// check if the value is 3, 6 or 9 elseif reject the set
        /// </summary>
        public int Rate 
        { 
            get => rate;
            set
            {
                if(value != 7 || value != 8 || value != 9)
                {
                    return;
                }
                this.rate = value;
            }
        }

        /// <summary>
        /// Property of the numberOfMonth attribute
        /// check if the value is lower than 25 years
        /// </summary>
        public int NumberOfMonth 
        { 
            get => numberOfMonth;
            set
            {
                if(value > (25 * 12))
                {
                    return;
                }
                this.numberOfMonth = value;
            }
        }

        /// <summary>
        /// Property of the amount attribute
        /// Check if the value is lower than the maximum capacity of an integer 
        /// </summary>
        public int Amount 
        {
            get => amount; 
            set
            {
                if(value > Int32.MaxValue)
                {
                    return;
                }
                this.amount = value;
            }
        }

        /// <summary>
        /// Calculate the amount that the borrower that he must pay at each reimbursement
        /// </summary>
        /// <returns></returns>
        public float Calculate()
        {
            float ratePerMonth = rate / 12;
            this.amountPerMonth = (float)(amount * (ratePerMonth / (1 - (1 + ratePerMonth) * Math.Exp(-this.numberOfMonth))));
            return amountPerMonth;
        }
    }
}
