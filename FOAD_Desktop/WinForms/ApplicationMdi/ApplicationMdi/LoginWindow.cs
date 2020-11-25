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
        public delegate void IdentifyingOk(object sender);
        public event IdentifyingOk Success;

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
            if(textBoxLogin.Text == CheckTools.Login && textBoxPassword.Text == CheckTools.Password)
            {
                if(Success != null)
                {
                    this.Success(this.Parent);
                }
                MessageBox.Show("Succes", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                 MessageBox.Show("identifiant incorrect", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBoxSender = (TextBox)sender;
            if(textBoxSender == textBoxLogin)
            {
                if (!CheckTools.IsLoginValid(textBoxLogin.Text) && textBoxLogin.Text.Length > 0)
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
                if (!CheckTools.IsPasswordValid(textBoxLogin.Text) && textBoxPassword.Text.Length > 0)
                {
                    errorProviderLogin.SetError(textBoxLogin, "Le login doit contenir de 2 a 10 caractére");
                }
                else
                {
                    errorProviderLogin.Clear();
                }
            }
        }
    }
}
