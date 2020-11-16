using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibraryLoan
{
    public static class CheckTools
    {
        public static bool CheckName(string _name)
        {
            Regex regexName = new Regex(@"^[a-zA-Z]{4,30}$");
            if (!regexName.IsMatch(_name))
            {
                return false;
            }
            return true;
        }

        public static bool CheckMoneyBoworred(string _name)
        {
            Regex regexName = new Regex(@"[0-9]{4,10}$");
            if(!regexName.IsMatch(_name))
            {
                return false;
            }
            return true;
        }
    }
}
