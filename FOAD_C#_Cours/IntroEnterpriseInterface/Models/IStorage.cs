using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace IntroEnterprise.Models
{
    interface IStorage
    {
        /// <summary>
        /// store the current object in database
        /// </summary>
        /// <returns></returns>
        public bool Save();
    }
}
