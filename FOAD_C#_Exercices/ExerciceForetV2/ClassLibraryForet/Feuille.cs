using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForet
{
    public class Feuille
    {
        int nbNervures;
        EnumCouleur couleurFeuille;
        EnumFormeFeuille formeFeuille;

        public Feuille(int _nbNervures,EnumFormeFeuille _formeFeuille):this(_nbNervures,EnumCouleur.Vert,_formeFeuille)
        {

        }
        public Feuille(int _nbNervures, EnumCouleur _couleurFeuille, EnumFormeFeuille _formeFeuille)
        {
            this.nbNervures = _nbNervures;
            this.couleurFeuille = _couleurFeuille;
            this.formeFeuille = _formeFeuille;
        }


        public int NbNervures { get => nbNervures; 
            //set => nbNervures = value; 
        }

        public void Tomber()
        {
            Console.WriteLine("Je tombe");
        }

        public void PrendsTesCouleursDAutomne()
        {
            if (this.couleurFeuille.Equals(EnumCouleur.Jaune))
            {
                this.couleurFeuille = EnumCouleur.Rouge;
            }
            else
            {
                this.couleurFeuille = EnumCouleur.Jaune;
            }
        }

        public override string ToString()
        {
            return base.ToString() + " nbNervures="+nbNervures+ " couleurFeuille=" + couleurFeuille + " formeFeuille=" + formeFeuille;
        }
    }
}
