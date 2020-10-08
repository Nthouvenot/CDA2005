using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryLepidoptere
{
    public class Papillon : StadeDEvolution
    {
        public override bool SeDeplacer()
        {
            Console.WriteLine("Je vole");
            return true;
        }

        /// <summary>
        /// override method abstract SeMetamorphoser
        /// </summary>
        /// <returns>StadeDEvolution</returns>
        public override StadeDEvolution SeMetamorphoser()
        {
            return this;
        }
    }
}