using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibraryLoan;

namespace UnitTestLoan
{
    [TestClass]
    public class UnitTest1
    {
        private Loan loan;

        public UnitTest1()
        {
            this.loan = new Loan();
        }

        [TestMethod]
        public void TestPropertyNumberOfMonth()
        {
            this.loan.NumberOfMonth = 12;
            Assert.AreEqual(12, this.loan.NumberOfMonth);
            this.loan.NumberOfMonth = 300;
            Assert.AreEqual(300, this.loan.NumberOfMonth);
            this.loan.NumberOfMonth = 360;
            Assert.AreEqual(300, this.loan.NumberOfMonth);
        }

        [TestMethod]
        public void TestPropertyAmount()
        {
            this.loan.Amount = 75000;
            Assert.AreEqual(75000, this.loan.Amount);
            this.loan.Amount = Int32.MaxValue;
            Assert.AreEqual(Int32.MaxValue, this.loan.Amount);
            this.loan.Amount = 250000;
            int amount = Int32.MaxValue;
            this.loan.Amount = amount + 150000;
            Assert.AreEqual(250000, this.loan.Amount);
        }

        [TestMethod]
        public void TestCalculate()
        {
            this.loan.Amount = 150000;
            this.loan.Rate = 8;
            this.loan.NumberOfMonth = 120;
            this.loan.CurrentReimbursementPeriod = Loan.ReimbursementPeriod.triMonthly;
            Assert.AreEqual(5483.36, Math.Round(this.loan.Calculate(), 2));
        }

        [TestMethod]
        public void TestCalculateNumberOfMonth()
        {
            this.loan.Amount = 150000;
            this.loan.Rate = 8;
            this.loan.NumberOfMonth = 120;
            this.loan.CurrentReimbursementPeriod = Loan.ReimbursementPeriod.triMonthly;
            Assert.AreEqual(40, this.loan.CalculateNumberOfMonth());
        }
    }
}
