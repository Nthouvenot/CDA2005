using ClassLibraryPapyrus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Papyrus
{
    public partial class PrintUpdateDeleteSupplierDataWindow : Form
    {
        SqlConnection dbConnection;
        SqlConnectionStringBuilder connectionBuilder;
        SqlCommand command;
        SqlDataReader dataReader;
        public PrintUpdateDeleteSupplierDataWindow()
        {
            InitializeComponent();
            buttonSearch.Enabled = false;
            this.connectionBuilder = new SqlConnectionStringBuilder(ConfigurationManager.ConnectionStrings["PapyrusDB"].ToString());
            this.dbConnection = new SqlConnection();
            this.dbConnection.ConnectionString = connectionBuilder.ConnectionString;
            this.command = new SqlCommand();
            this.command.Connection = dbConnection;
            try
            {
                this.dbConnection.Open();
            }
            catch (SqlException sqlError)
            {
                MessageBox.Show(sqlError.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.dbConnection.Close();
            }
        }

        private bool CheckValidEntries()
        {
            if (!CheckTools.CheckSuplierString(textBoxSuplierName.Text))
            {
                return false;
            }
            else if (!CheckTools.CheckSuplierAdress(textBoxSuplierAdress.Text))
            {
                return false;
            }
            else if (!CheckTools.CheckZipCode(textBoxSuplierZipCode.Text))
            {
                return false;
            }
            else if (!CheckTools.CheckSuplierdCityName(textBoxSuplierCity.Text))
            {
                return false;
            }
            else if (!CheckTools.CheckSuplierString(textBoxSuplierContact.Text))
            {
                return false;
            }
            else if (!CheckTools.CheckSuplierSatisfaction(textBoxSuplierSatisfaction.Text))
            {
                return false;
            }
            return true;
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlParameter parameter = this.command.CreateParameter();
                parameter.SqlDbType = SqlDbType.Int;
                parameter.Direction = ParameterDirection.Input;
                parameter.ParameterName = "@suplier_code";
                parameter.Value = Int32.Parse(textBoxSuplierNumber.Text);
                this.command = new SqlCommand();
                this.command.Connection = dbConnection;
                this.command.CommandType = CommandType.Text;
                this.command.CommandText = "SELECT * FROM Fournisseurs WHERE NUMERO_FOURNISSEUR = @suplier_code";
                this.command.Parameters.Add(parameter);
                this.dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    textBoxSuplierName.Text = dataReader.GetString(1);
                    textBoxSuplierAdress.Text = dataReader.GetValue(2).ToString() + " " + dataReader.GetValue(3).ToString();
                    textBoxSuplierZipCode.Text = dataReader.GetValue(4).ToString();
                    textBoxSuplierCity.Text = dataReader.GetString(5);
                    textBoxSuplierContact.Text = dataReader.GetString(6);
                    textBoxSuplierSatisfaction.Text = dataReader.GetValue(7).ToString();
                }
                else
                {
                    MessageBox.Show("Erreur le fournisseur est inconnu", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dataReader.Close();

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.dataReader.Close();
                this.dbConnection.Close();
            }
        }


        private void ButtonNew_Click(object sender, EventArgs e)
        {
            textBoxSuplierNumber.Clear();
            textBoxSuplierName.Clear();
            textBoxSuplierAdress.Clear();
            textBoxSuplierZipCode.Clear();
            textBoxSuplierCity.Clear();
            textBoxSuplierContact.Clear();
            textBoxSuplierSatisfaction.Clear();
        }

        private void PrintUpdateDeleteSupplierDataWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.dbConnection.State == ConnectionState.Open)
            {
                this.dbConnection.Close();
            }
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (!this.CheckValidEntries())
            {
                MessageBox.Show("Veuillez entrez des données valide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string[] splitedAdress = textBoxSuplierAdress.Text.Split(' ');
            string street = textBoxSuplierAdress.Text.Substring(splitedAdress[0].Length + 1, textBoxSuplierAdress.Text.Length - (splitedAdress[0].Length + 1));
            string sqlCommandText = " ";
            bool update = false;
            SqlParameter parameterName = this.command.CreateParameter();
            SqlParameter parameterStreetNumber = this.command.CreateParameter();
            SqlParameter parameterStreet = this.command.CreateParameter();
            SqlParameter parameterZipCode = this.command.CreateParameter();
            SqlParameter parameterCity = this.command.CreateParameter();
            SqlParameter parameterContact = this.command.CreateParameter();
            SqlParameter parameterSatisfaction = this.command.CreateParameter();
            SqlParameter parameterId = this.command.CreateParameter();
            //parameter number of the suplier
            parameterId.SqlDbType = SqlDbType.Int;
            parameterId.Direction = ParameterDirection.Input;
            parameterId.ParameterName = "@id_fournisseur";
            //parameter name of the suplier
            parameterName.SqlDbType = SqlDbType.NVarChar;
            parameterName.Direction = ParameterDirection.Input;
            parameterName.ParameterName = "@name";
            parameterName.Value = textBoxSuplierName.Text;
            //parameter street number of the suplier
            parameterStreetNumber.SqlDbType = SqlDbType.Int;
            parameterStreetNumber.Direction = ParameterDirection.Input;
            parameterStreetNumber.ParameterName = "@street_number";
            parameterStreetNumber.Value = Int32.Parse(splitedAdress[0]);
            //parameter street of the suplier
            parameterStreet.SqlDbType = SqlDbType.NVarChar;
            parameterStreet.Direction = ParameterDirection.Input;
            parameterStreet.ParameterName = "@street";
            parameterStreet.Value = street;
            //parameter city zip code of the suplier
            parameterZipCode.SqlDbType = SqlDbType.Int;
            parameterZipCode.Direction = ParameterDirection.Input;
            parameterZipCode.ParameterName = "@zip_code";
            parameterZipCode.Value = Int32.Parse(textBoxSuplierZipCode.Text);
            //parameter city name of the suplier
            parameterCity.SqlDbType = SqlDbType.NVarChar;
            parameterCity.Direction = ParameterDirection.Input;
            parameterCity.ParameterName = "@city";
            parameterCity.Value = textBoxSuplierCity.Text;
            //parameter contat name of the suplier
            parameterContact.SqlDbType = SqlDbType.NVarChar;
            parameterContact.Direction = ParameterDirection.Input;
            parameterContact.ParameterName = "@contact";
            parameterContact.Value = textBoxSuplierContact.Text;
            //parameter satisfaction about the suplier
            parameterSatisfaction.SqlDbType = SqlDbType.Int;
            parameterSatisfaction.Direction = ParameterDirection.Input;
            parameterSatisfaction.ParameterName = "@satisfaction";
            parameterSatisfaction.Value = Int32.Parse(textBoxSuplierSatisfaction.Text);

            //search other occurency of the suplier
            try
            {
                this.command = new SqlCommand();
                this.command.Connection = dbConnection;
                this.command.CommandType = CommandType.Text;
                this.command.CommandText = "SELECT * FROM Fournisseurs WHERE NOM_FOURNISSEUR = @name";
                this.command.Parameters.Add(parameterName);
                this.dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    update = true;
                    parameterId.Value = dataReader.GetInt32(0);
                    sqlCommandText = "UPDATE Fournisseurs SET NOM_FOURNISSEUR = @name, NUMERO_RUE_FOURNISSEUR = @street_number, RUE_FOURNISSEUR = @street, CODE_POSTAL_FOURNISSEUR = @zip_code, VILLE_FOURNISSEUR = @city, CONTACT_FOURNISSEUR = @contact, SATISFACTION_FOURNISSEUR = @satisfaction WHERE NUMERO_FOURNISSEUR = @id_fournisseur;";
                }
                else
                {
                    sqlCommandText = "INSERT INTO Fournisseurs(NOM_FOURNISSEUR, NUMERO_RUE_FOURNISSEUR, RUE_FOURNISSEUR, CODE_POSTAL_FOURNISSEUR, VILLE_FOURNISSEUR, CONTACT_FOURNISSEUR, SATISFACTION_FOURNISSEUR) VALUES (@name, @street_number, @street, @zip_code, @city, @contact, @satisfaction);";
                }
                dataReader.Close();
                this.command.Parameters.Clear();
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.dbConnection.Close();
                return;
            }
            //insert data or update
            try
            {
                this.command = new SqlCommand();
                this.command.Connection = dbConnection;
                this.command.CommandType = CommandType.Text;
                this.command.CommandText = sqlCommandText;
                this.command.Parameters.Add(parameterName);
                this.command.Parameters.Add(parameterStreetNumber);
                this.command.Parameters.Add(parameterStreet);
                this.command.Parameters.Add(parameterZipCode);
                this.command.Parameters.Add(parameterCity);
                this.command.Parameters.Add(parameterContact);
                this.command.Parameters.Add(parameterSatisfaction);
                if (update)
                {
                    this.command.Parameters.Add(parameterId);
                }
                this.command.ExecuteNonQuery();
                // show message box update or insert success
                if (update)
                {
                    MessageBox.Show("Mise a jour réussie", "succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Insertion réussie", "succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.command.Parameters.Clear();
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.dataReader.Close();
            }
        }

        private void TextBoxSuplierCode_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSuplierNumber.Text.Length == 0)
            {
                errorProviderFournisseur.Clear();
                this.buttonSearch.Enabled = false;
            }
            else if (!CheckTools.CheckSuplierCode(textBoxSuplierNumber.Text))
            {
                errorProviderFournisseur.SetError(textBoxSuplierNumber, "le code fournisseur est composé de 1 a 10 chiffres");
                buttonSearch.Enabled = false;
            }
            else
            {
                errorProviderFournisseur.Clear();
                buttonSearch.Enabled = true;
            }
        }

        private void TextBoxSuplier_TextChanged(object sender, EventArgs e)
        {
            TextBox currentTextBox = (TextBox)sender;
            switch (currentTextBox.Name)
            {
                case "textBoxSuplierName":
                    {
                        if (!CheckTools.CheckSuplierString(currentTextBox.Text) && currentTextBox.Text.Length != 0)
                        {
                            errorProviderName.SetError(textBoxSuplierName, "le nom de fournisseur est composé de 1 a 50 lettres");
                        }
                        else
                        {
                            errorProviderName.Clear();
                        }
                        break;
                    }
                case "textBoxSuplierAdress":
                    {
                        if (!CheckTools.CheckSuplierAdress(currentTextBox.Text) && currentTextBox.Text.Length != 0)
                        {
                            errorProviderAdress.SetError(textBoxSuplierAdress, "l'adresse de fournisseur est composé de 1 a 3 chifrre suivi d'un espace et de 3 a 47 lettres");
                        }
                        else
                        {
                            errorProviderAdress.Clear();
                        }
                        break;
                    }
                case "textBoxSuplierZipCode":
                    {
                        if (!CheckTools.CheckZipCode(currentTextBox.Text) && currentTextBox.Text.Length != 0)
                        {
                            errorProviderCpCity.SetError(textBoxSuplierZipCode, "le code postal est composé de 5 chiffre positif est inférieur a 96000");
                        }
                        else
                        {
                            errorProviderCpCity.Clear();
                        }
                        break;
                    }
                case "textBoxSuplierCity":
                    {
                        if (!CheckTools.CheckSuplierdCityName(currentTextBox.Text) && currentTextBox.Text.Length != 0)
                        {
                            errorProviderCity.SetError(textBoxSuplierCity, "Un nom de ville est composé de caractéres");
                        }
                        else
                        {
                            errorProviderCity.Clear();
                        }
                        break;
                    }
                case "textBoxSuplierContact":
                    {
                        if (!CheckTools.CheckSuplierString(currentTextBox.Text) && currentTextBox.Text.Length != 0)
                        {
                            errorProviderContact.SetError(textBoxSuplierContact, "le nom de contact est composé de 1 a 50 caractéres");
                        }
                        else
                        {
                            errorProviderContact.Clear();
                        }
                        break;
                    }
                case "textBoxSuplierSatisfaction":
                    if (!CheckTools.CheckSuplierSatisfaction(currentTextBox.Text) && currentTextBox.Text.Length != 0)
                    {
                        errorProviderSatisfaction.SetError(textBoxSuplierSatisfaction, "La satisfaction contient 1 chiffre de 0 a 10");
                    }
                    else
                    {
                        errorProviderSatisfaction.Clear();
                    }
                    break;
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            SqlParameter parameterId = this.command.CreateParameter();
            int id = 0;
            int affectedRowNumber = 0;
            Int32.TryParse(textBoxSuplierNumber.Text, out id);
            //parameter number of the id suplier
            parameterId.SqlDbType = SqlDbType.Int;
            parameterId.Direction = ParameterDirection.Input;
            parameterId.ParameterName = "@id_suplier";
            parameterId.Value = id;
            //Delete the row
            try
            {
                this.command = new SqlCommand();
                this.command.Connection = dbConnection;
                this.command.CommandType = CommandType.Text;
                this.command.CommandText = "DELETE FROM Fournisseurs WHERE NUMERO_FOURNISSEUR = @id_suplier";
                this.command.Parameters.Add(parameterId);
                affectedRowNumber = this.command.ExecuteNonQuery();
                if (affectedRowNumber == 1)
                {
                    MessageBox.Show("Fournisseur supprimé", "succés", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Fournisseur inconnu", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.command.Parameters.Clear();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.dbConnection.Close();
                return;
            }
        }
    }
}
