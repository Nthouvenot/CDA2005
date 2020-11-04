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
        }

        public FormDefilement(Color _color)
        {
            InitializeComponent();
            this.choosenColor = _color;
            //labelColorResult.BackColor = this.choosenColor;
        }

        /// <summary>
        /// Update the background color inside the label PrintRed, PrintGreen, PrintBlue and ColorResult
        /// </summary>
        private void UpdateView()
        {
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
                        numericUpDownRed.Value = hScrollBarRed.Value;
                        this.choosenColor = Color.FromArgb(hScrollBarRed.Value, this.choosenColor.G, this.choosenColor.B);
                        this.UpdateView();
                        break;
                    }
                case "hScrollBarGreen":
                    {
                        numericUpDownGreen.Value = hScrollBarGreen.Value;
                        this.choosenColor = Color.FromArgb(this.choosenColor.R, hScrollBarGreen.Value, this.choosenColor.B);
                        this.UpdateView();
                        break;
                    }
                case "hScrollBarBlue":
                    {
                        numericUpDownBlue.Value = hScrollBarBlue.Value;
                        this.choosenColor = Color.FromArgb(this.choosenColor.R, this.choosenColor.G, hScrollBarBlue.Value);
                        this.UpdateView();
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
                        hScrollBarRed.Value = (int)numericUpDownSender.Value;
                        this.choosenColor = Color.FromArgb(hScrollBarRed.Value, this.choosenColor.G, this.choosenColor.B);
                        this.UpdateView();
                        break;
                    }
                case "numericUpDownGreen":
                    {
                        hScrollBarGreen.Value = (int)numericUpDownGreen.Value;
                        this.choosenColor = Color.FromArgb(this.choosenColor.R, hScrollBarGreen.Value, this.choosenColor.B);
                        this.UpdateView();
                        break;
                    }
                case "numericUpDownBlue":
                    {
                        hScrollBarBlue.Value = (int)numericUpDownBlue.Value;
                        this.choosenColor = Color.FromArgb(this.choosenColor.R, this.choosenColor.G, hScrollBarBlue.Value);
                        this.UpdateView();
                        break;
                    }
            }
        }
    }
}
