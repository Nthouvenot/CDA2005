using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicePOO
{
    class BankAccount
    {
        private int accountNumber;
        private string ownerName;
        private int balance;
        private int allowedOverdraft;

        /// <summary>
        /// propertie for the getter of the balance attribute
        /// </summary>
        public int Balance
        {
            get => balance; 
        }

        /// <summary>
        /// return the information of the account to string format
        /// </summary>
        /// <returns>string</returns>
        public String Print()
        {
            return this.accountNumber + this.ownerName + this.balance + this.allowedOverdraft;
        }

        /// <summary>
        /// credit the account with the amount in parameter
        /// </summary>
        /// <param name="_amount"></param>
        public void Credit(int _amount)
        {
            this.balance += _amount;
        }

        /// <summary>
        /// debit the account with the amount in parameter if the balance is enaught
        /// </summary>
        /// <param name="_amount"></param>
        /// <returns>bool</returns>
        public bool Debit(int _amount)
        {
            if(this.balance - _amount < this.allowedOverdraft)
            {
                return false;
            }
            this.balance += _amount;
            return true;
        }

        /// <summary>
        /// transfert a amount to an other bank account
        /// check the balance of the account before making the operation
        /// </summary>
        /// <param name="_destinationAccount"></param>
        /// <param name="_amount"></param>
        /// <returns></returns>
        public bool Transfert(BankAccount _destinationAccount, int _amount)
        {
            if (this.balance - _amount < this.allowedOverdraft)
            {
                return false;
            }
            //ToDo implement the rest of the code
            return true;
        }

        /// <summary>
        /// compare the balance between two account return true if the current account is equals to the other account
        /// </summary>
        /// <param name="_account;"></param>
        /// <returns>bool</returns>
        public bool CompareAccountCredit(BankAccount _account)
        {
            if(this.balance == _account.Balance) // check if my interpretation is correct
            {
                return true;
            }
            return false;
        }
       
    }
}
