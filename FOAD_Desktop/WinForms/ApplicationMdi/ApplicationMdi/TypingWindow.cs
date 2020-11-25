using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationMdi
{
    public partial class TypingWindow : Form
    {
        private string textTyping;

        public TypingWindow()
        {
            InitializeComponent();
        }

        public string TextTyping {
            get => textTyping; 
            //set => text = value; 
        }

        private void textBoxTyping_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.TextLength >= 45)
            {
                errorProviderTyping.SetError((Control)textBox, "Le texte doit  faire moins de 45  caractères");
                buttonValidate.Enabled = false;
                return;
            }
            else
            {
                errorProviderTyping.Clear();
                buttonValidate.Enabled = true;
            }
        }

        private void buttonValidate_Click(object sender, EventArgs e)
        {
            this.textTyping = textBoxTyping.Text;
        }
    }
}
