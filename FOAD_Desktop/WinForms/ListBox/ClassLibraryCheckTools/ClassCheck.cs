using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibraryCheckTools
{
    public class ClassCheck
    {
        public static bool CheckName(string _name)
        {
            Regex regexName = new Regex(@"^[a-zA-Z]{2,15}$");
            if (!regexName.IsMatch(_name))
            {
                return false;
            }
            return true;
        }

        public static bool CheckIndex(string _name)
        {
            Regex regexName = new Regex(@"^[0-9]{1,4}$");
            if (!regexName.IsMatch(_name))
            {
                return false;
            }
            return true;
        }
    }
}
