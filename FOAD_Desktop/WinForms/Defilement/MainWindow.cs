using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Defilement
{
    public partial class FormDefilement : Form
    {
        public FormDefilement()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Methode called when the Value has changed or the user scroll the HScrollBars
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hScrollBar_ValueChangedOrScrolled(object sender, EventArgs e)
        {
            HScrollBar scrollBarSender = (HScrollBar)sender;
            switch (scrollBarSender.Name)
            {
                case "hScrollBarRed":
                    {
                        numericUpDownRed.Value = hScrollBarRed.Value;
                        break;
                    }
                case "hScrollBarGreen":
                    {
                        numericUpDownGreen.Value = hScrollBarGreen.Value;
                        break;
                    }
                case "hScrollBarBlue":
                    {
                        numericUpDownBlue.Value = hScrollBarBlue.Value;
                        break;
                    }
            }
        }

        /// <summary>
        /// When the value of one NumericUpDown has changed we update the background of the NumericUpDown has been changed and the Label labelColorResult background color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDownSender = (NumericUpDown)sender;
            switch (numericUpDownSender.Name)
            {
                case "numericUpDownRed":
                    {
                        hScrollBarRed.Value = (int)numericUpDownSender.Value;
                        labelPrintRed.BackColor = Color.FromArgb((int)numericUpDownSender.Value, 0, 0);
                        break;
                    }
                case "numericUpDownGreen":
                    {
                        hScrollBarGreen.Value = (int)numericUpDownGreen.Value;
                        labelPrintGreen.BackColor = Color.FromArgb(0, (int)numericUpDownSender.Value, 0);
                        break;
                    }
                case "numericUpDownBlue":
                    {
                        hScrollBarBlue.Value = (int)numericUpDownBlue.Value;
                        labelPrintBlue.BackColor = Color.FromArgb(0, 0, (int)numericUpDownSender.Value);
                        break;
                    }
            }
            labelColorResult.BackColor = Color.FromArgb((int)numericUpDownRed.Value, (int)numericUpDownGreen.Value, (int)numericUpDownBlue.Value);
        }
    }
}
