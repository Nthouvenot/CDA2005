using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBoxEtRadioBouttons
{
    public partial class MainWindow : Form
    {
        private Color initialBkgColor;
        private Color initialFgColor;
        public MainWindow()
        {
            InitializeComponent();
            initialBkgColor = this.BackColor;
            initialFgColor = this.ForeColor;
        }

        /// <summary>
        /// Event trigger when the window are loaded
        /// Set the initialize parameters
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindow_Load(object sender, EventArgs e)
        {
            checkBoxFontColor.Checked = false;
            checkBoxFontColor.Checked = false;
            checkBoxCase.Checked = false;
            groupBoxChoice.Enabled = false;
            groupBoxBackgroudColor.Enabled = false;
            groupBoxFontColor.Enabled = false;
            groupBoxCase.Enabled = false;
            labelResultTyping.Text = " ";
            
        }

        private void textBoxTyping_TextChanged(object sender, EventArgs e)
        {
            TextBox typing = (TextBox)sender;
            if(typing.Text.Length > 0)
            {
                groupBoxChoice.Enabled = true;
            } else
            {
                if(radioButtonBkgRed.Checked || radioButtonBkgGreen.Checked|| radioButtonBkgBlue.Checked)
                {
                    groupBoxBackgroudColor.Enabled = true;
                } else
                {
                    groupBoxBackgroudColor.Enabled = false;
                }
                if(radioButtonFontRed.Checked || radioButtonFontWhite.Checked || radioButtonFontBlack.Checked)
                {
                    groupBoxFontColor.Enabled = true;
                } else
                {
                    groupBoxFontColor.Enabled = false;
                }
                if(radioButtonCaseLower.Checked)
                {
                    groupBoxCase.Enabled = true;
                } else if(radioButtonCaseUpper.Checked)
                {
                    radioButtonCase_CheckedChanged(radioButtonCaseUpper, EventArgs.Empty);
                    groupBoxCase.Enabled = true;
                }
                groupBoxChoice.Enabled = false;
                            
            }
            if(typing.TextLength >= 45)
            {
                errorProviderTyping.SetError((Control)typing, "Le texte doit  faire moins de 45  caractères");
                return;
            }
            else
            {
                errorProviderTyping.Clear();
            }
            if (radioButtonCaseUpper.Checked)
            {
                labelResultTyping.Text = typing.Text.ToUpper();
            } else
            {
                labelResultTyping.Text = typing.Text;
            }
        }

        private void CheckBoxChoice_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox)sender;
            switch (box.Name)
            {
                case "checkBoxBackgroundColor":
                    {
                        if (!checkBoxBackgroundColor.Checked)
                        {
                            radioButtonBkgRed.Checked = false;
                            radioButtonBkgGreen.Checked = false;
                            radioButtonBkgBlue.Checked = false;
                            labelResultTyping.BackColor = initialBkgColor;
                        }
                        groupBoxBackgroudColor.Enabled = checkBoxBackgroundColor.Checked;
                        break;
                    }
                case "checkBoxFontColor":
                    {
                        if (!checkBoxFontColor.Checked)
                        {
                            radioButtonFontRed.Checked = false;
                            radioButtonFontWhite.Checked = false;
                            radioButtonFontBlack.Checked = false;
                            labelResultTyping.ForeColor = initialFgColor;
                        }
                        groupBoxFontColor.Enabled = checkBoxFontColor.Checked;
                        break;
                    }
                case "checkBoxCase":
                    {
                        if(!checkBoxCase.Checked)
                        {
                            radioButtonCaseLower.Checked = false;
                            radioButtonCaseUpper.Checked = false;
                            groupBoxCase.Enabled = false;
                        }
                        groupBoxCase.Enabled = true;
                        break;
                    }
            }
        }

        private void radioButtonBackgroundColor_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            switch(radioButton.Name)
            {
                case "radioButtonBkgRed":
                    {
                        labelResultTyping.BackColor = Color.Red;
                        break;
                    }
                case "radioButtonBkgGreen":
                    {
                        labelResultTyping.BackColor = Color.Green;
                        break;
                    }
                case "radioButtonBkgBlue":
                    {
                        labelResultTyping.BackColor = Color.Blue;
                        break;
                    }
            }
        }

        private void groupBoxFontColor_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            switch (radioButton.Name)
            {
                case "radioButtonFontRed":
                    {
                        labelResultTyping.ForeColor = Color.Red;
                        break;
                    }
                case "radioButtonFontWhite":
                    {
                        labelResultTyping.ForeColor = Color.White;
                        break;
                    }
                case "radioButtonFontBlack":
                    {
                        labelResultTyping.ForeColor = Color.Black;
                        break;
                    }
            }
        }

        private void radioButtonCase_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            switch (radioButton.Name)
            {
                case "radioButtonCaseLower":
                    {
                        if(radioButtonCaseLower.Checked)
                        {
                            string text = labelResultTyping.Text.ToLower();
                            labelResultTyping.Text = text;
                        }
                        break;
                    }
                case "radioButtonCaseUpper":
                    {
                        if(radioButtonCaseUpper.Checked)
                        {
                            string text = labelResultTyping.Text.ToUpper();
                            labelResultTyping.Text = text;
                        }
                        break;
                    }
            }
        }
    }
}
