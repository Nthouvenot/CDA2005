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
    public partial class OrderListWindow : Form
    {
        SqlConnectionStringBuilder connectionBuilder;
        SqlConnection dbConnection;
        SqlCommand command;
        SqlDataReader dataReader;
        private System.Globalization.CultureInfo currentCulture;

        public OrderListWindow()
        {
            InitializeComponent();
            currentCulture = System.Globalization.CultureInfo.CurrentCulture;
            this.connectionBuilder = new SqlConnectionStringBuilder(ConfigurationManager.ConnectionStrings["PapyrusDB"].ToString());
            this.dbConnection = new SqlConnection();
            dbConnection.ConnectionString = this.connectionBuilder.ConnectionString;
            try
            {
                this.dbConnection.Open();
                this.command = new SqlCommand("SELECT * FROM Fournisseurs;", dbConnection);
                this.dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    comboBoxSuplier.Items.Add(dataReader.GetString(1));
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.dbConnection.Close();
            }
            dataReader.Close();
        }

        private void ComboBoxSuplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            int orderNumber = 0;
            DateTime orderDate = new DateTime();
            string orderComment;
            listViewOrders.Items.Clear();
            if(comboBoxSuplier.SelectedIndex != -1)
            {
                int i = 0;
                this.command = new SqlCommand();
                SqlParameter parameter =  this.command.CreateParameter();
                parameter.SqlDbType = SqlDbType.Int;
                parameter.Direction = ParameterDirection.Input;
                parameter.ParameterName = "@suplier_number";
                parameter.Value = comboBoxSuplier.SelectedIndex;
                this.command.Connection = dbConnection;
                this.command.Parameters.Add(parameter);
                this.command.CommandType = CommandType.StoredProcedure;
                this.command.CommandText = "GetCommandeBySuplier";
                this.dataReader = command.ExecuteReader();
                while (this.dataReader.Read())
                {
                    orderNumber = this.dataReader.GetInt32(0);
                    orderDate = this.dataReader.GetDateTime(1);
                    orderComment = this.dataReader.GetString(2);
                    ListViewItem listViewItemNumber = new ListViewItem();
                    ListViewItem listViewItemDate = new ListViewItem();
                    ListViewItem listViewItemComment = new ListViewItem();
                    listViewItemNumber.SubItems[i].Text = orderNumber.ToString();
                    listViewOrders.Items.Add(listViewItemNumber);
                    listViewItemDate.SubItems[i].Text = orderDate.ToString(currentCulture.DateTimeFormat).Substring(0, 10);
                    listViewOrders.Items.Add(listViewItemDate);
                    listViewItemComment.SubItems[i].Text = orderComment;
                    listViewOrders.Items.Add(listViewItemComment);
                    i++;
                }
                this.dataReader.Close();
            }
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            dbConnection.Close();
            this.Close();
        }

        private void OrderListWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            dbConnection.Close();
        }
    }
}
