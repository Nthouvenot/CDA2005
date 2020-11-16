using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emprunt
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            string[] periodReimbursement = { "Mensuelle", "Bimensuelle", "Trimestrielle", "Semestrielle", "Anuelle" };
            listBoxReimbursementPeriod.Items.AddRange(periodReimbursement);
            radioButtonSevenPercent.Checked = true;
        }

        /// <summary>
        /// When the text of the TextBox textBoxName change we check if the text is ok and let know the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            TextBox currentTextBox = (TextBox)sender;
            if (currentTextBox.Text.Length == 0)
            {
                errorProviderName.Clear();
            }
            else if(!ClassLibraryLoan.CheckTools.CheckName(currentTextBox.Text))
            {
                errorProviderName.SetError((Control)currentTextBox, "Un nom ne doit comporter que des lettre et faire au moins 4 caractéres");
            } 
            else
            {
                errorProviderName.Clear();
            }
        }

        /// <summary>
        /// When the text of the TextBox textBoxMoneyBoworred change we check if the text is ok and let know the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxMoneyBoworred_TextChanged(object sender, EventArgs e)
        {
            TextBox currentTextBox = (TextBox)sender;
            if (!ClassLibraryLoan.CheckTools.CheckMoneyBoworred(currentTextBox.Text))
            {
                errorProviderMoneyBoworred.SetError((Control)currentTextBox, "la somme emprunté doit être au minimun de 4 chiffres et faire 10 au maximum");
            }
            else
            {
                errorProviderMoneyBoworred.Clear();
            }
        }

        /// <summary>
        /// Link the ScrollBar with the Label labelMonthValue
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hScrollBarNumberOfMonths_ValueChanged(object sender, EventArgs e)
        {
            labelMonthValue.Text = hScrollBarNumberOfMonths.Value.ToString();
        }
        
        private void buttonOk_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// When the user click on the cancel button we reset the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
            textBoxMoneyBoworred.Clear();
            hScrollBarNumberOfMonths.Value = 1;
            listBoxReimbursementPeriod.SelectedItem = 1;
            radioButtonSevenPercent.Checked = true;
            radioButtonEightPercent.Checked = false;
            radioButtonNinePercent.Checked = false;
            labelMonths.Text = "0";
            labelAmountPerMonth.Text = "0";
        }
    }
}