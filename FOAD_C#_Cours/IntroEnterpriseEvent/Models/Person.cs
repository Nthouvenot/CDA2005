using IntroEnterprise.Models;
using System.Xml.Linq;

namespace IntroEnterprise
{
    abstract class Person : IStorage, ISalary
    {
        private string lastname;
        private string firstname;

        /// <summary>
        /// contructor with all the attribute in parameters
        /// </summary>
        /// <param name="_firstname"></param>
        /// <param name="_lastname"></param>
        public Person(string _firstname, string _lastname)
        {
            this.firstname = _firstname;
            this.lastname = _lastname;
        }

        abstract public string GetInfo();

       
       
    }
}