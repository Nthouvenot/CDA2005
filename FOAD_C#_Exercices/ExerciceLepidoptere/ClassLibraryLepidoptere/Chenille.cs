﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryLepidoptere
{
    public class Chenille : StadeDEvolution
    {
        public override bool SeDeplacer()
        {
            Console.WriteLine("Je rampe");
            return true;
        }
        public override StadeDEvolution SeMetamorphoser()
        {
            return (StadeDEvolution)new Chrysalide();
        }
    }
}