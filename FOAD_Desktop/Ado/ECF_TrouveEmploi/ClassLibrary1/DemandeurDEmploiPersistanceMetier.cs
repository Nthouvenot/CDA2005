using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPersistanceMetier
{
    public struct SDemandeurDEmploiDiplome
    {
        public int id_diplome;
        public int id_demandeurEmploi;
        public string dateObtention;
        
        
    }

    public struct SDemandeurDEmploi
    {
        public long numeroSecuriteSocial;
        public string nom;
        public string prenom;
        public DateTime dateDInscription;
    }
}
