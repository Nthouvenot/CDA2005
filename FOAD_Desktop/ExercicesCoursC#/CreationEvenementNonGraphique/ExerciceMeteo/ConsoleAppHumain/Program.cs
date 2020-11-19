using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTemp;

namespace ConsoleAppHumain
{
    class Program
    {
        /// <summary>
        /// Methode pour l'evenement Fievre
        /// </summary>
        /// <param name="sender"></param>
        private static void JaiDeLaFievre(Temperature sender)
        {
            Console.WriteLine("Aie Aie Aie j'ai de la fiévre, j'ai " + sender.TemperatureCourante);
        }

        

        static void Main(string[] args)
        {
            //declencher rdv chez le medecin si l'evenement Fievre arrive
            Temperature temperatureHumaine = new Temperature();
            temperatureHumaine.Fievre += JaiDeLaFievre;

            temperatureHumaine.Monter(37); //pas de Fievre
            Console.WriteLine("j'ai " + temperatureHumaine.TemperatureCourante);
            temperatureHumaine.Monter(38.5f); //l'evenement Fievre se declenche
            Console.WriteLine("j'ai " + temperatureHumaine.TemperatureCourante);
            Console.ReadLine(); //On fait une pause pour le resultat de l'application
        }

        
    }
}
