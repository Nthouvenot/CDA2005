using System;
using System.Collections.Generic;
using System.Text;

namespace IntroEnterprise.Models
{
    class Employee : Person
    {
        public Employee(string _firstname, string _lastname) : base(_firstname, _lastname)
        {

        }

        public override string  GetInfo()
        {
            return "";
        }
    }
}
