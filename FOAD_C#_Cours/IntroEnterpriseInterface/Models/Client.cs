using System;
using System.Collections.Generic;
using System.Text;

namespace IntroEnterprise.Models
{
    class Client : Person
    {
        int idClient;

        /// <summary>
        /// constructor with the idClient attribute in parameter and call to the constructor of the base class
        /// </summary>
        /// <param name="_firstname"></param>
        /// <param name="_lastname"></param>
        /// <param name="_idClient"></param>
        public Client(string _firstname, string _lastname, int _idClient) : base(_firstname, _lastname)
        {
            this.idClient = _idClient;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string GetInfo()
        {
            return "";
        }


    }
}
