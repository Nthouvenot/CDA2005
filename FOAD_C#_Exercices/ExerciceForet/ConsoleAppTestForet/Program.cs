using ClassLibraryForet;
using System;
using System.Collections.Generic;

namespace ConsoleAppTestForet
{
    class Program
    {
        static void Main(string[] args)
        {
            // creer un arbre du printemps
            Arbre arbreDuPrintemps = new Arbre(3);
            Feuille feuille1ArbreDuPrintemps = new Feuille(6, EnumFormeFeuille.ovale);
            Feuille feuille2ArbreDuPrintemps = new Feuille(6, EnumFormeFeuille.ovale);
            Feuille feuille3ArbreDuPrintemps = new Feuille(6, EnumFormeFeuille.ovale);
            Feuille feuille4ArbreDuPrintemps = new Feuille(6, EnumFormeFeuille.ovale);
            Feuille feuille5ArbreDuPrintemps = new Feuille(6, EnumFormeFeuille.ovale);
            Feuille feuille6ArbreDuPrintemps = new Feuille(6, EnumFormeFeuille.ovale);
            arbreDuPrintemps.AddFeuille(feuille1ArbreDuPrintemps);
            arbreDuPrintemps.AddFeuille(feuille2ArbreDuPrintemps);
            arbreDuPrintemps.AddFeuille(feuille3ArbreDuPrintemps);
            arbreDuPrintemps.AddFeuille(feuille4ArbreDuPrintemps);
            arbreDuPrintemps.AddFeuille(feuille5ArbreDuPrintemps);
            arbreDuPrintemps.AddFeuille(feuille6ArbreDuPrintemps);

            //afficher l'etat de l'arbre avec un ToString
            Console.WriteLine(arbreDuPrintemps.ToString());
            //ajouter un comportement passer en automne (feuille jaune ou rouge)
            arbreDuPrintemps.PasserEnAutomne();
            //afficher l'état de l'arbre
            Console.WriteLine(arbreDuPrintemps.ToString());
        }
    }
}
