using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryMdi;

namespace ApplicationMdi
{
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBoxSender = (TextBox)sender;
            if(textBoxSender == textBoxLogin)
            {
                if (!CheckTools.IsPasswordValid(textBoxLogin.Text) && textBoxLogin.Text.Length > 0)
                {
                    errorProviderLogin.SetError(textBoxLogin, "Le login doit contenir de 2 a 10 caractére");
                }
                else
                {
                    errorProviderLogin.Clear();
                }
            }
            else if(textBoxSender == textBoxPassword)
            {

            }
        }
    }
}
