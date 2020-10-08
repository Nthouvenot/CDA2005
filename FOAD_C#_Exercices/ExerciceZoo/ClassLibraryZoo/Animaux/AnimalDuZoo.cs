using ClassLibraryZoo.Contrats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryZoo.Animaux
{
    public abstract class AnimalDuZoo : IDeplacable, IComparable, IComparable<AnimalDuZoo>
    {
        private DateTime dateDeNaissance;
        bool estNeeAuZoo;

        protected AnimalDuZoo():this(DateTime.Today,false)
        {
        }

        protected AnimalDuZoo(DateTime dateDeNaissance, bool estNeeAuZoo)
        {
            this.dateDeNaissance = dateDeNaissance;
            this.estNeeAuZoo = estNeeAuZoo;
        }

        public int CompareTo(object obj)
        {
            AnimalDuZoo animalDuZooAComparer = obj as AnimalDuZoo;
            if (animalDuZooAComparer == null)
            {
                throw new ArgumentNullException("Un paramétre était attendu;", "obj");
            }
            else
            {
                return this.dateDeNaissance.CompareTo(animalDuZooAComparer.dateDeNaissance);
            }
        }

        public int CompareTo(AnimalDuZoo animalDuZooAComparer)
        {
            return this.dateDeNaissance.CompareTo(animalDuZooAComparer.dateDeNaissance);
        }

        public abstract bool SeDeplacer();
    }
}
