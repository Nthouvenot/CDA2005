using ClassLibraryPersistanceMetier;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPersistance
{
    public class PersistanceTrouveUnEmploi
    {
        private SqlConnection CommentRecupererConnexion()
        {
            try
            {
                SqlConnection connexion = new SqlConnection();
                connexion.ConnectionString = ConfigurationManager.ConnectionStrings["TrouveUnEmploi_BD"].ConnectionString;
                return connexion;
            }
            catch(SqlException sqlException)
            {
                Trace.WriteLine(DateTime.Now.ToString() + sqlException.Message);
            }
            return null;
        }

        public bool SauvegarderDemandeur(SDemandeurDEmploi demandeur)
        {
            SqlConnection connexion = this.CommentRecupererConnexion();
            if (connexion == null)
            {
                return false;
            }
            else if (connexion.State != ConnectionState.Open)
            {
                return false;
            }
            SqlCommand sqlCommande = new SqlCommand();
            sqlCommande.Connection = connexion;
            // creation des parametre pour la requete préparé
            //parametre numeroSecuriteSocialParameter
            SqlParameter numeroSecuriteSocialParameter = sqlCommande.CreateParameter();
            numeroSecuriteSocialParameter.SqlDbType = SqlDbType.BigInt;
            numeroSecuriteSocialParameter.Direction = ParameterDirection.Input;
            numeroSecuriteSocialParameter.ParameterName = "@numeroSecuriteSocial";
            numeroSecuriteSocialParameter.Value = demandeur.numeroSecuriteSocial;
            //parametre nomParameter
            SqlParameter nomParameter = sqlCommande.CreateParameter();
            nomParameter.SqlDbType = SqlDbType.VarChar;
            nomParameter.Direction = ParameterDirection.Input;
            nomParameter.ParameterName = "@nom";
            nomParameter.Value = demandeur.nom;
            //parametre prenomParameter
            SqlParameter prenomParameter = sqlCommande.CreateParameter();
            prenomParameter.SqlDbType = SqlDbType.VarChar;
            prenomParameter.Direction = ParameterDirection.Input;
            prenomParameter.ParameterName = "@prenom";
            prenomParameter.Value = demandeur.prenom;
            //parametre dateInscriptionParameter
            SqlParameter dateInscriptionParameter = sqlCommande.CreateParameter();
            dateInscriptionParameter.SqlDbType = SqlDbType.DateTime;
            dateInscriptionParameter.Direction = ParameterDirection.Input;
            dateInscriptionParameter.ParameterName = "@date_inscription";
            dateInscriptionParameter.Value = demandeur.dateDInscription;
            //preparation de la requete
            sqlCommande.CommandType = CommandType.StoredProcedure;
            sqlCommande.Parameters.Add(numeroSecuriteSocialParameter);
            sqlCommande.Parameters.Add(prenomParameter);
            sqlCommande.Parameters.Add(nomParameter);
            sqlCommande.CommandText = "INSERT INTO DEMANDEURDEMPLOIS(NumSecuriteSocial, Nom, Prenom, DateDinscription) VALUES(@numeroSecuriteSocial, @nom, @prenom, @date_inscription) ;";
            int nombreDeLigne = 0;
            try
            {
                nombreDeLigne = sqlCommande.ExecuteNonQuery();
            }
            catch (SqlException sqlException)
            {
                Trace.WriteLine(DateTime.Now.ToString() + sqlException.Message);
            }
            finally
            {
                sqlCommande.Parameters.Clear();
                connexion.Close();
            }
            if (nombreDeLigne != 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool SauvegarderDiplome(SDemandeurDEmploiDiplome demandeurDiplome)
        {
            SqlConnection connexion = this.CommentRecupererConnexion();
            if (connexion == null)
            {
                return false;
            }
            else if (connexion.State != ConnectionState.Open)
            {
                return false;
            }
            SqlCommand sqlCommande = new SqlCommand();
            sqlCommande.Connection = connexion;
            // creation des parametre pour la requete préparé
            //parametre numeroSecuriteSocialParameter
            SqlParameter idDemandeurParameter = sqlCommande.CreateParameter();
            idDemandeurParameter.SqlDbType = SqlDbType.BigInt;
            idDemandeurParameter.Direction = ParameterDirection.Input;
            idDemandeurParameter.ParameterName = "@id_demandeur";
            idDemandeurParameter.Value = demandeurDiplome.id_demandeurEmploi;
            //parametre nomParameter
            SqlParameter idDiplomeParameter = sqlCommande.CreateParameter();
            idDiplomeParameter.SqlDbType = SqlDbType.Int;
            idDiplomeParameter.Direction = ParameterDirection.Input;
            idDiplomeParameter.ParameterName = "@id_diplome";
            idDiplomeParameter.Value = demandeurDiplome.id_diplome;
            //parametre dateObtentionParameter
            SqlParameter intituleParameter = sqlCommande.CreateParameter();
            intituleParameter.SqlDbType = SqlDbType.VarChar;
            intituleParameter.Direction = ParameterDirection.Input;
            intituleParameter.ParameterName = "@intitule";
            intituleParameter.Value = demandeurDiplome.diplome;
            //preparation de la requete
            sqlCommande.CommandType = CommandType.StoredProcedure;
            sqlCommande.Parameters.Add(idDemandeurParameter);
            sqlCommande.Parameters.Add(idDiplomeParameter);
            sqlCommande.Parameters.Add(intituleParameter);
            sqlCommande.CommandText = "InsertDiplome";
            int nombreDeLigne = 0;
            try
            {
                nombreDeLigne = sqlCommande.ExecuteNonQuery();
            }
            catch (SqlException sqlException)
            {
                Trace.WriteLine(DateTime.Now.ToString() + sqlException.Message);
            }
            finally
            {
                sqlCommande.Parameters.Clear();
                connexion.Close();
            }
            if (nombreDeLigne != 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
