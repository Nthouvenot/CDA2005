using ClassLibraryZoo.Contrats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryZoo.Animaux
{
    public class Perroquet : AnimalDuZoo, IParleable
    {
        public Perroquet() : base(DateTime.Today, false)
        {

        }

        public Perroquet(DateTime dateDeNaissance, bool estNeeAuZoo) : base(dateDeNaissance, estNeeAuZoo)
        {

        }

        public void Manger()
        {
            throw new System.NotImplementedException();
        }

        public override bool SeDeplacer()
        {
            Console.WriteLine("Je vole!");
            return true;
        }

        public void AppellerSecours()
        {
            Console.WriteLine("Je suis un perroquet et j'appelle les secours");
            return;
        }
    }
}
