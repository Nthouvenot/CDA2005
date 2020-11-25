using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ClassLibraryLoan.Loan;

namespace Emprunt
{
    public partial class MainWindow : Form
    {
        ClassLibraryLoan.Loan loan;
        public MainWindow()
        {
            loan = new ClassLibraryLoan.Loan();
            InitializeComponent();
            string[] periodReimbursement = { "Mensuelle", "Bimensuelle", "Trimestrielle", "Semestrielle", "Anuelle" };
            listBoxReimbursementPeriod.Items.AddRange(periodReimbursement);
            listBoxReimbursementPeriod.SelectedIndex = 0;
            radioButtonSevenPercent.Checked = true;
            this.UpdateView();

        }

        /// <summary>
        /// When the text of the TextBox textBoxName change we check if the text is ok and let know the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxName_TextChanged(object sender, EventArgs e)
        {
            TextBox currentTextBox = (TextBox)sender;
            if (currentTextBox.Text.Length == 0)
            {
                errorProviderName.Clear();
            }
            else if (!ClassLibraryLoan.CheckTools.CheckName(currentTextBox.Text))
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
        private void TextBoxMoneyBoworred_TextChanged(object sender, EventArgs e)
        {
            TextBox currentTextBox = (TextBox)sender;
            if (textBoxMoneyBoworred.Text.Length == 0)
            {
                errorProviderMoneyBoworred.Clear();
                buttonOk.Enabled = false;
            }
            else if (!ClassLibraryLoan.CheckTools.CheckMoneyBoworred(currentTextBox.Text))
            {
                errorProviderMoneyBoworred.SetError((Control)currentTextBox, "la somme emprunté doit être au minimun de 4 chiffres et faire 10 au maximum");
                buttonOk.Enabled = false;
            }
            else
            {
                errorProviderMoneyBoworred.Clear();
                buttonOk.Enabled = true;
                loan.Amount = Int32.Parse(currentTextBox.Text);
                this.UpdateView();
            }
        }

        /// <summary>
        /// Link the ScrollBar with the Label labelMonthValue
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HScrollBarNumberOfMonths_ValueChanged(object sender, EventArgs e)
        {
            this.loan.NumberOfMonth = hScrollBarNumberOfMonths.Value;
            this.UpdateView();
        }

        private void listBoxReimbursementPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox currentListBox = (ListBox)sender;
            switch (currentListBox.SelectedIndex)
            {
                case 0:
                    {
                        this.loan.CurrentReimbursementPeriod = ReimbursementPeriod.monthly;
                        break;
                    }
                case 1:
                    {
                        this.loan.CurrentReimbursementPeriod = ReimbursementPeriod.biMonthly;
                        break;
                    }
                case 2:
                    {
                        this.loan.CurrentReimbursementPeriod = ReimbursementPeriod.triMonthly;
                        break;
                    }
                case 3:
                    {
                        this.loan.CurrentReimbursementPeriod = ReimbursementPeriod.biAnnual;
                        break;
                    }
                case 4:
                    {
                        this.loan.CurrentReimbursementPeriod = ReimbursementPeriod.annual;
                        break;
                    }
            }
            this.UpdateView();
        }

        private void RadioButtonPercent_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton currentRadioButton = (RadioButton)sender;
            if (currentRadioButton.Checked)
            {
                switch (currentRadioButton.Name)
                {
                    case "radioButtonSevenPercent":
                        {
                            this.loan.Rate = 7;
                            break;
                        }
                    case "radioButtonEightPercent":
                        {
                            this.loan.Rate = 8;
                            break;
                        }
                    case "radioButtonNinePercent":
                        {
                            this.loan.Rate = 9;
                            break;
                        }
                }
            }
            this.UpdateView();
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// When the user click on the cancel button we reset the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
            textBoxMoneyBoworred.Clear();
            hScrollBarNumberOfMonths.Value = 1;
            listBoxReimbursementPeriod.SelectedIndex = 0;
            radioButtonSevenPercent.Checked = true;
            radioButtonEightPercent.Checked = false;
            radioButtonNinePercent.Checked = false;
            labelMonths.Text = "0";
            labelAmountPerMonth.Text = "0";
        }

        private void UpdateView()
        {
            if (hScrollBarNumberOfMonths.Value < (int)this.loan.CurrentReimbursementPeriod)
            {
                hScrollBarNumberOfMonths.Value = (int)this.loan.CurrentReimbursementPeriod;
            }
            else
            {
                hScrollBarNumberOfMonths.Value = (hScrollBarNumberOfMonths.Value / (int)this.loan.CurrentReimbursementPeriod) * (int)this.loan.CurrentReimbursementPeriod;
            }
            if (textBoxMoneyBoworred.Text.Length > 0 && this.loan.NumberOfMonth != 0)
            {
                labelMonthValue.Text = this.loan.NumberOfMonth.ToString();
                labelAmountPerMonth.Text = this.loan.Calculate().ToString();
                labelMonths.Text = this.loan.CalculateNumberOfMonth().ToString();
            }
            else
            {
                labelMonthValue.Text = "0";
            }
            if (loan.NumberOfMonth > 0)
            {
                hScrollBarNumberOfMonths.Value = loan.NumberOfMonth;
            }
            if ((int)loan.CurrentReimbursementPeriod != hScrollBarNumberOfMonths.SmallChange)
            {
                hScrollBarNumberOfMonths.Minimum = (int)this.loan.CurrentReimbursementPeriod;
                hScrollBarNumberOfMonths.SmallChange = (int)this.loan.CurrentReimbursementPeriod;
                labelMonthValue.Text = this.loan.NumberOfMonth.ToString();
            }
        }
    }
    }
