using ClassLibraryCheckTools;
using System;
using System.Windows.Forms;

namespace ListBox
{
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            TextBox name = (TextBox)sender;
            if (!ClassCheck.CheckName(name.Text))
            {
                errorProviderName.SetError(name, "Un nom comporte entre 2 et 15 lettres");
            } else
            {
                errorProviderName.Clear();
            }
        }

        private void textBoxIndex_TextChanged(object sender, EventArgs e)
        {
            TextBox name = (TextBox)sender;
            if (!ClassCheck.CheckIndex(name.Text))
            {
                errorProviderIndex.SetError(name, "Un index comporte entre 1 et 4 chiffres");
            }
            else
            {
                errorProviderIndex.Clear();
            }
        }

        private void buttonAddList_Click(object sender, EventArgs e)
        {
            //implement listboxName.? <-- textBoxName.Text
        }
    }
}

