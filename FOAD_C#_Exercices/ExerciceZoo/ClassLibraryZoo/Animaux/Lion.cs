using ClassLibraryZoo.Contrats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryZoo.Animaux
{
    public class Lion : AnimalDuZoo
    {
        public Lion() : base(DateTime.Today, false)
        {

        }

        public Lion(DateTime dateDeNaissance, bool estNeeAuZoo) : base(dateDeNaissance, estNeeAuZoo)
        {

        }

<<<<<<< HEAD
        public override void Manger()
=======
        public void Manger()
>>>>>>> f468eff4d7c179340b296b1898726eedaa029684
        {
            throw new System.NotImplementedException();
        }

        public override bool SeDeplacer()
        {
            Console.WriteLine("Je marche lentemmment");
            return true;
        }
    }
}
