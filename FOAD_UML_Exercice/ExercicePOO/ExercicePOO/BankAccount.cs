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
        /// constructor with no parameter
        /// </summary>
        public BankAccount()
        {
            this.accountNumber = 0;
            this.ownerName = "OwnerName";
            this.balance = 0;
            this.allowedOverdraft = 0;
        }

        /// <summary>
        /// constructor with all attribute in parameters
        /// </summary>
        /// <param name="_accountNumber"></param>
        /// <param name="_ownerName"></param>
        /// <param name="_balance"></param>
        /// <param name="_allowedOverdraft"></param>
        public BankAccount(int _accountNumber, string _ownerName, int _balance, int _allowedOverdraft)
        {
            this.accountNumber = _accountNumber;
            this.ownerName = _ownerName;
            this.balance = _balance;
            this.allowedOverdraft = _allowedOverdraft;
        }

        /// <summary>
        /// propertie for the getter of the balance attribute
        /// </summary>
        public int Balance
        {
            get => balance; 
        }

        /// <summary>
        /// return the information of the account to string format
        /// if the BankAccount is empty return a void string
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            if(this.accountNumber == 0 && this.ownerName == "OwnerName")
            {
                return " ";
            }
            return "numéro : " + this.accountNumber + " nom :" + this.ownerName + " solde :" + this.balance + " découvert autorisé :" + this.allowedOverdraft;
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
            this.balance -= _amount;
            return true;
        }

        /// <summary>
        /// transfert a amount to an other bank account
        /// check the balance of the account before making the operation
        /// </summary>
        /// <param name="_amount"></param>
        /// <param name="_destinationAccount"></param>
        /// <returns></returns>
        public bool Transfert(int _amount, BankAccount _destinationAccount)
        {
            if(!this.Debit(_amount))
            {
                return false;
            }
            _destinationAccount.Credit(_amount);
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
