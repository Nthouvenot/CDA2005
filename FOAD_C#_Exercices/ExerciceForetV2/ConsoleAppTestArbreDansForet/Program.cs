using ClassLibraryForet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestArbreDansForet
{
    class Program
    {
        static void Main(string[] args)
        {
            Feuille f = new Feuille(6, EnumCouleur.Orange, EnumFormeFeuille.crénelé);


            //creation d'un arbre
            Arbre chene1 = new Arbre(10);
            chene1.AddFeuille(6, EnumFormeFeuille.crénelé, EnumCouleur.Vert);
            chene1.AddFeuille(6, EnumFormeFeuille.crénelé, EnumCouleur.Vert);
            //affichage d'un arbre
            Console.WriteLine(chene1.ToString());

            //faire passer l'arbre en automne
            chene1.PasserEnAutomne();
            //affichage un arbre
            Console.WriteLine(chene1.ToString());

            //-------------------------- Cerise sur le gateau --------------------------

            //tomber les feuilles de l'arbre //appeler chaque methode Tomber de l'arbre

            for (int i = 0; i < chene1.Count; i++) //Count -> Propriete
            {
                Feuille feuille = (Feuille)chene1[i]; // voir cours -> Définir un indexeur pour une classe de scharp2008
                feuille.Tomber();
            }

            //respecte le contrat IList.. qui n'assure d etre une liste du Framemwork
            Console.ReadLine();
        }
    }
}
