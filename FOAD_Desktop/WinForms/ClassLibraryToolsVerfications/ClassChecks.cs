using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibraryToolsChecks
{
    public static class ClassChecks    {
        public static bool CheckName(string _name)
        {
            Regex regexName = new Regex(@"^[a-zA-Z]{4,30}$");
            if (!regexName.IsMatch(_name))
            {
                return false;
            }
            return true;
        }

        public static bool CheckDate(string _date)
        {
           // ToDo accpet multiple format use DateTime object => DateTime.ParseExact
            if(_date.Length != 10)
            {
                return false;
            }
            DateTime billDate = Convert.ToDateTime(_date);
            if(!(billDate < DateTime.Now))
            {
                return false;
            }
            return true;
        }

        public static bool CheckAmount(string _amount)
        {
            Regex regexAmount = new Regex(@"^[0-9]{1,4}\.?,?[0-9]{1,2}$");
            if(!regexAmount.IsMatch(_amount))
            {
                return false;
            }
            return true;
        }

        public static bool CheckZipCode(string _zipCode)
        {
            Regex regexName = new Regex(@"^[0-9]{5}$");
            if (!regexName.IsMatch(_zipCode))
            {
                return false;
            }
            else if(Int32.Parse(_zipCode) > 96000)
            {
                return false;
            }
            return true;
        }
    }
}
