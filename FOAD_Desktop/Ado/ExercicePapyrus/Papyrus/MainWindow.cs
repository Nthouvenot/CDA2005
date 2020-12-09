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
        private SqlConnectionStringBuilder connectionBuilder;
        private SqlConnection dbConnection;
        private bool isConnected;

        public MainWindow()
        {
            InitializeComponent();
            connectionBuilder = new SqlConnectionStringBuilder();
            dbConnection = new SqlConnection();
            textBoxServeurName.Text = "(localdb)\\MSSQLLocalDB";
            textBoxDataBaseName.Text = "PapyrusNicolas";
        }

        /// <summary>
        /// Exit the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            if (dbConnection.State == ConnectionState.Open)
            {
                dbConnection.Close();
            }
            this.Close();
        }

        /// <summary>
        /// try to connect to the Sql Server
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonConnection_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if(button.Name == "buttonConnect")
            {
                connectionBuilder.DataSource = textBoxServeurName.Text;
                connectionBuilder.IntegratedSecurity = true;
                connectionBuilder.Pooling = false;
                dbConnection.ConnectionString = connectionBuilder.ConnectionString;
                try
                {
                    dbConnection.Open();
                    isConnected = true;
                    richTextBoxDbMessage.Text = "connection success";
                    richTextBoxDbMessage.ForeColor = Color.Green;
                }
                catch (Exception error)
                {
                    isConnected = true;
                    richTextBoxDbMessage.Text = error.Message;
                    richTextBoxDbMessage.ForeColor = Color.Red;
                }
                finally
                {
                    if (!isConnected)
                    {
                        dbConnection.Close();
                    }
                }
            }
            else
            {
                dbConnection.Close();
                richTextBoxDbMessage.Clear();
            }
            labelConnexionState.Text = "Etat de la connexion : " + dbConnection.State.ToString();
        }
    }
}
