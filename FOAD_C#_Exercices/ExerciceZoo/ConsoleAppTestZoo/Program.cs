using ClassLibraryZoo.Animaux;
using ClassLibraryZoo.Employes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool secoursAppelle = false;
            List<AnimalDuZoo> mesAnimauxDuZoo = new List<AnimalDuZoo>();
            mesAnimauxDuZoo.Add(new Lapin());
            mesAnimauxDuZoo.Add(new Lapin());
            mesAnimauxDuZoo.Add(new Lion());
            mesAnimauxDuZoo.Add(new Perroquet());
            List<EmployeesDuZoo> mesEmployeesDuZoo = new List<EmployeesDuZoo>();
            mesEmployeesDuZoo.Add(new Gardien(DateTime.Now, false));
            mesEmployeesDuZoo.Add(new Gardien(DateTime.Now, false));

            //il faut mettre un peu d'ordre dans l'evacuation...du plus vieux au plus jeune
            mesAnimauxDuZoo.Sort();

            //le feu arrive, il faut deplacer tout le monde
            Console.WriteLine("Au feu, au feu, il y a le zoo qui crame !!!");
            foreach (AnimalDuZoo animal in mesAnimauxDuZoo)
            {
                animal.SeDeplacer();
            }

            //mais que fait le gardien? il reste sur place?
            foreach (EmployeesDuZoo employe in mesEmployeesDuZoo)
            {
                employe.SeDeplacer();
            }

            //et qui va appeller les secours? 
            foreach (EmployeesDuZoo employe in mesEmployeesDuZoo)
            {
                if (employe.EstEnPoste && !secoursAppelle)
                {
                    employe.AppellerSecours();
                    secoursAppelle = true;
                }
                else
                {
                    secoursAppelle = false;
                }
            }
            if (!secoursAppelle)
            {
                Perroquet p = (Perroquet)mesAnimauxDuZoo.Find(animal => animal.GetType() == typeof(Perroquet)); //
                p.AppellerSecours();
            }

            Console.ReadLine();
        }
    }
}
