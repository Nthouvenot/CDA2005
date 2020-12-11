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
    public partial class PrintSupplierDataWindow : Form
    {
        SqlConnection dbConnection;
        SqlConnectionStringBuilder connectionBuilder;
        SqlCommand command;
        SqlDataReader dataReader;
        public PrintSupplierDataWindow(string suplierCode)
        {
            InitializeComponent();
            this.connectionBuilder = new SqlConnectionStringBuilder(ConfigurationManager.ConnectionStrings["PapyrusDB"].ToString());
            this.dbConnection = new SqlConnection();
            dbConnection.ConnectionString = this.connectionBuilder.ConnectionString;
            try
            {
                this.dbConnection.Open();
                this.command = new SqlCommand("SELECT * FROM Fournisseurs WHERE NUMERO_FOURNISSEUR = " + suplierCode + ";", dbConnection);
                this.dataReader = command.ExecuteReader();
                while(dataReader.Read())
                {
                    textBoxName.Text = dataReader.GetString(1);
                    textBoxAdress.Text = dataReader.GetByte(2).ToString() + " " + dataReader.GetString(3);
                    textBoxZipCode.Text = dataReader.GetInt32(4).ToString();
                    textBoxCity.Text = dataReader.GetString(5);
                    textBoxContact.Text = dataReader.GetString(6);
                    textBoxSatisfaction.Text = dataReader.GetInt32(7).ToString();
                }
               
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.dbConnection.Close();
            }
        }

        private void ButtonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
