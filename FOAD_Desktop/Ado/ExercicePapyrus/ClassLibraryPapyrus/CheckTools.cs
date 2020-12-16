using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibraryPapyrus
{
    public static class CheckTools
    {
        public static bool CheckSuplierCode(string suplierCode)
        {
            Regex suplierCodeRegex = new Regex(@"^[0-9]{1,10}$");
            if (!suplierCodeRegex.IsMatch(suplierCode))
            {
                return false;
            }
            return true;
        }
    }
}