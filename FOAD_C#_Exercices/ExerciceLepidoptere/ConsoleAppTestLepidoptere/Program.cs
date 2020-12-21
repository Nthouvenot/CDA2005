using ClassLibraryLepidoptere;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestLepidoptere
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime naissanceLepidoptere = new DateTime();
            Lepidoptere lepidoptere = new Lepidoptere(naissanceLepidoptere);
            lepidoptere.SeDeplacer();
            lepidoptere.SeMetamorphoser();
            lepidoptere.SeDeplacer();
            lepidoptere.SeMetamorphoser();
            lepidoptere.SeDeplacer();
            lepidoptere.SeMetamorphoser();
            lepidoptere.SeDeplacer();
            lepidoptere.SeMetamorphoser(); //déja un papillon
            lepidoptere.SeDeplacer();
            Console.ReadLine();
        }
    }
}
