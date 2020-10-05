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

namespace Calculatrice
{
    public partial class Form1 : Form
    {
        private int result;
        private string sum;
        public Form1()
        {
            this.result = 0;
            InitializeComponent();
        }

        private void MakeSum(object sender, EventArgs e)
        {
            int value = 0;
            if (sender == this.button0)
            {
                value = 0;
            }

            if (sender == this.button1)
            {
                value = 1;
            }

            if (sender == this.button2)
            {
                value = 2;
            }

            if (sender == this.button3)
            {
                value = 3;
            }

            if (sender == this.button4)
            {
                value = 4;
            }

            if (sender == this.button5)
            {
                value = 5;
            }

            if (sender == this.button6)
            {
                value = 6;
            }

            if (sender == this.button7)
            {
                value = 7;
            }

            if (sender == this.button8)
            {
                value = 8;
            }

            if (sender == this.button9)
            {
                value = 9;
            }

            if (string.IsNullOrEmpty(this.sum))
            {
                this.result = value;
                this.sum = value.ToString();
            }
            else
            {
                this.sum = this.sum + "+" + value;
                this.result += value;
            }
            this.printResult.Text = this.sum;

        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.result = 0;
            this.sum = "";
            this.printResult.Text = sum;
        }

        private void calculer_Click(object sender, EventArgs e)
        {
            this.printResult.Text = this.sum + " = " + this.result + "+";
        }
    }
}
