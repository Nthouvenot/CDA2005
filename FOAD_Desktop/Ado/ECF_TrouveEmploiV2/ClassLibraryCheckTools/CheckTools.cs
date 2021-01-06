using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibraryCheckTools
{
    public static class CheckTools
    {
        public static bool VerificationNumeroSecuriteSocial(string numeroSecuriteSocial)
        {
            Regex regexNumeroSecuriteSocial = new Regex(@"^[1-2][0-9]{14}$");
            if (!regexNumeroSecuriteSocial.IsMatch(numeroSecuriteSocial))
            {
                return false;
            }
            int mois = Int32.Parse(numeroSecuriteSocial.Substring(3, 2));
            if (mois > 12)
            {
                return false;
            }
            int departement = Int32.Parse(numeroSecuriteSocial.Substring(5, 2));
            if (departement > 96 && departement != 99)
            {
                return false;
            }
            return true;
        }

        public static bool VerificationNomPrenom(string nomPrenom)
        {
            Regex regexNomPrenom = new Regex(@"^[a-zA-Z]{4,50}$");
            if(!regexNomPrenom.IsMatch(nomPrenom))
            {
                return false;
            }
            return true;
        }

        public static bool Verificationdate(DateTime dateTime)
        {
            if (dateTime > DateTime.Now)
            {
                return false;
            }
            return true;
        }
    }
}
