using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Papyrus
{
    public partial class MainWindow : Form
    {
        private SqlConnection dbConnection;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            if(dbConnection.State == ConnectionState.Open)
            {
                dbConnection.Close();
            }
            this.Close();
        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            dbConnection = new SqlConnection();
            dbConnection.ConnectionString = "Data Source = " + textBoxServeurName.Text + "; Initial Catalog = " + textBoxDataBaseName.Text + "; Integrated Security = True; Pooling = False";
            try
            {
                dbConnection.Open();
                labelConnexionState.Text = "Etat de la connexion : " + dbConnection.State.ToString();
            }
            catch(Exception error)
            {
                labelConnexionState.Text = "Etat de la connexion : " + dbConnection.State.ToString();
                textBoxDbMessage.Text = error.Message;
            }
            finally
            {
                dbConnection.Close();
            }
        }
    }
}
