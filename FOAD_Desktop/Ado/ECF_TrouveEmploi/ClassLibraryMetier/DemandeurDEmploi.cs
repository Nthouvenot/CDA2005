using ClassLibraryPersistance;
using ClassLibraryPersistanceMetier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMetier
{
    public class DemandeurDEmploi
    {
        private long numeroSecuriteSocial;
        private Dictionary<DateTime, EnumDiplomes> diplomes;
        private DateTime dateDInscription;
        private string nom;
        private string prenom;



        public DemandeurDEmploi(long numeroSecuriteSocial, DateTime dateDInscription, string nom, string prenom)
        {
            this.numeroSecuriteSocial = numeroSecuriteSocial;
            this.diplomes = new Dictionary<DateTime, EnumDiplomes>();
            this.dateDInscription = dateDInscription;
            this.nom = nom;
            this.prenom = prenom;
        }

        public DemandeurDEmploi() : this(100000000000000, DateTime.Now, "", "")
        {
        }

        //public bool AddDiplome(DateTime dateDObtentionDuDiplome,EnumDiplomes diplome)
        //{

        //}

        public bool AddDemandeurEmploi()
        {
            bool retourSauvegarder = false;
            SDemandeurDEmploi demandeurDEmploiCourant = new SDemandeurDEmploi();
            demandeurDEmploiCourant.numeroSecuriteSocial = this.numeroSecuriteSocial;
            demandeurDEmploiCourant.nom = this.nom;
            demandeurDEmploiCourant.prenom = this.prenom;
            demandeurDEmploiCourant.dateDInscription = this.dateDInscription;
            PersistanceTrouveUnEmploi persistance = new PersistanceTrouveUnEmploi();
            retourSauvegarder = persistance.SauvegarderDemandeur(demandeurDEmploiCourant);
            return retourSauvegarder;
        }

        public bool AddDiplomes()
        {
            bool retourSauvegarder = false;
            foreach(Dictionary<DateTime, EnumDiplomes>.Enumerator enumDictionnary in diplomes)
            {
                SDemandeurDEmploiDiplome demandeurDEmploiDiplome = new SDemandeurDEmploiDiplome();
                demandeurDEmploiDiplome.id_diplome = (int)enumDictionnary.Current.Value;
                demandeurDEmploiDiplome.id_demandeurEmploi = (int)this.numeroSecuriteSocial;
                demandeurDEmploiDiplome.dateObtention = enumDictionnary.Current.Key.ToString();
                PersistanceTrouveUnEmploi persistance = new PersistanceTrouveUnEmploi();
                retourSauvegarder = persistance.SauvegarderDemandeur(demandeurDEmploiDiplome);
            }
            return retourSauvegarder;
        }



    }
}
