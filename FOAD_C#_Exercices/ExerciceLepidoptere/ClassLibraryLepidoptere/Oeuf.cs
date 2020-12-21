using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryLepidoptere
{
    public class Oeuf : StadeDEvolution
    {
        /// <summary>
        /// override method abstract SeDeplacer
        /// An egg does not move so always return false
        /// </summary>
        /// <returns></returns>
       public override bool SeDeplacer()
        {
            return false;
        }

        /// <summary>
        /// override method abstract SeMetamorphoser
        /// </summary>
        /// <returns>StadeDEvolution</returns>
        public override StadeDEvolution SeMetamorphoser()
        {
            Console.WriteLine("J'évolue en chenille");
            return (StadeDEvolution)new Chenille();
        }
    }
}