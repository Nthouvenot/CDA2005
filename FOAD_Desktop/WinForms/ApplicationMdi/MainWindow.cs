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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            stage1ToolStripMenuItem.Enabled = false;
            Stage2ToolStripMenuItem.Enabled = false;
            stage3ToolStripMenuItem.Enabled = false;
            WindowToolStripMenuItem.Enabled = false;
            int i = 0;
            foreach (ToolStripItem menuItems in stage3ToolStripMenuItem.DropDownItems)
            {
                if (menuItems is ToolStripMenuItem)
                {
                    toolStripDropDownButtonStage3.DropDownItems.Add(new ToolStripMenuItem(menuItems.Text, null, toolStripMenuItem_Click, "toolBarmenuItem" + i));
                }
                else if (menuItems is ToolStripSeparator)
                {
                    toolStripDropDownButtonStage3.DropDownItems.Add(new ToolStripSeparator());
                }
                i++;
            }
            toolStripDropDownButtonStage3.DropDownItems[3].Visible = true;
            toolStripDropDownButtonStage3.Enabled = false;
            statusStrip.Items[0].Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }

        /// <summary>
        /// Intercept the exit message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindow_Closing(object sender, FormClosingEventArgs e)
        {
            DialogResult applicationExitDialog = MessageBox.Show("Voulez vous vraiment quitter l'application", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (applicationExitDialog == DialogResult.No && sender == this)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Generic method for the click event provided by the menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            toolStripStatusLabelStatus.Text = menuItem.Text;
            if (menuItem.Name == "identificationToolStripMenuItem")
            {
                stage1ToolStripMenuItem.Enabled = true;
                Stage2ToolStripMenuItem.Enabled = true;
                stage3ToolStripMenuItem.Enabled = true;
                WindowToolStripMenuItem.Enabled = true;
                toolStripDropDownButtonStage3.Enabled = true;
                MessageBox.Show(this, "Bienvenue");
            }
            else if (menuItem.Name == "ExitToolStripMenuItem")
            {
                Application.Exit();
            }
            else if (menuItem.Name == "stage1ToolStripMenuItem")
            {
                Calculatrice.Form1 mdiCalculatrice = new Calculatrice.Form1();
                mdiCalculatrice.MdiParent = this;
                mdiCalculatrice.Show();
            }
            else if (menuItem.Name == "Stage2ToolStripMenuItem")
            {
                ValidationSaisies.Form2 mdiValidationSaisie = new ValidationSaisies.Form2();
                mdiValidationSaisie.MdiParent = this;
                mdiValidationSaisie.Show();
            }
            else if (menuItem.Name == "casesToolStripMenuItem" || menuItem.Name == "toolBarmenuItem0")
            {
                TypingWindow mdiTyping = new TypingWindow();
                mdiTyping.MdiParent = this;
                mdiTyping.Show();
            }
            else if (menuItem.Name == "comboBoxToolStripMenuItem" || menuItem.Name == "toolBarmenuItem1")
            {
                ListBoxEtComboBox.MainWindow mdiComboBox = new ListBoxEtComboBox.MainWindow();
                mdiComboBox.MdiParent = this;
                mdiComboBox.Show();
            }
            else if (menuItem.Name == "scrollToolStripMenuItem" || menuItem.Name == "toolBarmenuItem2")
            {
                Defilement.FormDefilement mdiScroll = new Defilement.FormDefilement();
                mdiScroll.MdiParent = this;
                mdiScroll.Show();

            }
        }

        /// <summary>
        /// Method for the toolStripButtonIdentification event click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButtonIdentification_Click(object sender, EventArgs e)
        {
            stage1ToolStripMenuItem.Enabled = true;
            Stage2ToolStripMenuItem.Enabled = true;
            stage3ToolStripMenuItem.Enabled = true;
            WindowToolStripMenuItem.Enabled = true;
            toolStripDropDownButtonStage3.Enabled = true;
            MessageBox.Show(this, "Bienvenue");
        }

        /// <summary>
        /// Timer for refresh the StatusBar time zone
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerDateHour_Tick(object sender, EventArgs e)
        {
            statusStrip.Items[0].Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }

        
    }
}
