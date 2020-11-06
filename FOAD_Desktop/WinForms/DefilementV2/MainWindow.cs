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
        Color choosenColor;

        public FormDefilement()
        {
            InitializeComponent();
            this.choosenColor = Color.Black;
            this.UpdateView(this);
        }

        public FormDefilement(Color _color)
        {
            InitializeComponent();
            this.choosenColor = _color;
            this.UpdateView(this);
        }

        /// <summary>
        /// Update the value of the control who has send the event
        /// Update the background color inside the label PrintRed, PrintGreen, PrintBlue and ColorResult
        /// </summary>
        private void UpdateView(object sender)
        {
            if (sender.GetType().Name == "HScrollBar")
            {
                numericUpDownRed.Value = this.choosenColor.R;
                numericUpDownGreen.Value = this.choosenColor.G;
                numericUpDownBlue.Value = this.choosenColor.B;
            }
            else if(sender.GetType().Name == "NumericUpDown")
            {
               hScrollBarRed.Value  = this.choosenColor.R;
               hScrollBarGreen.Value  = this.choosenColor.G;
               hScrollBarBlue.Value = this.choosenColor.B;
            }
            else
            {
                hScrollBarRed.Value = this.choosenColor.R;
                hScrollBarGreen.Value = this.choosenColor.G;
                hScrollBarBlue.Value = this.choosenColor.B;
                numericUpDownRed.Value = this.choosenColor.R;
                numericUpDownGreen.Value = this.choosenColor.G;
                numericUpDownBlue.Value = this.choosenColor.B;
            }
            labelPrintRed.BackColor = Color.FromArgb(this.choosenColor.R, 0, 0);
            labelPrintGreen.BackColor = Color.FromArgb(0, this.choosenColor.G, 0);
            labelPrintBlue.BackColor = Color.FromArgb(0, 0, this.choosenColor.B);
            labelColorResult.BackColor = choosenColor;
        }

        /// <summary>
        /// Methode called when the Value has changed or the user scroll the HScrollBars
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HScrollBar_ValueChangedOrScrolled(object sender, EventArgs e)
        {
            HScrollBar scrollBarSender = (HScrollBar)sender;
            switch (scrollBarSender.Name)
            {
                case "hScrollBarRed":
                    {
                        this.choosenColor = Color.FromArgb(hScrollBarRed.Value, this.choosenColor.G, this.choosenColor.B);
                        this.UpdateView(sender);
                        break;
                    }
                case "hScrollBarGreen":
                    {
                        this.choosenColor = Color.FromArgb(this.choosenColor.R, hScrollBarGreen.Value, this.choosenColor.B);
                        this.UpdateView(sender);
                        break;
                    }
                case "hScrollBarBlue":
                    {
                        this.choosenColor = Color.FromArgb(this.choosenColor.R, this.choosenColor.G, hScrollBarBlue.Value);
                        this.UpdateView(sender);
                        break;
                    }
            }
        }

        /// <summary>
        /// When the value of one NumericUpDown has changed we update the background of the NumericUpDown has been changed and the Label labelColorResult background color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDownSender = (NumericUpDown)sender;
            switch (numericUpDownSender.Name)
            {
                case "numericUpDownRed":
                    {
                        this.choosenColor = Color.FromArgb((int)numericUpDownRed.Value, this.choosenColor.G, this.choosenColor.B);
                        this.UpdateView(sender);
                        break;
                    }
                case "numericUpDownGreen":
                    {
                        this.choosenColor = Color.FromArgb(this.choosenColor.R, (int)numericUpDownGreen.Value, this.choosenColor.B);
                        this.UpdateView(sender);
                        break;
                    }
                case "numericUpDownBlue":
                    {
                        this.choosenColor = Color.FromArgb(this.choosenColor.R, this.choosenColor.G, (int)numericUpDownBlue.Value);
                        this.UpdateView(sender);
                        break;
                    }
            }
        }
    }
}
