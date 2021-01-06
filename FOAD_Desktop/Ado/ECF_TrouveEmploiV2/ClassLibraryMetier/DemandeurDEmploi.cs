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

        public Dictionary<DateTime, EnumDiplomes> Diplomes { 
            get => diplomes; 
            //set => diplomes = value;
        }

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

        public bool AddDemandeurEmploi()
        {
            bool retourSauvegarder = false;
            SdemandeurDEmploi demandeurDEmploiCourant = new SdemandeurDEmploi();
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
            foreach(KeyValuePair<DateTime, EnumDiplomes> keyValue in diplomes)
            {
                SdemandeurDEmploiDiplome demandeurDEmploiDiplomeCourant = new SdemandeurDEmploiDiplome();
                demandeurDEmploiDiplomeCourant.id_diplome = (int)keyValue.Value;
                demandeurDEmploiDiplomeCourant.id_demandeurEmploi = (int)this.numeroSecuriteSocial;
                demandeurDEmploiDiplomeCourant.dateObtention = keyValue.Key.ToString();
                PersistanceTrouveUnEmploi persistance = new PersistanceTrouveUnEmploi();
                retourSauvegarder = persistance.SauvegarderDiplome(demandeurDEmploiDiplomeCourant);
            }
            return retourSauvegarder;
        }
    }
}
