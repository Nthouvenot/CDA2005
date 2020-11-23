using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLoan
{
    public class Loan
    {
        private float rate;
        int numberOfMonth;
        private int amount;
        public enum ReimbursementPeriod { monthly = 1, biMonthly = 2, triMonthly = 3, biAnnual = 6, annual = 12 };
        private ReimbursementPeriod currentReimbursementPeriod;

        public Loan()
        {
            this.rate = 7;
            this.numberOfMonth = 0;
            this.amount = 0;
            this.currentReimbursementPeriod = ReimbursementPeriod.monthly;
        }

        /// <summary>
        /// Property of the rate attribute
        /// check if the value is 3, 6 or 9 elseif reject the set
        /// </summary>
        public float Rate
        {
            get => rate;
            set => rate = value;
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
                if (value > 300)
                {
                    return;
                }
                this.numberOfMonth = value;
            }
        }

        /// <summary>
        /// Property of the currentReimbursementPeriod attribute
        /// Check if the value is superior than the numberOfMonth
        /// </summary>
        public ReimbursementPeriod CurrentReimbursementPeriod
        {
            get => this.currentReimbursementPeriod;
            set => this.currentReimbursementPeriod = value;
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
                if (value < 0)
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
        public double Calculate()
        {
            double ratePerMonth = (rate * (int)this.currentReimbursementPeriod) / 1200;
            double amountPerMonth = (float)(amount * (ratePerMonth / (1 - Math.Pow((1 + ratePerMonth), -this.CalculateNumberOfMonth()))));
            return Math.Round(amountPerMonth, 2);
        }

        /// <summary>
        /// calculate the total number of month
        /// </summary>
        /// <returns></returns>
        public int CalculateNumberOfMonth()
        {
            return this.numberOfMonth / (int)this.currentReimbursementPeriod;
        }
    }
}
