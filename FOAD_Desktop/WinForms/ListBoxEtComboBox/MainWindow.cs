using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxEtComboBox
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            string[] countries = { "France", "Belgique", "Allemagne", "Japon", "Portugal", "Grece" };
            comboBoxSource.Items.AddRange(countries);
            comboBoxSource.Sorted = true;
        }

        private void comboBoxSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonAdd.Enabled = true;
        }

        private void listBoxTarget_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonRemove.Enabled = true;
            if(listBoxTarget.Items.Count >= 2)
            {
                buttonUp.Enabled = true;
                buttonDown.Enabled = true;
            }
        }

        private void buttonAddRemove_Click(object sender, EventArgs e)
        {
            int selectedIndex;
            Button buttonCliked = (Button)sender;
            switch (buttonCliked.Name)
            {
                case "buttonAdd":
                    {
                        selectedIndex = comboBoxSource.SelectedIndex;
                        listBoxTarget.Items.Add(comboBoxSource.SelectedItem.ToString());
                        comboBoxSource.Items.RemoveAt(selectedIndex);
                        if (!buttonRemove.Enabled || !buttonRemoveAll.Enabled)
                        {
                            buttonRemove.Enabled = true;
                            buttonRemoveAll.Enabled = true;
                        }
                        break;
                    }
                case "buttonAddAll":
                    {
                        int numberItems = comboBoxSource.Items.Count;
                        string[] collectionSource = new string[numberItems];
                        if (numberItems != 0)
                        {
                            comboBoxSource.Items.CopyTo(collectionSource, 0);
                        }
                        listBoxTarget.Items.AddRange(collectionSource);
                        comboBoxSource.Items.Clear();
                        buttonAdd.Enabled = false;
                        buttonAddAll.Enabled = false;
                        if (!buttonRemove.Enabled || !buttonRemoveAll.Enabled)
                        {
                            buttonRemoveAll.Enabled = true;
                        }
                        break;
                    }
                case "buttonRemove":
                    {
                        selectedIndex = listBoxTarget.SelectedIndex;
                        comboBoxSource.Items.Add(listBoxTarget.SelectedItem.ToString());
                        listBoxTarget.Items.RemoveAt(selectedIndex);
                        if (comboBoxSource.Items.Count == 0)
                        {
                            buttonAdd.Enabled = false;
                            buttonAddAll.Enabled = false;
                        }
                        break;
                    }
                case "buttonRemoveAll":
                    {
                        int numberItems = listBoxTarget.Items.Count;
                        string[] collectionSource = new string[numberItems];
                        if (numberItems != 0)
                        {
                            listBoxTarget.Items.CopyTo(collectionSource, 0);
                        }
                        comboBoxSource.Items.AddRange(collectionSource);
                        listBoxTarget.Items.Clear();
                        buttonRemove.Enabled = false;
                        buttonRemoveAll.Enabled = false;
                        if (!buttonAdd.Enabled || !buttonAddAll.Enabled)
                        {
                            buttonAddAll.Enabled = true;
                        }
                        break;
                    }
            }
        }

        private void comboBoxSource_DropDown(object sender, EventArgs e)
        {
            if (comboBoxSource.Text.Length > 0 && !(comboBoxSource.Items.Contains(comboBoxSource.Text)))
            {
                int index = comboBoxSource.Items.Add(comboBoxSource.Text);
                comboBoxSource.SelectedItem = index;
                if (!buttonAdd.Enabled || !buttonAddAll.Enabled)
                {
                    buttonAdd.Enabled = true;
                    buttonAddAll.Enabled = true;
                }
            }
        }
    }
}
