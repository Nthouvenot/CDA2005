using ClassLibraryZoo.Contrats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryZoo.Animaux
{
    public class Lapin : AnimalDuZoo
    {
        int lgOreilleEnCm;

        public Lapin():base()
        {
            this.lgOreilleEnCm = 10;
        }

        public int LgOreilleEnCm 
        {
            get => this.lgOreilleEnCm;
            set
            {
                if(value > 20)
                {
                    return;
                }
                this.lgOreilleEnCm = value;
            }
        }

        public void Manger()
        {
            Console.WriteLine("Je mange des carrotes");
            return;
        }

        public override bool SeDeplacer()
        {
            Console.WriteLine("Je saute");
            return true;
        }
    }
}
