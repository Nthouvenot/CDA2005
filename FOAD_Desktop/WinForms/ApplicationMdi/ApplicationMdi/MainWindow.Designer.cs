
namespace ApplicationMdi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.identificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorConnexion = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stage1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stage2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stage3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.casesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scrollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorStage3 = new System.Windows.Forms.ToolStripSeparator();
            this.summaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorWIndow = new System.Windows.Forms.ToolStripSeparator();
            this.EnterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonIdentification = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButtonStage3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.separatorStatusStrip = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripStatusLabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerDateHour = new System.Windows.Forms.Timer(this.components);
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ApplicationToolStripMenuItem,
            this.stage1ToolStripMenuItem,
            this.stage2ToolStripMenuItem,
            this.stage3ToolStripMenuItem,
            this.WindowToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(1200, 31);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // ApplicationToolStripMenuItem
            // 
            this.ApplicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.identificationToolStripMenuItem,
            this.toolStripSeparatorConnexion,
            this.ExitToolStripMenuItem});
            this.ApplicationToolStripMenuItem.Name = "ApplicationToolStripMenuItem";
            this.ApplicationToolStripMenuItem.Size = new System.Drawing.Size(101, 25);
            this.ApplicationToolStripMenuItem.Text = "Connection";
            // 
            // identificationToolStripMenuItem
            // 
            this.identificationToolStripMenuItem.Name = "identificationToolStripMenuItem";
            this.identificationToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.identificationToolStripMenuItem.Text = "S\'identifier";
            this.identificationToolStripMenuItem.Click += new System.EventHandler(this.Connexion_Click);
            // 
            // toolStripSeparatorConnexion
            // 
            this.toolStripSeparatorConnexion.Name = "toolStripSeparatorConnexion";
            this.toolStripSeparatorConnexion.Size = new System.Drawing.Size(152, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.ExitToolStripMenuItem.Text = "Quitter";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // stage1ToolStripMenuItem
            // 
            this.stage1ToolStripMenuItem.Name = "stage1ToolStripMenuItem";
            this.stage1ToolStripMenuItem.Size = new System.Drawing.Size(76, 25);
            this.stage1ToolStripMenuItem.Text = "Phase 1";
            this.stage1ToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // stage2ToolStripMenuItem
            // 
            this.stage2ToolStripMenuItem.Name = "stage2ToolStripMenuItem";
            this.stage2ToolStripMenuItem.Size = new System.Drawing.Size(76, 25);
            this.stage2ToolStripMenuItem.Text = "Phase 2";
            this.stage2ToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // stage3ToolStripMenuItem
            // 
            this.stage3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.casesToolStripMenuItem,
            this.comboBoxToolStripMenuItem,
            this.scrollToolStripMenuItem,
            this.toolStripSeparatorStage3,
            this.summaryToolStripMenuItem});
            this.stage3ToolStripMenuItem.Name = "stage3ToolStripMenuItem";
            this.stage3ToolStripMenuItem.Size = new System.Drawing.Size(76, 25);
            this.stage3ToolStripMenuItem.Text = "Phase 3";
            // 
            // casesToolStripMenuItem
            // 
            this.casesToolStripMenuItem.Name = "casesToolStripMenuItem";
            this.casesToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.casesToolStripMenuItem.Text = "Cases";
            this.casesToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // comboBoxToolStripMenuItem
            // 
            this.comboBoxToolStripMenuItem.Name = "comboBoxToolStripMenuItem";
            this.comboBoxToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.comboBoxToolStripMenuItem.Text = "ComboBox";
            this.comboBoxToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // scrollToolStripMenuItem
            // 
            this.scrollToolStripMenuItem.Name = "scrollToolStripMenuItem";
            this.scrollToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.scrollToolStripMenuItem.Text = "Défilement";
            this.scrollToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // toolStripSeparatorStage3
            // 
            this.toolStripSeparatorStage3.Name = "toolStripSeparatorStage3";
            this.toolStripSeparatorStage3.Size = new System.Drawing.Size(153, 6);
            // 
            // summaryToolStripMenuItem
            // 
            this.summaryToolStripMenuItem.Name = "summaryToolStripMenuItem";
            this.summaryToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.summaryToolStripMenuItem.Text = "Synthése";
            this.summaryToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // WindowToolStripMenuItem
            // 
            this.WindowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.horizontalToolStripMenuItem,
            this.verticalToolStripMenuItem,
            this.toolStripSeparatorWIndow,
            this.EnterToolStripMenuItem});
            this.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem";
            this.WindowToolStripMenuItem.Size = new System.Drawing.Size(81, 25);
            this.WindowToolStripMenuItem.Text = "Fenêtres";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.cascadeToolStripMenuItem.Text = "Cascade";
            // 
            // horizontalToolStripMenuItem
            // 
            this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.horizontalToolStripMenuItem.Text = "Horizontal";
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.verticalToolStripMenuItem.Text = "Vertical";
            // 
            // toolStripSeparatorWIndow
            // 
            this.toolStripSeparatorWIndow.Name = "toolStripSeparatorWIndow";
            this.toolStripSeparatorWIndow.Size = new System.Drawing.Size(149, 6);
            // 
            // EnterToolStripMenuItem
            // 
            this.EnterToolStripMenuItem.CheckOnClick = true;
            this.EnterToolStripMenuItem.Name = "EnterToolStripMenuItem";
            this.EnterToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.EnterToolStripMenuItem.Text = "1 Saisie";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonIdentification,
            this.toolStripDropDownButtonStage3});
            this.toolStrip.Location = new System.Drawing.Point(0, 31);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip.Size = new System.Drawing.Size(1200, 28);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripButtonIdentification
            // 
            this.toolStripButtonIdentification.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonIdentification.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonIdentification.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonIdentification.Name = "toolStripButtonIdentification";
            this.toolStripButtonIdentification.Size = new System.Drawing.Size(89, 25);
            this.toolStripButtonIdentification.Text = "S\'identifier";
            this.toolStripButtonIdentification.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolStripButtonIdentification.Click += new System.EventHandler(this.Connexion_Click);
            // 
            // toolStripDropDownButtonStage3
            // 
            this.toolStripDropDownButtonStage3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonStage3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1});
            this.toolStripDropDownButtonStage3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripDropDownButtonStage3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonStage3.Image")));
            this.toolStripDropDownButtonStage3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonStage3.Name = "toolStripDropDownButtonStage3";
            this.toolStripDropDownButtonStage3.Size = new System.Drawing.Size(77, 25);
            this.toolStripDropDownButtonStage3.Text = "Phase 3";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(57, 6);
            // 
            // statusStrip
            // 
            this.statusStrip.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelDate,
            this.separatorStatusStrip,
            this.toolStripStatusLabelStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 537);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1200, 25);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "heure";
            // 
            // toolStripStatusLabelDate
            // 
            this.toolStripStatusLabelDate.Name = "toolStripStatusLabelDate";
            this.toolStripStatusLabelDate.Size = new System.Drawing.Size(41, 20);
            this.toolStripStatusLabelDate.Text = "Date";
            // 
            // separatorStatusStrip
            // 
            this.separatorStatusStrip.Name = "separatorStatusStrip";
            this.separatorStatusStrip.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripStatusLabelStatus
            // 
            this.toolStripStatusLabelStatus.Name = "toolStripStatusLabelStatus";
            this.toolStripStatusLabelStatus.Size = new System.Drawing.Size(49, 20);
            this.toolStripStatusLabelStatus.Text = "Status";
            // 
            // timerDateHour
            // 
            this.timerDateHour.Enabled = true;
            this.timerDateHour.Tick += new System.EventHandler(this.timerDateHour_Tick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 562);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainWindow";
            this.Text = "Créer des formulaires";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_Closing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem ApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stage1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stage2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stage3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WindowToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonIdentification;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonStage3;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripMenuItem identificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorConnexion;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDate;
        private System.Windows.Forms.ToolStripSeparator separatorStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelStatus;
        private System.Windows.Forms.Timer timerDateHour;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorWIndow;
        private System.Windows.Forms.ToolStripMenuItem EnterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem casesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comboBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scrollToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorStage3;
        private System.Windows.Forms.ToolStripMenuItem summaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

