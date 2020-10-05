using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice
{
    public partial class Form1 : Form
    {
        private int result = 0;
        private string sum;
        public Form1()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            this.result += 0;
            if (string.IsNullOrEmpty(this.sum))
            {
                this.sum = this.sum + "0";
            }
            else
            {
                this.sum = this.sum + "+0";
            }
            this.printResult.Text = this.sum;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.result += 1;
            if(string.IsNullOrEmpty(this.sum))
            {
                this.sum = this.sum + "1";
            } else
            {
                this.sum = this.sum + "+1";
            }
            this.printResult.Text = this.sum;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.result += 2;
            if (string.IsNullOrEmpty(this.sum))
            {
                this.sum = this.sum + "2";
            }
            else
            {
                this.sum = this.sum + "+2";
            }
            this.printResult.Text = this.sum;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.result += 3;
            if (string.IsNullOrEmpty(this.sum))
            {
                this.sum = this.sum + "3";
            }
            else
            {
                this.sum = this.sum + "+3";
            }
            this.printResult.Text = this.sum;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.result += 4;
            if (string.IsNullOrEmpty(this.sum))
            {
                this.sum = this.sum + "4";
            }
            else
            {
                this.sum = this.sum + "+4";
            }
            this.printResult.Text = this.sum;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.result += 5;
            if (string.IsNullOrEmpty(this.sum))
            {
                this.sum = this.sum + "5";
            }
            else
            {
                this.sum = this.sum + "+5";
            }
            this.printResult.Text = this.sum;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.result += 6;
            if (string.IsNullOrEmpty(this.sum))
            {
                this.sum = this.sum + "6";
            }
            else
            {
                this.sum = this.sum + "+6";
            }
            this.printResult.Text = this.sum;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.result += 7;
            if (string.IsNullOrEmpty(this.sum))
            {
                this.sum = this.sum + "7";
            }
            else
            {
                this.sum = this.sum + "+7";
            }
            this.printResult.Text = this.sum;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.result += 8;
            if (string.IsNullOrEmpty(this.sum))
            {
                this.sum = this.sum + "8";
            }
            else
            {
                this.sum = this.sum + "+8";
            }
            this.printResult.Text = this.sum;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.result += 9;
            if (string.IsNullOrEmpty(this.sum))
            {
                this.sum = this.sum + "9";
            }
            else
            {
                this.sum = this.sum + "+9";
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
