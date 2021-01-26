using System;
using ClassLibraryTemp;

namespace ConsoleAppMeteo
{
    class Program
    {
        private static void IlVaGeler(Temperature sender)
        {
            Console.WriteLine("Il est temps de rentrer les legumes il va geler");
        }

        static void Main(string[] args)
        {
            // je m'interresse au fait que la temperature de gel est là, et que mon jardin risque de gelee..
            Temperature temperatureDehors = new Temperature();
            temperatureDehors.Gel += IlVaGeler;

            temperatureDehors.Diminuer(3); //Pas de risque de gel
            Console.WriteLine("Il fait " + temperatureDehors.TemperatureCourante);
            temperatureDehors.Diminuer(0); //l'evenement Gel se declenche
            Console.WriteLine("Il fait " + temperatureDehors.TemperatureCourante);
            Console.ReadLine(); //On fait une pause pour le resultat de l'application
        }
    }
}
