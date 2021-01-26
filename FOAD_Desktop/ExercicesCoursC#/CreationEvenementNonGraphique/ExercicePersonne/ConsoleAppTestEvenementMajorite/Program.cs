using ClassLibraryPersonne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestEvenementMajorite
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne p = new Personne("Robert");
            Personne p2 = new Personne("Berthe");

            p.JeViensDEtreMajeur += P_JeViensDEtreMajeur;
            p2.JeViensDEtreMajeur += P_JeViensDEtreMajeur;


            p.JeSuisDansCriseQuarantaine += P_JeSuisDansCriseQuarantaine;
            p2.JeSuisDansCriseQuarantaine += P_JeSuisDansCriseQuarantaine;


            for (int i = 0; i < 100; i++)
            {
                p.VieillirDUnAn();
                p2.VieillirDUnAn();
            }

            Console.ReadLine(); //on fait une pause pour voir le resultat de l'application
        }


        private static void P_JeViensDEtreMajeur(Personne sender)
        {
            // sender.Age--;
            Console.WriteLine("Ca y est "+ sender.Name + " est majeur! Il peut se debrouiller par lui même");
        }

        private static void P_JeSuisDansCriseQuarantaine(Personne sender)
        {
            Console.WriteLine("Ca y est "+ sender.Name + " entre dans la crise de la quarantaine");
        }
    }
}
