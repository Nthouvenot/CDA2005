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
            Button button = (Button)sender;
            int number = Convert.ToInt32(button.Tag);
            if (string.IsNullOrEmpty(this.sum))
            {
                this.result = number;
                this.sum = number.ToString();
            }
            else
            {
                if((this.result + number) > Int32.MaxValue)
                {
                    this.sum = "Overflow error";
                }
                else
                {
                    this.sum = this.sum + "+" + number;
                    this.result += number;
                }
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
