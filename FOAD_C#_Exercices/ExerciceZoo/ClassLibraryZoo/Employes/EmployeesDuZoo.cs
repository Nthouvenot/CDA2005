using ClassLibraryZoo.Contrats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryZoo.Employes
{
    public abstract class EmployeesDuZoo : IDeplacable, IParleable

    {
        private DateTime dateEmbauche;
        private bool estEnPoste;

        public bool EstEnPoste 
        { 
            get => this.estEnPoste; 
            set => this.estEnPoste = value;
        }

        protected EmployeesDuZoo() : this(DateTime.Today, false)
        {
        }

        protected EmployeesDuZoo(DateTime dateEmbauche, bool estEnPoste)
        {
            this.dateEmbauche = dateEmbauche;
            this.estEnPoste = estEnPoste;
        }

        public abstract bool SeDeplacer();

        public void AppellerSecours()
        {
            Console.WriteLine("Je suis un employé et j'appelle les secours");
        }

    }
}
