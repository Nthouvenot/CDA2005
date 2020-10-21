using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryFacture
{
    public class Bill
    {
        string name;
        DateTime date;
        float amount;
        string zipCode;

        public Bill(string _name, DateTime _date, float _amount, string _zipCode)
        {
            this.name = _name;
            this.date = _date;
            this.amount = _amount;
            this.zipCode = _zipCode;
        }

        /// <summary>
        /// Constructor by copy
        /// </summary>
        /// <param name="_bill"></param>
        public Bill(Bill _bill)
        {
            this.name = _bill.name;
            this.date = _bill.date;
            this.amount = _bill.amount;
            this.zipCode = _bill.zipCode;
        }

        /// <summary>
        /// Property of the name attribute only in read
        /// </summary>
        public string Name { 
            get => name; 
            //set => name = value; 
        }

        /// <summary>
        /// Property of the date attribute only in read
        /// </summary>
        public DateTime Date { 
            get => date;
            //set => date = value;
        }

        /// <summary>
        /// Property of the amount attribute only in read
        /// </summary>
        public float Amount {
            get => amount;
            //set => amount = value;
        }

        /// <summary>
        /// Property of the zipCode attribute only in read
        /// </summary>
        public string ZipCode { 
            get => zipCode;
            //set => zipCode = value;
        }

        /// <summary>
        /// Return the state of the object in string format
        /// </summary>
        /// <returns>string</returns>
        public string PrintBill()
        {
            string printString = " ";
            printString = this.name + "\n";
            printString += this.date.ToString() + "\n";
            printString += this.amount + "\n";
            printString += this.zipCode;
            return printString;
        }
    }
}
