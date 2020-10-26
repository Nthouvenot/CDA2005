using ClassLibraryCheckTools;
using System;
using System.Windows.Forms;

namespace ListBoxMain
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
                buttonAddList.Enabled = false;
            } else if(listBoxName.Items.Contains(name.Text))
            {
                errorProviderName.SetError(name, "Un nom doit être unique");
                buttonAddList.Enabled = false;
            } else
            {
                errorProviderName.Clear();
                buttonAddList.Enabled = true;
            }
        }

        /// <summary>
        /// Check if the string is char composed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxIndex_TextChanged(object sender, EventArgs e)
        {
            TextBox textIndex = (TextBox)sender;
            if (!ClassCheck.CheckIndex(textIndex.Text))
            {

                errorProviderIndex.SetError(textIndex, "Un index comporte entre 1 et 4 chiffres positif");
                buttonSelect.Enabled = false;
            } else if(Int32.Parse(textIndex.Text) > Int32.Parse(textBoxItems.Text) - 1)
            {
                errorProviderIndex.SetError(textIndex, "l'index doit exister");
                buttonSelect.Enabled = false;
            }
            else
            {
                errorProviderIndex.Clear();
                buttonSelect.Enabled = true;
            }
        }

        /// <summary>
        /// Add the name into the list
        /// Count the number of name in the list and retrun the result into the TextBox "textBoxItems"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddList_Click(object sender, EventArgs e)
        {
            listBoxName.Items.Add(textBoxName.Text);
            textBoxName.Clear();
            errorProviderName.Clear();
            textBoxItems.Text = listBoxName.Items.Count.ToString();
            buttonEmpty.Enabled = true;
        }

        /// <summary>
        /// Return the current selected index and name into the SelectedIndex TextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int index = 0;
            ListBox listName = (ListBox)sender;
            textBoxSelectedIndex.Text = listName.SelectedIndex.ToString();
            if(listName.SelectedItem == null)
            {
                textBoxSelectedIndex.Text = " ";
                return;
                
            } else
            {
                textBoxTextName.Text = listBoxName.SelectedItem.ToString();
            }
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            int index = Int32.Parse(textBoxIndex.Text);
            listBoxName.SelectedIndex = Int32.Parse(textBoxIndex.Text);
        }

        /// <summary>
        /// clear the list and reset the content of the TextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEmpty_Click(object sender, EventArgs e)
        {
            errorProviderName.Clear();
            listBoxName.Items.Clear();
            buttonSelect.Enabled = false;
            textBoxIndex.Clear();
            errorProviderIndex.Clear();
            textBoxItems.Clear();
            textBoxSelectedIndex.Clear();
            textBoxTextName.Clear();
        }
    }
}
