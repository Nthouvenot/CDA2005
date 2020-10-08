using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLepidoptere
{
    public class Lepidoptere
    {
        private bool StadeDEvolutionMax;
        private StadeDEvolution monStadeCourant;
        private DateTime dateDeNaissance;

        /// <summary>
        /// Lepidoptere constructor accept one DateTime parameter
        /// </summary>
        /// <param name="_dateDeNaissance"></param>
        public Lepidoptere(DateTime _dateDeNaissance)
        {
            if(_dateDeNaissance <= DateTime.Now)
            {

                this.dateDeNaissance = _dateDeNaissance;
                this.monStadeCourant = (StadeDEvolution)new Oeuf();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool SeDeplacer()
        {
            if(this.monStadeCourant.SeDeplacer())
            {
                return true;
            }
            if (this.monStadeCourant.GetType() == typeof(Oeuf))
            {
                Console.WriteLine("Je suis un oeuf je ne me déplace pas");
                return false;
            }
            if (this.monStadeCourant.GetType() == typeof(Chrysalide))
            {
                Console.WriteLine("Je suis une Chrysalide je ne me déplace pas");
                return false;
            }
            return false;

        }
          
        public void SeMetamorphoser()
        {
            this.monStadeCourant = this.monStadeCourant.SeMetamorphoser();
            if (StadeDEvolutionMax == true)
            {
                Console.WriteLine("Je suis déja un papillon je ne peu plus évoluer !!!");
                return;
            }
            if (this.monStadeCourant.GetType() == typeof(Chenille))
            {
                Console.WriteLine("J'évolue en chenille");
                return;
            }
            if (this.monStadeCourant.GetType() == typeof(Chrysalide))
            {
                Console.WriteLine("J'évolue en chrysalide");
                return;
            }
            if (this.monStadeCourant.GetType() == typeof(Papillon))
            {
                Console.WriteLine("J'évolue en Papillon");
                StadeDEvolutionMax = true;
                return;
            }
        }
    }
}
