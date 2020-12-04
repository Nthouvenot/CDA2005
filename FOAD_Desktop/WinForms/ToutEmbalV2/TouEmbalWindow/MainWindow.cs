using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryToutEmbal;

namespace TouEmbalWindow
{
    public partial class MainWindow : Form
    {
        private WoodBoxProduction[] woodBoxProductions;

        public delegate void UpdateIHMDelegate(WoodBoxProduction production);

        public MainWindow()
        {
            InitializeComponent();
            this.woodBoxProductions = new WoodBoxProduction[3];
            this.woodBoxProductions[0] = new WoodBoxProduction(10000, 277, "Type A");
            this.woodBoxProductions[0].WoodBoxNumberOfBoxProductedChanged += this.woodBoxNumberOfBoxProductedChanged;
            this.woodBoxProductions[0].WoodBoxProductiontStateChanged += this.woodBoxProductiontStateChanged;
            this.woodBoxProductions[1] = new WoodBoxProduction(25000, 55, "Type B");
            this.woodBoxProductions[1].WoodBoxNumberOfBoxProductedChanged += this.woodBoxNumberOfBoxProductedChanged;
            this.woodBoxProductions[1].WoodBoxProductiontStateChanged += this.woodBoxProductiontStateChanged;
            this.woodBoxProductions[2] = new WoodBoxProduction(120000, 2, "Type C");
            this.woodBoxProductions[2].WoodBoxNumberOfBoxProductedChanged += this.woodBoxNumberOfBoxProductedChanged;
            this.woodBoxProductions[2].WoodBoxProductiontStateChanged += this.woodBoxProductiontStateChanged;
            foreach (ToolStripStatusLabel toolStripStatusLabel in toolStripStatus.Items)
            {
                if (toolStripStatusLabel.Name != toolStripStatusTime.Name)
                {
                    Size size = toolStripStatusTime.Size;
                    size.Width = (int)(toolStripStatus.ClientSize.Width - size.Width - 20) / 3;
                    toolStripStatusLabel.Size = size;
                }
            }
            timerHour.Start();
        }

        /// <summary>
        /// method for the comunication inter-threads
        /// </summary>
        /// <returns></returns>
        private void UpdateIhmNumberOfBox(WoodBoxProduction production)
        {
            int progress = production.CalculatePercentageOfProductionBox() / 5;
            switch (production.BoxName)
            {
                case "Type A":
                    {
                        textBoxNumberOfBoxProducedA.Text = production.CalculateNumberOfGoodBox().ToString();
                        textBoxRateDefaultPerHourA.Text = production.CalculateRateDefaultPerHour().ToString();
                        textBoxDefaultRateBeginStartA.Text = production.CalculateRateDefaultPerHour().ToString();
                        progressBarProductionA.Value = progress;
                        break;
                    }

                case "Type B":
                    {
                        textBoxNumberOfBoxProducedB.Text = production.CalculateNumberOfGoodBox().ToString();
                        textBoxRateDefaultPerHourB.Text = production.CalculateRateDefaultPerHour().ToString();
                        textBoxDefaultRateBeginStartB.Text = production.CalculateRateDefaultPerHour().ToString();
                        progressBarProductionB.Value = progress;
                        break;
                    }
                case "Type C":
                    {
                        textBoxNumberOfBoxProducedC.Text = production.CalculateNumberOfGoodBox().ToString();
                        textBoxRateDefaultPerHourC.Text = production.CalculateRateDefaultPerHour().ToString();
                        textBoxDefaultRateBeginStartC.Text = production.CalculateRateDefaultPerHour().ToString();
                        progressBarProductionC.Value = progress;
                        break;
                    }
            }

        }

        /// <summary>
        /// start a box production
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItemStart_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            switch (menuItem.Name)
            {
                case "toolStripMenuItemStartA":
                    {
                        woodBoxProductions[0].StartProduction();
                        toolStripMenuItemStartA.Enabled = false;
                        toolStripMenuItemStopA.Enabled = true;
                        toolStripMenuItemContinueA.Enabled = false;
                        tabControlType.SelectedTab = tabPageTypeA;
                        break;
                    }
                case "toolStripMenuItemStartB":
                    {
                        woodBoxProductions[1].StartProduction();
                        toolStripMenuItemStartB.Enabled = false;
                        toolStripMenuItemStopB.Enabled = true;
                        toolStripMenuItemContinueB.Enabled = false;
                        tabControlType.SelectedTab = tabPageTypeB;
                        break;
                    }
                case "toolStripMenuItemStartC":
                    {
                        woodBoxProductions[2].StartProduction();
                        toolStripMenuItemStartC.Enabled = false;
                        toolStripMenuItemStopC.Enabled = true;
                        toolStripMenuItemContinueC.Enabled = false;
                        tabControlType.SelectedTab = tabPageTypeC;
                        break;
                    }
            }
        }
        /// <summary>
        /// make a break of the production
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItemStop_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            switch (menuItem.Name)
            {
                case "toolStripMenuItemStopA":
                    {
                        woodBoxProductions[0].BreakProduction();
                        toolStripMenuItemStartA.Enabled = false;
                        toolStripMenuItemStopA.Enabled = false;
                        toolStripMenuItemContinueA.Enabled = true;
                        break;
                    }
                case "toolStripMenuItemStopB":
                    {
                        woodBoxProductions[1].BreakProduction();
                        toolStripMenuItemStartB.Enabled = false;
                        toolStripMenuItemStopB.Enabled = false;
                        toolStripMenuItemContinueB.Enabled = true;
                        break;
                    }
                case "toolStripMenuItemStopC":
                    {
                        woodBoxProductions[2].BreakProduction();
                        toolStripMenuItemStartC.Enabled = false;
                        toolStripMenuItemStopC.Enabled = false;
                        toolStripMenuItemContinueC.Enabled = true;
                        break;
                    }
            }
        }

        /// <summary>
        /// continue the production that the user make a break
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItemResume_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            switch (menuItem.Name)
            {
                case "toolStripMenuItemContinueA":
                    {
                        woodBoxProductions[0].ResumeProduction();
                        toolStripMenuItemStartA.Enabled = false;
                        toolStripMenuItemStopA.Enabled = true;
                        toolStripMenuItemContinueA.Enabled = false;
                        break;
                    }
                case "toolStripMenuItemContinueB":
                    {
                        woodBoxProductions[1].ResumeProduction();
                        toolStripMenuItemStartB.Enabled = false;
                        toolStripMenuItemStopB.Enabled = true;
                        toolStripMenuItemContinueB.Enabled = false;
                        break;
                    }
                case "toolStripMenuItemContinueC":
                    {
                        woodBoxProductions[2].ResumeProduction();
                        toolStripMenuItemStartC.Enabled = false;
                        toolStripMenuItemStopC.Enabled = true;
                        toolStripMenuItemContinueC.Enabled = false;
                        break;
                    }
            }
        }

        /// <summary>
        /// terminate the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            foreach (WoodBoxProduction production in woodBoxProductions)
            {
                production.WoodBoxNumberOfBoxProductedChanged -= woodBoxNumberOfBoxProductedChanged;
                production.CancelProduction();
            }
            this.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        private void woodBoxNumberOfBoxProductedChanged(WoodBoxProduction sender)
        {
            this.Invoke(new UpdateIHMDelegate(UpdateIhmNumberOfBox), new object[] { sender });
        }

        private void woodBoxProductiontStateChanged(WoodBoxProduction sender, WoodBoxProduction.ProductionState state)
        {

            if (sender == woodBoxProductions[0])
            {
                if(state == WoodBoxProduction.ProductionState.finished)
                {
                    woodBoxProductions[0] = new WoodBoxProduction(10000, 277, "Type A");
                    toolStripMenuItemStartA.Enabled = true;
                    toolStripMenuItemStopA.Enabled = false;
                    toolStripMenuItemContinueA.Enabled = false;
                }
                toolStripStatusLabelBoxA.Text = "Caisse A: " + state.ToString();
            }
            else if (sender == woodBoxProductions[1])
            {
                if(state == WoodBoxProduction.ProductionState.finished)
                {
                    woodBoxProductions[1] = new WoodBoxProduction(25000, 55, "Type B");
                    toolStripMenuItemStartB.Enabled = true;
                    toolStripMenuItemStopB.Enabled = false;
                    toolStripMenuItemContinueB.Enabled = false;
                }
                toolStripStatusLabelBoxB.Text = "Caisse B: " + state.ToString();
            }
            else if (sender == woodBoxProductions[2])
            {
                if(state == WoodBoxProduction.ProductionState.finished)
                {
                    woodBoxProductions[2] = new WoodBoxProduction(120000, 2, "Type C");
                    toolStripMenuItemStartC.Enabled = true;
                    toolStripMenuItemStopB.Enabled = false;
                    toolStripMenuItemContinueC.Enabled = false;
                }
                toolStripStatusLabelBoxC.Text = "Caisse C: " + state.ToString();
            }
        }







        /// <summary>
        /// 
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
            else
            {
                e.Cancel = true;
                foreach (WoodBoxProduction production in woodBoxProductions)
                {
                    production.WoodBoxNumberOfBoxProductedChanged -= woodBoxNumberOfBoxProductedChanged;
                    production.CancelProduction();
                }
                e.Cancel = false;
            }
        }

        private void timerHour_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            toolStripStatusTime.Text = time.Hour.ToString() + ":" + time.Minute.ToString(); //To do corret the print of the time, lack the first 0 in the minutes
        }
    }
}