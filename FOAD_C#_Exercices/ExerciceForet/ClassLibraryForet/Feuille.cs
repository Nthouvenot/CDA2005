using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForet
{
    public class Feuille
    {
        private int nbNervures;
        private EnumCouleur couleurFeuille;
        private EnumFormeFeuille formeFeuille;

        public Feuille(int nbNervures)
        {
            this.nbNervures = nbNervures;
        }

        public Feuille(int nbNervures, EnumFormeFeuille formeFeuille)
        {
            this.nbNervures = nbNervures;
            this.formeFeuille = formeFeuille;
            this.couleurFeuille = EnumCouleur.Vert;
        }

        public Feuille(int nbNervure, EnumFormeFeuille formeFeuille, EnumCouleur couleurFeuille)
        {
            this.nbNervures = nbNervure;
            this.formeFeuille = formeFeuille;
            this.couleurFeuille = couleurFeuille;

        }

        public int NbNervures 
        { 
            get => nbNervures; 
          //set => nbNervures = value; 
        }

        public void Tomber()
        {
            Console.WriteLine("Je tombe");
        }

        public void PasserEnAutomne()
        {
            if(this.couleurFeuille == EnumCouleur.Jaune)
            {
                this.couleurFeuille = EnumCouleur.Rouge;
            }
            this.couleurFeuille = EnumCouleur.Jaune;
        }

        public override string ToString()
        {
            return "nombre de nervure : " + this.nbNervures + ", forme de feuille : " + this.formeFeuille  + ", couleur : " + this.couleurFeuille;
        }
    }
}
