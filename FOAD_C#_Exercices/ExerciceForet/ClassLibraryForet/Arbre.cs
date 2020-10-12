using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForet
{
    public class Arbre
    {
        int hauteur;
        private List<Feuille> feuilles;

        public Arbre(int hauteur)
        {
            this.hauteur = hauteur;
            this.feuilles = new List<Feuille>();
        }

        public Arbre(int hauteur, List<Feuille> feuilles) //ouvre porte aggregation
        {
            this.hauteur = hauteur;
            this.feuilles = new List<Feuille>(feuilles);
        }

        public int Hauteur
        {
            get => hauteur;
            //set => hauteur = value; 
        }

        public void AddFeuille(Feuille feuille)
        {
            //a faire
            this.feuilles.Add(feuille);
        }

        public void PasserEnAutomne()
        {
            foreach(Feuille feuille in feuilles)
            {
                feuille.PasserEnAutomne();
            }
        }

        public override string ToString()
        {
            String chaineRetour =  " ";
            if(this.feuilles.Count() == 0)
            {
                chaineRetour = "l'arbre est en hiver";
            }
            chaineRetour += "L'arbre a " + this.feuilles.Count() + " feuilles" + " et mesure " + this.hauteur + "M\n";
            foreach (Feuille feuille in feuilles)
            {
                chaineRetour += feuille.ToString() + "\n";
            }
            return chaineRetour;
        }

    }
}
