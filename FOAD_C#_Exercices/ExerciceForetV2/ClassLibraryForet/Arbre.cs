using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForet
{
    public class Arbre : IList
    {
        int hauteur;
        private List<Feuille> feuilles;

        public List<Feuille> Feuilles
        {
            get => feuilles;
            //set => feuilles = value; 
        }

        public Arbre(int hauteur)
        {
            this.hauteur = hauteur;
            feuilles = new List<Feuille>();

        }

        public Arbre(int hauteur, List<Feuille> _feuilles) //ouvre porte aggregation
        {
            this.hauteur = hauteur;
            feuilles = _feuilles;
        }

        public int Hauteur
        {
            get => hauteur;
            //set => hauteur = value; 
        }

// Implementation des menbres de IList

        int IList.Add(object value)
        {
            throw new NotImplementedException();
        }

        bool IList.Contains(object value)
        {
            throw new NotImplementedException();
        }

        void IList.Clear()
        {
            throw new NotImplementedException();
        }

        int IList.IndexOf(object value)
        {
            throw new NotImplementedException();
        }

        void IList.Insert(int index, object value)
        {
            throw new NotImplementedException();
        }

        void IList.Remove(object value)
        {
            throw new NotImplementedException();
        }

        void IList.RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

 // Implementation de ICollection

        /// <summary>
        /// retransmet le Count de la collection de feuilles
        /// </summary>
        /// <returns></returns>
        public int Count {
            get
            {
                return this.feuilles.Count;
            }
        }

        public object SyncRoot => throw new NotImplementedException();

        public bool IsSynchronized => throw new NotImplementedException();

        bool IList.IsReadOnly => throw new NotImplementedException();

        bool IList.IsFixedSize => throw new NotImplementedException();

        /// <summary>
        /// Indexeur vers la collection de feuilles
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Object this[int index]
        {
            get => (Object)this.feuilles[index];
            set => this.feuilles[index] = (Feuille)value;
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            String resu = base.ToString() + " hauteur=" + hauteur;
            foreach (Feuille f in Feuilles)
            {
                resu = resu + "\n" + f.ToString();
            }
            return resu;
        }

// Implementation des methodes propre a la class
       
        public void AddFeuille(int nbNervure, EnumFormeFeuille formeFeuille, EnumCouleur couleurFeuille)
        {
            this.Feuilles.Add(new Feuille(nbNervure, couleurFeuille, formeFeuille));
        }

        public void PasserEnAutomne()
        {
            foreach (Feuille f in Feuilles)
            {
                f.PrendsTesCouleursDAutomne();
            }
        }
    }
}