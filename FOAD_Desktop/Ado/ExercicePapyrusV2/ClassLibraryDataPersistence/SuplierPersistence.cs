using ClassLibraryDomainPersistence;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDataPersistence
{
    public class SuplierPersistence : ISuplierPersistence
    {
        private SqlConnection sqlConnection;
        private SqlConnectionStringBuilder connectionBuilder;

        private void OpenConnection()
        {
            try
            {
                if (this.sqlConnection.State != ConnectionState.Open)
                {
                    this.sqlConnection.Open();
                }
            }
            catch (SqlException sqlException)
            {
                Trace.TraceInformation(DateTime.Now + " " + sqlException.Message);
                Trace.Flush();
                this.sqlConnection.Close();
            }
        }

        public SuplierPersistence(object connection)
        {
            string connectionString = (string)connection;
            this.connectionBuilder = new SqlConnectionStringBuilder();
            this.sqlConnection = new SqlConnection();
            this.sqlConnection.ConnectionString = connectionString;
            this.OpenConnection();
        }

        private void InitializationParameters(SuplierStructure suplierStructure, SqlCommand command)
        {
            SqlParameter parameterName = command.CreateParameter();
            SqlParameter parameterStreetNumber = command.CreateParameter();
            SqlParameter parameterStreet = command.CreateParameter();
            SqlParameter parameterZipCode = command.CreateParameter();
            SqlParameter parameterCity = command.CreateParameter();
            SqlParameter parameterContact = command.CreateParameter();
            SqlParameter parameterSatisfaction = command.CreateParameter();
            parameterName.SqlDbType = SqlDbType.NVarChar;
            parameterName.Direction = ParameterDirection.Input;
            parameterName.ParameterName = "@name";
            parameterName.Value = suplierStructure.name;
            //parameter street number of the suplier
            parameterStreetNumber.SqlDbType = SqlDbType.Int;
            parameterStreetNumber.Direction = ParameterDirection.Input;
            parameterStreetNumber.ParameterName = "@street_number";
            parameterStreetNumber.Value = suplierStructure.streetNumber;
            //parameter street of the suplier
            parameterStreet.SqlDbType = SqlDbType.NVarChar;
            parameterStreet.Direction = ParameterDirection.Input;
            parameterStreet.ParameterName = "@street";
            parameterStreet.Value = suplierStructure.streetName;
            //parameter city zip code of the suplier
            parameterZipCode.SqlDbType = SqlDbType.Int;
            parameterZipCode.Direction = ParameterDirection.Input;
            parameterZipCode.ParameterName = "@zip_code";
            parameterZipCode.Value = suplierStructure.zipCode;
            //parameter city name of the suplier
            parameterCity.SqlDbType = SqlDbType.NVarChar;
            parameterCity.Direction = ParameterDirection.Input;
            parameterCity.ParameterName = "@city";
            parameterCity.Value = suplierStructure.cityName;
            //parameter contat name of the suplier
            parameterContact.SqlDbType = SqlDbType.NVarChar;
            parameterContact.Direction = ParameterDirection.Input;
            parameterContact.ParameterName = "@contact";
            parameterContact.Value = suplierStructure.contact;
            //parameter satisfaction about the suplier
            parameterSatisfaction.SqlDbType = SqlDbType.Int;
            parameterSatisfaction.Direction = ParameterDirection.Input;
            parameterSatisfaction.ParameterName = "@satisfaction";
            parameterSatisfaction.Value = suplierStructure.satisfaction;
            //command adding paramater
            command.Parameters.Add(parameterName);
            command.Parameters.Add(parameterStreetNumber);
            command.Parameters.Add(parameterStreet);
            command.Parameters.Add(parameterZipCode);
            command.Parameters.Add(parameterCity);
            command.Parameters.Add(parameterContact);
            command.Parameters.Add(parameterSatisfaction);
        }

        public int CreateSuplier(SuplierStructure suplierStructure)
        {
            this.OpenConnection();
            int sqlCommandReturn = 0;
            int suplierId = 0;
            SqlCommand command = new SqlCommand();
            SqlParameter parameterId = command.CreateParameter();
            //parameter number of the suplier
            parameterId.SqlDbType = SqlDbType.Int;
            parameterId.Direction = ParameterDirection.Output;
            parameterId.ParameterName = "@id_suplier";
            command.Connection = this.sqlConnection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "WriteSuplierTable";
            command.Parameters.Add(parameterId);
            this.InitializationParameters(suplierStructure, command);
            try
            {
                sqlCommandReturn = command.ExecuteNonQuery();
            }
            catch (SqlException sqlException)
            {
                Trace.TraceInformation(DateTime.Now + " " + sqlException.Message);
                Trace.Flush();
                suplierId = -1;
            }
            finally
            {
                command.Parameters.Clear();
                this.sqlConnection.Close();
            }
            //check the number of affected rows
            if (sqlCommandReturn != 1)
            {
                suplierId = -1;
            }
            else
            {
                suplierId = (int)parameterId.Value;
            }
            return suplierId;
        }

        /// <summary>
        /// Read one row of the Supliers table, return the data if the operation successful else return id = -1
        /// </summary>
        /// <param name="idSuplier"></param>
        /// <returns></returns>
        public SuplierStructure ReadOneSuplierById(int idSuplier)
        {
            if (idSuplier < 0)
            {
                SuplierStructure suplierStruture = new SuplierStructure();
                suplierStruture.id = -1;
                return suplierStruture;
            }
            this.OpenConnection();

            int numberOfRows = 0;
            SqlCommand sqlcommand = new SqlCommand();
            SqlParameter parameterId = sqlcommand.CreateParameter();
            //parameter number of the suplier
            parameterId.SqlDbType = SqlDbType.Int;
            parameterId.Direction = ParameterDirection.Input;
            parameterId.ParameterName = "@id_suplier";
            parameterId.Value = idSuplier;
            //connection  and read the data
            sqlcommand.Parameters.Add(parameterId);
            SuplierStructure persistence = new SuplierStructure();
            try
            {
                sqlcommand.Connection = this.sqlConnection;
                sqlcommand.CommandText = "SELECT* FROM Fournisseurs WHERE NUMERO_FOURNISSEUR = @id_suplier;";
                SqlDataReader dataReader = sqlcommand.ExecuteReader();
                while (dataReader.Read())
                {
                    numberOfRows++;
                    persistence.id = dataReader.GetInt32(0);
                    persistence.name = dataReader.GetString(1);
                    persistence.streetNumber = dataReader.GetByte(2);
                    persistence.streetName = dataReader.GetString(3);
                    persistence.zipCode = dataReader.GetInt32(4);
                    persistence.cityName = dataReader.GetString(5);
                    if (dataReader.GetValue(6) is string)
                    {
                        persistence.contact = dataReader.GetString(6);
                    }
                    else
                    {
                        persistence.contact = " ";
                    }
                    if (dataReader.GetValue(6) is int)
                    {
                        persistence.satisfaction = (int)dataReader.GetValue(6);
                    }
                    else
                    {
                        persistence.satisfaction = -1;
                    }
                }
                dataReader.Close();
            }
            catch (SqlException sqlException)
            {
                Trace.TraceInformation(DateTime.Now + " " + sqlException.Message);
                Trace.Flush();
            }
            finally
            {
                this.sqlConnection.Close();
            }
            //check the number of affected rows
            if (numberOfRows != 1)
            {
                persistence.id = -1;
            }
            return persistence;
        }

        /// <summary>
        /// Update a row in the Supliers table, return true if the operation is sucessful
        /// </summary>
        /// <param name="suplierStructure"></param>
        /// <returns></returns>
        public bool UpdateSuplier(SuplierStructure suplierStructure)
        {
            this.OpenConnection();
            int sqlCommandReturn = 0;
            SqlCommand command = new SqlCommand();
            SqlParameter parameterId = command.CreateParameter();
            //parameter number of the suplier
            parameterId.SqlDbType = SqlDbType.Int;
            parameterId.Direction = ParameterDirection.Input;
            parameterId.ParameterName = "@id_suplier";
            parameterId.Value = suplierStructure.id;
            //connection  and write the data
            command.Connection = this.sqlConnection;
            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE Fournisseurs SET NOM_FOURNISSEUR = @name, NUMERO_RUE_FOURNISSEUR = @street_number, RUE_FOURNISSEUR = @street, CODE_POSTAL_FOURNISSEUR = @zip_code, VILLE_FOURNISSEUR = @city, CONTACT_FOURNISSEUR = @contact, SATISFACTION_FOURNISSEUR = @satisfaction WHERE NUMERO_FOURNISSEUR = @id_suplier;";
            this.InitializationParameters(suplierStructure, command);
            try
            {
                sqlCommandReturn = command.ExecuteNonQuery();
            }
            catch (SqlException sqlException)
            {
                Trace.TraceInformation(DateTime.Now + " " + sqlException.Message);
                Trace.Flush();
                sqlCommandReturn = -1;
            }
            finally
            {
                command.Parameters.Clear();
                this.sqlConnection.Close();
            }
            //check the number of affected rows
            if (sqlCommandReturn != 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Delete a row in the Supliers table, return true if the operation is sucessful
        /// </summary>
        /// <param name="idSuplier"></param>
        /// <returns></returns>
        public bool DeleteSuplierById(int idSuplier)
        {
            if (idSuplier < 0)
            {
                return false;
            }
            this.OpenConnection();
            int sqlCommandReturn = 0;
            SqlCommand sqlCommand = new SqlCommand();
            SqlParameter parameterId = sqlCommand.CreateParameter();
            //parameter number of the suplier
            parameterId.SqlDbType = SqlDbType.Int;
            parameterId.Direction = ParameterDirection.Input;
            parameterId.ParameterName = "@id_suplier";
            parameterId.Value = idSuplier;
            //connection  and delete a row
            sqlCommand.Connection = this.sqlConnection;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "DELETE FROM Fournisseurs WHERE NUMERO_FOURNISSEUR = @id_suplier;";
            try
            {
                sqlCommandReturn = sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException sqlException)
            {
                Trace.TraceInformation(DateTime.Now + " " + sqlException.Message);
                Trace.Flush();
            }
            finally
            {
                this.sqlConnection.Close();
            }
            //check the number of affected rows
            if (sqlCommandReturn != 1)
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
