using ClassLibraryToolsChecks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidationSaisies
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Generic methode for validate the content of the TextBoxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Input_TextChanged(object sender, EventArgs e)
        {
            TextBox input = (TextBox)sender;
            switch(input.Name)
            {
                case "textBoxName":
                    {
                        if (!ClassChecks.CheckName(input.Text))
                        {
                            errorProviderNom.SetError(input, "Le nom doit contenir de 2 a 30 lettres");
                        } else
                        {
                            errorProviderNom.Clear();
                        }
                        
                        break;
                    }
                case "textBoxDate":
                    {
                        if (!ClassChecks.CheckDate(input.Text))
                        {
                            errorProviderDate.SetError(input, "La date doit être au fomat date JJ/MM/YYYY");
                        } else
                        {
                            errorProviderDate.Clear();
                        }

                        break;
                    }
                case "textBoxAmount":
                    {
                        if(!ClassChecks.CheckAmount(input.Text))
                        {
                            errorProviderAmount.SetError(input, "Le montant doit être au format decimal avec deux chiffre aprés la virgule");
                        } else
                        {
                            errorProviderAmount.Clear();
                        }
                        break;
                    }
                case "textBoxZipCode":
                    {
                        if(!ClassChecks.CheckZipCode(input.Text))
                        {
                            errorProviderZipCode.SetError(input, "Le code postal doit contenir 5 chiffres et être inférieur a 96000");
                        } else
                        {
                            errorProviderZipCode.Clear();
                        }
                        break;
                    }
            }
        }

        private void validate_Click(object sender, EventArgs e)
        {
            string message = "Nom : " +  textBoxName.Text + "\n" + "Date : " + textBoxDate.Text + "\n" + "Montant : " + textBoxAmount.Text + "\n" + "Code : " + textBoxZipCode.Text;
            MessageBox.Show(message, "Validation saisie", MessageBoxButtons.OK);

        }
        /// <summary>
        /// Clear all the TextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clear_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
            textBoxDate.Clear();
            textBoxAmount.Clear();
            textBoxZipCode.Clear();
        }
    }
}
