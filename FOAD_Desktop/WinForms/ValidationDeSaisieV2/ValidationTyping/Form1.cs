using ClassLibraryFacture;
using ClassLibraryToolsChecks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidationSaisies
{
    public partial class Form1 : Form
    {
        Bill currentBill;

        public Form1()
        {
            currentBill = new Bill("undefined", DateTime.Today, 0, "undefined");
            InitializeComponent();
            OtherInitialize();
        }

        public Form1(Bill _bill)
        {
            currentBill = new Bill(_bill);
            InitializeComponent();
            OtherInitialize();
        }

        /// <summary>
        /// Property of the currentBill field only in read mode
        /// </summary>
        public Bill CurrentBill
        {
            get => this.currentBill;
        }

        private void OtherInitialize()
        {
            this.Closing += new CancelEventHandler(this.Form1_Closing);
        }

        /// <summary>
        /// Intercept the exit message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DialogResult dialogExit = MessageBox.Show("Voulez vous fermer la fenêtre", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogExit == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// When the windows are loaded we send the content of the bill into the TextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            if(this.currentBill.Name == "undefined")
            {
                return;
            }
            textBoxName.Text = currentBill.Name;
            textBoxDate.Text = currentBill.Date.ToString().Substring(0, 10);
            textBoxAmount.Text = currentBill.Amount.ToString();
            textBoxZipCode.Text = currentBill.ZipCode;
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
            string message;
            if (!ClassChecks.CheckName(textBoxName.Text) || !ClassChecks.CheckDate(textBoxDate.Text) || !ClassChecks.CheckAmount(textBoxAmount.Text) || !ClassChecks.CheckZipCode(textBoxZipCode.Text))
            {
                message = "Donnée saisie invalide";
            } else
            {
                string editDateString = textBoxDate.Text;
                float amount = 0;
                DateTime editDate = new DateTime();
                if(!DateTime.TryParseExact(textBoxDate.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.AssumeLocal, out editDate)) 
                {
                    return;
                }
                if(!float.TryParse(textBoxAmount.Text, out amount))
                {
                    float.TryParse(textBoxAmount.Text.Replace('.', ','), out amount);
                }
                currentBill = new Bill(textBoxName.Text, editDate, amount, textBoxZipCode.Text);
                message = currentBill.PrintBill();
            }
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
