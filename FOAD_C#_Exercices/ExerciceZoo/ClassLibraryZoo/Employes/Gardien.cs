using ClassLibraryZoo.Contrats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryZoo.Employes
{
    public class Gardien : EmployeesDuZoo
    {
        public Gardien(DateTime dateEmbauche, bool estEnPoste) : base(dateEmbauche, estEnPoste) 
        {
            if(dateEmbauche > DateTime.Now)
            {
                throw new ArgumentException("Date invalide", "dateEmbauche");
            }
        }

        public override bool SeDeplacer()
        {
            Console.WriteLine("Je cours");
            return true;
        }
    }
}
