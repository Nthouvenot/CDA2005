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

        private static void AlerteTemperature(Temperature sender)
        {
            string message = "Alerte j'ai " + sender.TemperatureCourante;
            if (sender.TemperatureCourante == 36.2f)
            {
                Console.WriteLine(message + " temperature trop basse");

            }
            else if(sender.TemperatureCourante == 42f)
            {
                Console.WriteLine(message + " temperature trop haute");
            }
           
        }
        

        static void Main(string[] args)
        {
            //declencher rdv chez le medecin si l'evenement Fievre arrive
            Temperature temperatureHumaine = new Temperature();
            temperatureHumaine.Fievre += JaiDeLaFievre;

            temperatureHumaine.Monter(37); //pas de Fievre
            Console.WriteLine("j'ai " + temperatureHumaine.TemperatureCourante);
            temperatureHumaine.Monter(38.5f); //l'evenement Fievre se declenche
            Console.WriteLine("j'ai " + temperatureHumaine.TemperatureCourante + "\n");

            float[] alertes = { 36.2f, 42 };
            //declencher alerte 42
            Temperature temperatureHumaine2 = new Temperature(alertes);
            temperatureHumaine2.Alerte += AlerteTemperature;
            temperatureHumaine2.Monter(37); //tout va bien
            Console.WriteLine("j'ai " + temperatureHumaine2.TemperatureCourante);
            temperatureHumaine2.Monter(42); //Alerte grande Fievre
            Console.WriteLine("j'ai " + temperatureHumaine2.TemperatureCourante + "\n");

            //declencher alerte 36.2
            Temperature temperatureHumaine3 = new Temperature(alertes);
            temperatureHumaine3.Alerte += AlerteTemperature;
            temperatureHumaine3.Monter(37); //tout va bien
            Console.WriteLine("j'ai " + temperatureHumaine3.TemperatureCourante);
            temperatureHumaine3.Diminuer(36.2f); //Alerte trop froid
            Console.WriteLine("j'ai " + temperatureHumaine3.TemperatureCourante);
            Console.ReadLine(); //On fait une pause pour le resultat de l'application
        }

        
    }
}
