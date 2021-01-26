using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPersonne
{
    public class Personne
    {
        private string name;
        private int age;

        public string Name { get => name; /*set => name = value;*/ }
        public int Age { get => age; /*set => age = value;*/ }

        public delegate void DelegateMajeur(Personne sender);
        public event DelegateMajeur JeViensDEtreMajeur;

        //rajouter un evenement RisqueCrise...
        public delegate void CriseQuarantaine(Personne sender);
        public event DelegateMajeur JeSuisDansCriseQuarantaine;

        public Personne(string name)
        {
            this.name = name;
            age = 0;
        }

        public void VieillirDUnAn()
        {
            age++;
            if (age == 18)
            { 
                if (JeViensDEtreMajeur != null) //verification que qq s'est enregistre
                {
                    JeViensDEtreMajeur(this);
                }
            } 
            else if(age == 40) 
            {
                if(JeSuisDansCriseQuarantaine != null)
                {
                    JeSuisDansCriseQuarantaine(this);
                }
            } 
        }
    }
}
