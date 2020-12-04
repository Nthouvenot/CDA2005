
namespace TouEmbalWindow
{
    partial class MainWindow
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.productionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startProductionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemStartA = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemStartB = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemStartC = new System.Windows.Forms.ToolStripMenuItem();
            this.StopProductionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemStopA = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemStopB = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemStopC = new System.Windows.Forms.ToolStripMenuItem();
            this.continueProductionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemContinueA = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemContinueB = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemContinueC = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlType = new System.Windows.Forms.TabControl();
            this.tabPageTypeA = new System.Windows.Forms.TabPage();
            this.textBoxDefaultRateBeginStartA = new System.Windows.Forms.TextBox();
            this.textBoxRateDefaultPerHourA = new System.Windows.Forms.TextBox();
            this.textBoxNumberOfBoxProducedA = new System.Windows.Forms.TextBox();
            this.labelDefaultRateBeginStartA = new System.Windows.Forms.Label();
            this.labelRateDefaultPerHourA = new System.Windows.Forms.Label();
            this.labeNumerOfBoxToProduceA = new System.Windows.Forms.Label();
            this.tabPageTypeB = new System.Windows.Forms.TabPage();
            this.textBoxDefaultRateBeginStartB = new System.Windows.Forms.TextBox();
            this.textBoxRateDefaultPerHourB = new System.Windows.Forms.TextBox();
            this.textBoxNumberOfBoxProducedB = new System.Windows.Forms.TextBox();
            this.labelDefaultRateBeginStartB = new System.Windows.Forms.Label();
            this.labelRateDefaultPerHourB = new System.Windows.Forms.Label();
            this.labelOfBoxToProduceB = new System.Windows.Forms.Label();
            this.tabPageTypeC = new System.Windows.Forms.TabPage();
            this.textBoxDefaultRateBeginStartC = new System.Windows.Forms.TextBox();
            this.textBoxRateDefaultPerHourC = new System.Windows.Forms.TextBox();
            this.textBoxNumberOfBoxProducedC = new System.Windows.Forms.TextBox();
            this.labelDefaultRateBeginStartC = new System.Windows.Forms.Label();
            this.labelRateDefaultPerHourC = new System.Windows.Forms.Label();
            this.labelOfBoxToProduceC = new System.Windows.Forms.Label();
            this.labelProductionA = new System.Windows.Forms.Label();
            this.labelProductionB = new System.Windows.Forms.Label();
            this.labelProductionC = new System.Windows.Forms.Label();
            this.progressBarProductionA = new System.Windows.Forms.ProgressBar();
            this.progressBarProductionB = new System.Windows.Forms.ProgressBar();
            this.progressBarProductionC = new System.Windows.Forms.ProgressBar();
            this.menuStrip1.SuspendLayout();
            this.tabControlType.SuspendLayout();
            this.tabPageTypeA.SuspendLayout();
            this.tabPageTypeB.SuspendLayout();
            this.tabPageTypeC.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.productionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(575, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemExit});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(111, 22);
            this.toolStripMenuItemExit.Text = "Quitter";
            this.toolStripMenuItemExit.Click += new System.EventHandler(this.ToolStripMenuItemExit_Click);
            // 
            // productionToolStripMenuItem
            // 
            this.productionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startProductionToolStripMenuItem,
            this.StopProductionToolStripMenuItem,
            this.continueProductionToolStripMenuItem});
            this.productionToolStripMenuItem.Name = "productionToolStripMenuItem";
            this.productionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.productionToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.productionToolStripMenuItem.Text = "Production";
            // 
            // startProductionToolStripMenuItem
            // 
            this.startProductionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemStartA,
            this.toolStripMenuItemStartB,
            this.toolStripMenuItemStartC});
            this.startProductionToolStripMenuItem.Name = "startProductionToolStripMenuItem";
            this.startProductionToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.startProductionToolStripMenuItem.Text = "Demarrer";
            // 
            // toolStripMenuItemStartA
            // 
            this.toolStripMenuItemStartA.Name = "toolStripMenuItemStartA";
            this.toolStripMenuItemStartA.Size = new System.Drawing.Size(82, 22);
            this.toolStripMenuItemStartA.Text = "A";
            this.toolStripMenuItemStartA.Click += new System.EventHandler(this.ToolStripMenuItemStart_Click);
            // 
            // toolStripMenuItemStartB
            // 
            this.toolStripMenuItemStartB.Name = "toolStripMenuItemStartB";
            this.toolStripMenuItemStartB.Size = new System.Drawing.Size(82, 22);
            this.toolStripMenuItemStartB.Text = "B";
            this.toolStripMenuItemStartB.Click += new System.EventHandler(this.ToolStripMenuItemStart_Click);
            // 
            // toolStripMenuItemStartC
            // 
            this.toolStripMenuItemStartC.Name = "toolStripMenuItemStartC";
            this.toolStripMenuItemStartC.Size = new System.Drawing.Size(82, 22);
            this.toolStripMenuItemStartC.Text = "C";
            this.toolStripMenuItemStartC.Click += new System.EventHandler(this.ToolStripMenuItemStart_Click);
            // 
            // StopProductionToolStripMenuItem
            // 
            this.StopProductionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemStopA,
            this.toolStripMenuItemStopB,
            this.toolStripMenuItemStopC});
            this.StopProductionToolStripMenuItem.Name = "StopProductionToolStripMenuItem";
            this.StopProductionToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.StopProductionToolStripMenuItem.Text = "Arreter";
            // 
            // toolStripMenuItemStopA
            // 
            this.toolStripMenuItemStopA.Enabled = false;
            this.toolStripMenuItemStopA.Name = "toolStripMenuItemStopA";
            this.toolStripMenuItemStopA.Size = new System.Drawing.Size(82, 22);
            this.toolStripMenuItemStopA.Text = "A";
            this.toolStripMenuItemStopA.Click += new System.EventHandler(this.ToolStripMenuItemStop_Click);
            // 
            // toolStripMenuItemStopB
            // 
            this.toolStripMenuItemStopB.Enabled = false;
            this.toolStripMenuItemStopB.Name = "toolStripMenuItemStopB";
            this.toolStripMenuItemStopB.Size = new System.Drawing.Size(82, 22);
            this.toolStripMenuItemStopB.Text = "B";
            this.toolStripMenuItemStopB.Click += new System.EventHandler(this.ToolStripMenuItemStop_Click);
            // 
            // toolStripMenuItemStopC
            // 
            this.toolStripMenuItemStopC.Enabled = false;
            this.toolStripMenuItemStopC.Name = "toolStripMenuItemStopC";
            this.toolStripMenuItemStopC.Size = new System.Drawing.Size(82, 22);
            this.toolStripMenuItemStopC.Text = "C";
            this.toolStripMenuItemStopC.Click += new System.EventHandler(this.ToolStripMenuItemStop_Click);
            // 
            // continueProductionToolStripMenuItem
            // 
            this.continueProductionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemContinueA,
            this.toolStripMenuItemContinueB,
            this.toolStripMenuItemContinueC});
            this.continueProductionToolStripMenuItem.Name = "continueProductionToolStripMenuItem";
            this.continueProductionToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.continueProductionToolStripMenuItem.Text = "Continuer";
            this.continueProductionToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItemResume_Click);
            // 
            // toolStripMenuItemContinueA
            // 
            this.toolStripMenuItemContinueA.Enabled = false;
            this.toolStripMenuItemContinueA.Name = "toolStripMenuItemContinueA";
            this.toolStripMenuItemContinueA.Size = new System.Drawing.Size(82, 22);
            this.toolStripMenuItemContinueA.Text = "A";
            this.toolStripMenuItemContinueA.Click += new System.EventHandler(this.ToolStripMenuItemResume_Click);
            // 
            // toolStripMenuItemContinueB
            // 
            this.toolStripMenuItemContinueB.Enabled = false;
            this.toolStripMenuItemContinueB.Name = "toolStripMenuItemContinueB";
            this.toolStripMenuItemContinueB.Size = new System.Drawing.Size(82, 22);
            this.toolStripMenuItemContinueB.Text = "B";
            this.toolStripMenuItemContinueB.Click += new System.EventHandler(this.ToolStripMenuItemResume_Click);
            // 
            // toolStripMenuItemContinueC
            // 
            this.toolStripMenuItemContinueC.Enabled = false;
            this.toolStripMenuItemContinueC.Name = "toolStripMenuItemContinueC";
            this.toolStripMenuItemContinueC.Size = new System.Drawing.Size(82, 22);
            this.toolStripMenuItemContinueC.Text = "C";
            this.toolStripMenuItemContinueC.Click += new System.EventHandler(this.ToolStripMenuItemResume_Click);
            // 
            // tabControlType
            // 
            this.tabControlType.Controls.Add(this.tabPageTypeA);
            this.tabControlType.Controls.Add(this.tabPageTypeB);
            this.tabControlType.Controls.Add(this.tabPageTypeC);
            this.tabControlType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlType.Location = new System.Drawing.Point(16, 56);
            this.tabControlType.Name = "tabControlType";
            this.tabControlType.SelectedIndex = 0;
            this.tabControlType.Size = new System.Drawing.Size(529, 170);
            this.tabControlType.TabIndex = 1;
            // 
            // tabPageTypeA
            // 
            this.tabPageTypeA.Controls.Add(this.textBoxDefaultRateBeginStartA);
            this.tabPageTypeA.Controls.Add(this.textBoxRateDefaultPerHourA);
            this.tabPageTypeA.Controls.Add(this.textBoxNumberOfBoxProducedA);
            this.tabPageTypeA.Controls.Add(this.labelDefaultRateBeginStartA);
            this.tabPageTypeA.Controls.Add(this.labelRateDefaultPerHourA);
            this.tabPageTypeA.Controls.Add(this.labeNumerOfBoxToProduceA);
            this.tabPageTypeA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageTypeA.Location = new System.Drawing.Point(4, 29);
            this.tabPageTypeA.Name = "tabPageTypeA";
            this.tabPageTypeA.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTypeA.Size = new System.Drawing.Size(521, 137);
            this.tabPageTypeA.TabIndex = 0;
            this.tabPageTypeA.Text = "Type A";
            this.tabPageTypeA.UseVisualStyleBackColor = true;
            // 
            // textBoxDefaultRateBeginStartA
            // 
            this.textBoxDefaultRateBeginStartA.Location = new System.Drawing.Point(335, 83);
            this.textBoxDefaultRateBeginStartA.Name = "textBoxDefaultRateBeginStartA";
            this.textBoxDefaultRateBeginStartA.Size = new System.Drawing.Size(100, 26);
            this.textBoxDefaultRateBeginStartA.TabIndex = 5;
            // 
            // textBoxRateDefaultPerHourA
            // 
            this.textBoxRateDefaultPerHourA.Location = new System.Drawing.Point(335, 49);
            this.textBoxRateDefaultPerHourA.Name = "textBoxRateDefaultPerHourA";
            this.textBoxRateDefaultPerHourA.Size = new System.Drawing.Size(100, 26);
            this.textBoxRateDefaultPerHourA.TabIndex = 4;
            // 
            // textBoxNumberOfBoxProducedA
            // 
            this.textBoxNumberOfBoxProducedA.Location = new System.Drawing.Point(335, 18);
            this.textBoxNumberOfBoxProducedA.Name = "textBoxNumberOfBoxProducedA";
            this.textBoxNumberOfBoxProducedA.Size = new System.Drawing.Size(100, 26);
            this.textBoxNumberOfBoxProducedA.TabIndex = 3;
            // 
            // labelDefaultRateBeginStartA
            // 
            this.labelDefaultRateBeginStartA.AutoSize = true;
            this.labelDefaultRateBeginStartA.Location = new System.Drawing.Point(6, 84);
            this.labelDefaultRateBeginStartA.Name = "labelDefaultRateBeginStartA";
            this.labelDefaultRateBeginStartA.Size = new System.Drawing.Size(225, 20);
            this.labelDefaultRateBeginStartA.TabIndex = 2;
            this.labelDefaultRateBeginStartA.Text = "Taux défaut depuis démarrage";
            // 
            // labelRateDefaultPerHourA
            // 
            this.labelRateDefaultPerHourA.AutoSize = true;
            this.labelRateDefaultPerHourA.Location = new System.Drawing.Point(7, 50);
            this.labelRateDefaultPerHourA.Name = "labelRateDefaultPerHourA";
            this.labelRateDefaultPerHourA.Size = new System.Drawing.Size(138, 20);
            this.labelRateDefaultPerHourA.TabIndex = 1;
            this.labelRateDefaultPerHourA.Text = "Taux défaut heure";
            // 
            // labeNumerOfBoxToProduceA
            // 
            this.labeNumerOfBoxToProduceA.AutoSize = true;
            this.labeNumerOfBoxToProduceA.Location = new System.Drawing.Point(7, 18);
            this.labeNumerOfBoxToProduceA.Name = "labeNumerOfBoxToProduceA";
            this.labeNumerOfBoxToProduceA.Size = new System.Drawing.Size(284, 20);
            this.labeNumerOfBoxToProduceA.TabIndex = 0;
            this.labeNumerOfBoxToProduceA.Text = "Nombre de caisse depuis le démarrage";
            // 
            // tabPageTypeB
            // 
            this.tabPageTypeB.Controls.Add(this.textBoxDefaultRateBeginStartB);
            this.tabPageTypeB.Controls.Add(this.textBoxRateDefaultPerHourB);
            this.tabPageTypeB.Controls.Add(this.textBoxNumberOfBoxProducedB);
            this.tabPageTypeB.Controls.Add(this.labelDefaultRateBeginStartB);
            this.tabPageTypeB.Controls.Add(this.labelRateDefaultPerHourB);
            this.tabPageTypeB.Controls.Add(this.labelOfBoxToProduceB);
            this.tabPageTypeB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageTypeB.Location = new System.Drawing.Point(4, 29);
            this.tabPageTypeB.Name = "tabPageTypeB";
            this.tabPageTypeB.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTypeB.Size = new System.Drawing.Size(521, 137);
            this.tabPageTypeB.TabIndex = 1;
            this.tabPageTypeB.Text = "Type B";
            this.tabPageTypeB.UseVisualStyleBackColor = true;
            // 
            // textBoxDefaultRateBeginStartB
            // 
            this.textBoxDefaultRateBeginStartB.Location = new System.Drawing.Point(335, 83);
            this.textBoxDefaultRateBeginStartB.Name = "textBoxDefaultRateBeginStartB";
            this.textBoxDefaultRateBeginStartB.Size = new System.Drawing.Size(100, 26);
            this.textBoxDefaultRateBeginStartB.TabIndex = 11;
            // 
            // textBoxRateDefaultPerHourB
            // 
            this.textBoxRateDefaultPerHourB.Location = new System.Drawing.Point(335, 49);
            this.textBoxRateDefaultPerHourB.Name = "textBoxRateDefaultPerHourB";
            this.textBoxRateDefaultPerHourB.Size = new System.Drawing.Size(100, 26);
            this.textBoxRateDefaultPerHourB.TabIndex = 10;
            // 
            // textBoxNumberOfBoxProducedB
            // 
            this.textBoxNumberOfBoxProducedB.Location = new System.Drawing.Point(335, 18);
            this.textBoxNumberOfBoxProducedB.Name = "textBoxNumberOfBoxProducedB";
            this.textBoxNumberOfBoxProducedB.Size = new System.Drawing.Size(100, 26);
            this.textBoxNumberOfBoxProducedB.TabIndex = 9;
            // 
            // labelDefaultRateBeginStartB
            // 
            this.labelDefaultRateBeginStartB.AutoSize = true;
            this.labelDefaultRateBeginStartB.Location = new System.Drawing.Point(6, 84);
            this.labelDefaultRateBeginStartB.Name = "labelDefaultRateBeginStartB";
            this.labelDefaultRateBeginStartB.Size = new System.Drawing.Size(225, 20);
            this.labelDefaultRateBeginStartB.TabIndex = 8;
            this.labelDefaultRateBeginStartB.Text = "Taux défaut depuis démarrage";
            // 
            // labelRateDefaultPerHourB
            // 
            this.labelRateDefaultPerHourB.AutoSize = true;
            this.labelRateDefaultPerHourB.Location = new System.Drawing.Point(7, 50);
            this.labelRateDefaultPerHourB.Name = "labelRateDefaultPerHourB";
            this.labelRateDefaultPerHourB.Size = new System.Drawing.Size(138, 20);
            this.labelRateDefaultPerHourB.TabIndex = 7;
            this.labelRateDefaultPerHourB.Text = "Taux défaut heure";
            // 
            // labelOfBoxToProduceB
            // 
            this.labelOfBoxToProduceB.AutoSize = true;
            this.labelOfBoxToProduceB.Location = new System.Drawing.Point(7, 18);
            this.labelOfBoxToProduceB.Name = "labelOfBoxToProduceB";
            this.labelOfBoxToProduceB.Size = new System.Drawing.Size(284, 20);
            this.labelOfBoxToProduceB.TabIndex = 6;
            this.labelOfBoxToProduceB.Text = "Nombre de caisse depuis le démarrage";
            // 
            // tabPageTypeC
            // 
            this.tabPageTypeC.Controls.Add(this.textBoxDefaultRateBeginStartC);
            this.tabPageTypeC.Controls.Add(this.textBoxRateDefaultPerHourC);
            this.tabPageTypeC.Controls.Add(this.textBoxNumberOfBoxProducedC);
            this.tabPageTypeC.Controls.Add(this.labelDefaultRateBeginStartC);
            this.tabPageTypeC.Controls.Add(this.labelRateDefaultPerHourC);
            this.tabPageTypeC.Controls.Add(this.labelOfBoxToProduceC);
            this.tabPageTypeC.Location = new System.Drawing.Point(4, 29);
            this.tabPageTypeC.Name = "tabPageTypeC";
            this.tabPageTypeC.Size = new System.Drawing.Size(521, 137);
            this.tabPageTypeC.TabIndex = 2;
            this.tabPageTypeC.Text = "Type C";
            this.tabPageTypeC.UseVisualStyleBackColor = true;
            // 
            // textBoxDefaultRateBeginStartC
            // 
            this.textBoxDefaultRateBeginStartC.Location = new System.Drawing.Point(335, 83);
            this.textBoxDefaultRateBeginStartC.Name = "textBoxDefaultRateBeginStartC";
            this.textBoxDefaultRateBeginStartC.Size = new System.Drawing.Size(100, 26);
            this.textBoxDefaultRateBeginStartC.TabIndex = 17;
            // 
            // textBoxRateDefaultPerHourC
            // 
            this.textBoxRateDefaultPerHourC.Location = new System.Drawing.Point(335, 49);
            this.textBoxRateDefaultPerHourC.Name = "textBoxRateDefaultPerHourC";
            this.textBoxRateDefaultPerHourC.Size = new System.Drawing.Size(100, 26);
            this.textBoxRateDefaultPerHourC.TabIndex = 16;
            // 
            // textBoxNumberOfBoxProducedC
            // 
            this.textBoxNumberOfBoxProducedC.Location = new System.Drawing.Point(335, 18);
            this.textBoxNumberOfBoxProducedC.Name = "textBoxNumberOfBoxProducedC";
            this.textBoxNumberOfBoxProducedC.Size = new System.Drawing.Size(100, 26);
            this.textBoxNumberOfBoxProducedC.TabIndex = 15;
            // 
            // labelDefaultRateBeginStartC
            // 
            this.labelDefaultRateBeginStartC.AutoSize = true;
            this.labelDefaultRateBeginStartC.Location = new System.Drawing.Point(6, 84);
            this.labelDefaultRateBeginStartC.Name = "labelDefaultRateBeginStartC";
            this.labelDefaultRateBeginStartC.Size = new System.Drawing.Size(225, 20);
            this.labelDefaultRateBeginStartC.TabIndex = 14;
            this.labelDefaultRateBeginStartC.Text = "Taux défaut depuis démarrage";
            // 
            // labelRateDefaultPerHourC
            // 
            this.labelRateDefaultPerHourC.AutoSize = true;
            this.labelRateDefaultPerHourC.Location = new System.Drawing.Point(7, 50);
            this.labelRateDefaultPerHourC.Name = "labelRateDefaultPerHourC";
            this.labelRateDefaultPerHourC.Size = new System.Drawing.Size(138, 20);
            this.labelRateDefaultPerHourC.TabIndex = 13;
            this.labelRateDefaultPerHourC.Text = "Taux défaut heure";
            // 
            // labelOfBoxToProduceC
            // 
            this.labelOfBoxToProduceC.AutoSize = true;
            this.labelOfBoxToProduceC.Location = new System.Drawing.Point(7, 18);
            this.labelOfBoxToProduceC.Name = "labelOfBoxToProduceC";
            this.labelOfBoxToProduceC.Size = new System.Drawing.Size(284, 20);
            this.labelOfBoxToProduceC.TabIndex = 12;
            this.labelOfBoxToProduceC.Text = "Nombre de caisse depuis le démarrage";
            // 
            // labelProductionA
            // 
            this.labelProductionA.AutoSize = true;
            this.labelProductionA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductionA.Location = new System.Drawing.Point(12, 266);
            this.labelProductionA.Name = "labelProductionA";
            this.labelProductionA.Size = new System.Drawing.Size(100, 20);
            this.labelProductionA.TabIndex = 2;
            this.labelProductionA.Text = "Production A";
            // 
            // labelProductionB
            // 
            this.labelProductionB.AutoSize = true;
            this.labelProductionB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductionB.Location = new System.Drawing.Point(12, 304);
            this.labelProductionB.Name = "labelProductionB";
            this.labelProductionB.Size = new System.Drawing.Size(100, 20);
            this.labelProductionB.TabIndex = 3;
            this.labelProductionB.Text = "Production B";
            // 
            // labelProductionC
            // 
            this.labelProductionC.AutoSize = true;
            this.labelProductionC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductionC.Location = new System.Drawing.Point(12, 338);
            this.labelProductionC.Name = "labelProductionC";
            this.labelProductionC.Size = new System.Drawing.Size(100, 20);
            this.labelProductionC.TabIndex = 4;
            this.labelProductionC.Text = "Production C";
            // 
            // progressBarProductionA
            // 
            this.progressBarProductionA.Location = new System.Drawing.Point(216, 266);
            this.progressBarProductionA.Name = "progressBarProductionA";
            this.progressBarProductionA.Size = new System.Drawing.Size(325, 29);
            this.progressBarProductionA.Step = 1;
            this.progressBarProductionA.TabIndex = 5;
            // 
            // progressBarProductionB
            // 
            this.progressBarProductionB.Location = new System.Drawing.Point(216, 302);
            this.progressBarProductionB.Name = "progressBarProductionB";
            this.progressBarProductionB.Size = new System.Drawing.Size(325, 29);
            this.progressBarProductionB.Step = 1;
            this.progressBarProductionB.TabIndex = 6;
            // 
            // progressBarProductionC
            // 
            this.progressBarProductionC.Location = new System.Drawing.Point(216, 338);
            this.progressBarProductionC.Name = "progressBarProductionC";
            this.progressBarProductionC.Size = new System.Drawing.Size(325, 29);
            this.progressBarProductionC.Step = 1;
            this.progressBarProductionC.TabIndex = 7;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 450);
            this.Controls.Add(this.progressBarProductionC);
            this.Controls.Add(this.progressBarProductionB);
            this.Controls.Add(this.progressBarProductionA);
            this.Controls.Add(this.labelProductionC);
            this.Controls.Add(this.labelProductionB);
            this.Controls.Add(this.labelProductionA);
            this.Controls.Add(this.tabControlType);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Production de caisse";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_Closing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControlType.ResumeLayout(false);
            this.tabPageTypeA.ResumeLayout(false);
            this.tabPageTypeA.PerformLayout();
            this.tabPageTypeB.ResumeLayout(false);
            this.tabPageTypeB.PerformLayout();
            this.tabPageTypeC.ResumeLayout(false);
            this.tabPageTypeC.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startProductionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StopProductionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem continueProductionToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControlType;
        private System.Windows.Forms.TabPage tabPageTypeA;
        private System.Windows.Forms.TabPage tabPageTypeB;
        private System.Windows.Forms.TabPage tabPageTypeC;
        private System.Windows.Forms.Label labelProductionA;
        private System.Windows.Forms.Label labelProductionB;
        private System.Windows.Forms.Label labelProductionC;
        private System.Windows.Forms.ProgressBar progressBarProductionA;
        private System.Windows.Forms.ProgressBar progressBarProductionB;
        private System.Windows.Forms.ProgressBar progressBarProductionC;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStartA;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStartB;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStartC;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStopA;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStopB;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStopC;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemContinueB;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemContinueC;
        private System.Windows.Forms.Label labeNumerOfBoxToProduceA;
        private System.Windows.Forms.Label labelRateDefaultPerHourA;
        private System.Windows.Forms.Label labelDefaultRateBeginStartA;
        private System.Windows.Forms.TextBox textBoxDefaultRateBeginStartA;
        private System.Windows.Forms.TextBox textBoxRateDefaultPerHourA;
        private System.Windows.Forms.TextBox textBoxNumberOfBoxProducedA;
        private System.Windows.Forms.Label labelDefaultRateBeginStartB;
        private System.Windows.Forms.Label labelRateDefaultPerHourB;
        private System.Windows.Forms.Label labelOfBoxToProduceB;
        private System.Windows.Forms.TextBox textBoxDefaultRateBeginStartB;
        private System.Windows.Forms.TextBox textBoxRateDefaultPerHourB;
        private System.Windows.Forms.TextBox textBoxNumberOfBoxProducedB;
        private System.Windows.Forms.TextBox textBoxDefaultRateBeginStartC;
        private System.Windows.Forms.TextBox textBoxRateDefaultPerHourC;
        private System.Windows.Forms.TextBox textBoxNumberOfBoxProducedC;
        private System.Windows.Forms.Label labelDefaultRateBeginStartC;
        private System.Windows.Forms.Label labelRateDefaultPerHourC;
        private System.Windows.Forms.Label labelOfBoxToProduceC;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemContinueA;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
    }
}

