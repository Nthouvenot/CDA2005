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

        public static bool CheckSuplierString(string suplierString)
        {
            Regex suplierCodeRegex = new Regex(@"^[a-zA-z]{1,50}$");
            if (!suplierCodeRegex.IsMatch(suplierString))
            {
                return false;
            }
            return true;
        }

        public static bool CheckSuplierSatisfaction(string suplierSatisfaction)
        {
            Regex suplierCodeRegex = new Regex(@"^[0-10]$");
            if (!suplierCodeRegex.IsMatch(suplierSatisfaction))
            {
                return false;
            }
            return true;
        }
        
        public static bool CheckSuplierAdress(string adress)
        {
            Regex suplierCodeRegex = new Regex(@"^[0-9]{1,3}\s[a-zA-Z]{1,47}$");
            if (!suplierCodeRegex.IsMatch(adress))
            {
                return false;
            }
            return true;
        } 
        
        public static bool CheckZipCode(string zipCode)
        {
            int code = 0;
            Regex suplierCodeRegex = new Regex(@"^[0-9]{5}$");
            if (!suplierCodeRegex.IsMatch(zipCode))
            {
                return false;
            }
            else
            {
                Int32.TryParse(zipCode, out code);
                if (code < 0 || code > 96000)
                {
                    return false;
                }
            }
            return true;
        }
    }
}