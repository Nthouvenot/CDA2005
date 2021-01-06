using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPersistanceMetier
{
    public struct SdemandeurDEmploiDiplome
    {
        public int id_diplome;
        public int id_demandeurEmploi;
        public string dateObtention;   
    }

    public struct SdemandeurDEmploi
    {
        public long numeroSecuriteSocial;
        public string nom;
        public string prenom;
        public DateTime dateDInscription;
    }
}
