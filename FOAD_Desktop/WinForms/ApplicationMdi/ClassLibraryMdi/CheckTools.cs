using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibraryMdi
{
    public static class CheckTools
    {
        /// <summary>
        /// accept the parameter if he contains minimum 8 characters and respect the rules of password
        /// </summary>
        /// <param name="_password"></param>
        public static bool IsPasswordValid(string password)
        {
            //@"^(?=.*[a-zA-Z])(?=.*[0-9])(?=.*[!@#\$%\^&\*])(?=.{8,32})"
            Regex passwordRegex = new Regex(@"^(?=.*[a-zA-Z])(?=.*[0-9])(?=.*[!@#\$%\^&\*])(?=.{8,})");
            if (passwordRegex.IsMatch(password))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// accept the paramater if the login contains only letter betwen 4 to 10 characters
        /// </summary>
        /// <param name="_userName"></param>
        public static bool IsLoginValid(string login)
        {
            Regex usernameRegex = new Regex(@"^[a-zA-Z]{4,10}.[0-9]{0,4}");
            if (usernameRegex.IsMatch(login))
            {
                return true;
            }
            return false;
        }
    }
}
