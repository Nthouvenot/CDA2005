﻿using System;
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

        /// <summary>
        /// When we select an items in the ComboBox "source" the button "add items" pass to enabled
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonAdd.Enabled = true;
        }

        /// <summary>
        /// When we select an items in the list box and it has more 2 element in it, the buttons "up" and "down" pass to enabled
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxTarget_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxTarget.SelectedIndex != -1)
            {
                buttonRemove.Enabled = true;
                buttonUp.Enabled = true;
                buttonDown.Enabled = true;
            }
            else if(listBoxTarget.SelectedIndex == 0)
            {
                buttonUp.Enabled = false;
            }
            else if(listBoxTarget.SelectedIndex == listBoxTarget.Items.Count - 1)
            {
                buttonDown.Enabled = false;
            }
        }

        /// <summary>
        /// Generical method for the buttons add, addAll, remove, removeAll
        /// Add or remove an element from the comboBox the ListBox
        /// Add all or remove all the elements From the ListBox to the ComboBox
        /// Manage the buttons following the asked action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddRemove_Click(object sender, EventArgs e)
        {
            int selectedIndex;
            Button buttonCliked = (Button)sender;
            switch (buttonCliked.Name)
            {
                case "buttonAdd":
                    {
                        selectedIndex = (int)comboBoxSource.SelectedIndex;
                        if (selectedIndex != -1)
                        {
                            listBoxTarget.Items.Add(comboBoxSource.SelectedItem.ToString());
                            comboBoxSource.Items.RemoveAt(selectedIndex);
                            buttonRemoveAll.Enabled = true;
                            //buttonAdd.Enabled = false;
                        }
                        // Select the following items and reset the Text if it has not other items
                        if (selectedIndex >= 0 && selectedIndex < comboBoxSource.Items.Count)
                        {
                            comboBoxSource.SelectedIndex = selectedIndex;
                            buttonAdd.Enabled = true;
                        }
                        else
                        {
                            comboBoxSource.Text = "";
                            buttonAdd.Enabled = false;
                            buttonAddAll.Enabled = false;
                        }
                        break;
                    }
                case "buttonAddAll":
                    {
                        comboBoxSource.SelectedIndex = -1; // I make sure it has not selected item int the ComboBox before moving the items in the ListBox
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
                        buttonRemoveAll.Enabled = true;
                        break;
                    }
                case "buttonRemove":
                    {
                        selectedIndex = listBoxTarget.SelectedIndex;
                        if(selectedIndex != -1)
                        {
                            comboBoxSource.Items.Add(listBoxTarget.SelectedItem.ToString());
                            listBoxTarget.Items.RemoveAt(selectedIndex);
                            if (comboBoxSource.Items.Count == 0)
                            {
                                buttonAdd.Enabled = false;
                                buttonAddAll.Enabled = false;
                            }
                            buttonRemove.Enabled = false;
                            // Select the following items and reset the Text if it has not other items
                            if (selectedIndex >= 0 && selectedIndex < listBoxTarget.Items.Count)
                            {
                                listBoxTarget.SelectedIndex = selectedIndex;
                                buttonRemove.Enabled = true;
                            }
                            else
                            {
                                buttonRemove.Enabled = false;
                                buttonRemoveAll.Enabled = false;
                                buttonUp.Enabled = false;
                                buttonDown.Enabled = false;
                            }
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
                        buttonAddAll.Enabled = true;
                        buttonUp.Enabled = false;
                        buttonDown.Enabled = false;
                        break;
                    }
            }
        }

        /// <summary>
        /// When click in the drop down buttons of the ComboBox check if the typed element exist and if yes add the element in the CombBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxSource_DropDown(object sender, EventArgs e)
        {
            if (comboBoxSource.Text.Length > 0 && !(comboBoxSource.Items.Contains(comboBoxSource.Text)) && !(listBoxTarget.Items.Contains(comboBoxSource.Text)))
            {
                int index = comboBoxSource.Items.Add(comboBoxSource.Text);
                comboBoxSource.SelectedItem = index;
                buttonAdd.Enabled = true;
                buttonAddAll.Enabled = true;
            }
        }

        /// <summary>
        /// Up an element of the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUp_Click(object sender, EventArgs e)
        {
            int index = listBoxTarget.SelectedIndex;
            if (index != -1 && index > 0)
            {
                string stringIntoIndex = listBoxTarget.Items[index].ToString();
                listBoxTarget.Items[index] = listBoxTarget.Items[index - 1];
                listBoxTarget.Items[index - 1] = stringIntoIndex;
                listBoxTarget.SelectedIndex = index - 1;
            }
            if(index == 1)
            {
                buttonUp.Enabled = false;
            }
        }

        /// <summary>
        /// Down an element of the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDown_Click(object sender, EventArgs e)
        {
            int index = listBoxTarget.SelectedIndex;
            if (index != -1 && index < listBoxTarget.Items.Count - 1)
            {
                string stringIntoIndex = listBoxTarget.Items[index].ToString();
                listBoxTarget.Items[index] = listBoxTarget.Items[index + 1];
                listBoxTarget.Items[index + 1] = stringIntoIndex;
                listBoxTarget.SelectedIndex = index + 1;
            }
            if(index == listBoxTarget.Items.Count - 2)
            {
                buttonDown.Enabled = false;
            }
        }
    }
}
