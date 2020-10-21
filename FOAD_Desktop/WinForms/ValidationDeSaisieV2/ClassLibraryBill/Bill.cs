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
