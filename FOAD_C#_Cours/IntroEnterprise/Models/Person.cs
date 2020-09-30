<<<<<<< HEAD
<<<<<<< HEAD
using IntroEnterprise.Models;

namespace IntroEnterprise
{
    abstract class Person : IStorage, ISalary
=======
namespace IntroEnterprise
{
    abstract class Person
>>>>>>> e99e87d... Create FOAD_C#_Cours/IntroEnterprise
=======
using IntroEnterprise.Models;

namespace IntroEnterprise
{
    abstract class Person : IStorage, ISalary
>>>>>>> 9a39fcc... Update Enterprise.cs and Person.cs
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