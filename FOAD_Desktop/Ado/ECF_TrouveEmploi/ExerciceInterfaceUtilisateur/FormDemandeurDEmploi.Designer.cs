namespace ExerciceInterfaceUtilisateur
{
    partial class FormDemandeurDEmploi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonValider = new System.Windows.Forms.Button();
            this.labelNom = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.labelNumeroSecuriteSocial = new System.Windows.Forms.Label();
            this.textBoxPuce = new System.Windows.Forms.TextBox();
            this.errorProviderPuce = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelDateDInscription = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonAjouterDiplome = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDiplome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPuce)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonValider
            // 
            this.buttonValider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonValider.Location = new System.Drawing.Point(342, 221);
            this.buttonValider.Margin = new System.Windows.Forms.Padding(2);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(75, 23);
            this.buttonValider.TabIndex = 0;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(18, 47);
            this.labelNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(29, 13);
            this.labelNom.TabIndex = 1;
            this.labelNom.Text = "Nom";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(64, 43);
            this.textBoxNom.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(99, 20);
            this.textBoxNom.TabIndex = 4;
            // 
            // labelNumeroSecuriteSocial
            // 
            this.labelNumeroSecuriteSocial.AutoSize = true;
            this.labelNumeroSecuriteSocial.Location = new System.Drawing.Point(18, 14);
            this.labelNumeroSecuriteSocial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumeroSecuriteSocial.Name = "labelNumeroSecuriteSocial";
            this.labelNumeroSecuriteSocial.Size = new System.Drawing.Size(57, 13);
            this.labelNumeroSecuriteSocial.TabIndex = 7;
            this.labelNumeroSecuriteSocial.Text = "Num Secu";
            // 
            // textBoxPuce
            // 
            this.textBoxPuce.Location = new System.Drawing.Point(79, 11);
            this.textBoxPuce.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPuce.MaxLength = 15;
            this.textBoxPuce.Multiline = true;
            this.textBoxPuce.Name = "textBoxPuce";
            this.textBoxPuce.Size = new System.Drawing.Size(227, 25);
            this.textBoxPuce.TabIndex = 8;
            // 
            // errorProviderPuce
            // 
            this.errorProviderPuce.ContainerControl = this;
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(213, 43);
            this.textBoxPrenom.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(95, 20);
            this.textBoxPrenom.TabIndex = 10;
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(165, 47);
            this.labelPrenom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(43, 13);
            this.labelPrenom.TabIndex = 9;
            this.labelPrenom.Text = "Prenom";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(130, 75);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(135, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // labelDateDInscription
            // 
            this.labelDateDInscription.AutoSize = true;
            this.labelDateDInscription.Location = new System.Drawing.Point(18, 78);
            this.labelDateDInscription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDateDInscription.Name = "labelDateDInscription";
            this.labelDateDInscription.Size = new System.Drawing.Size(89, 13);
            this.labelDateDInscription.TabIndex = 12;
            this.labelDateDInscription.Text = "Date d\'Inscription";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSupprimer);
            this.groupBox1.Controls.Add(this.buttonModifier);
            this.groupBox1.Controls.Add(this.buttonAjouterDiplome);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(8, 106);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(409, 109);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Diplomes obtenus";
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Enabled = false;
            this.buttonSupprimer.Location = new System.Drawing.Point(333, 77);
            this.buttonSupprimer.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(63, 25);
            this.buttonSupprimer.TabIndex = 20;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            // 
            // buttonModifier
            // 
            this.buttonModifier.Enabled = false;
            this.buttonModifier.Location = new System.Drawing.Point(333, 46);
            this.buttonModifier.Margin = new System.Windows.Forms.Padding(2);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(63, 27);
            this.buttonModifier.TabIndex = 19;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
            // 
            // buttonAjouterDiplome
            // 
            this.buttonAjouterDiplome.Location = new System.Drawing.Point(333, 15);
            this.buttonAjouterDiplome.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAjouterDiplome.Name = "buttonAjouterDiplome";
            this.buttonAjouterDiplome.Size = new System.Drawing.Size(63, 27);
            this.buttonAjouterDiplome.TabIndex = 18;
            this.buttonAjouterDiplome.Text = "Ajouter";
            this.buttonAjouterDiplome.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderDate,
            this.columnHeaderDiplome});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(11, 15);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(315, 87);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeaderDate
            // 
            this.columnHeaderDate.Text = "Date D\'Obtention";
            // 
            // columnHeaderDiplome
            // 
            this.columnHeaderDiplome.Text = "Diplome";
            // 
            // FormDemandeurDEmploi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 255);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelDateDInscription);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.textBoxPuce);
            this.Controls.Add(this.labelNumeroSecuriteSocial);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.buttonValider);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormDemandeurDEmploi";
            this.Text = "Créer un DemandeurDEmploi";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPuce)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label labelNumeroSecuriteSocial;
        private System.Windows.Forms.TextBox textBoxPuce;
        private System.Windows.Forms.ErrorProvider errorProviderPuce;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button buttonAjouterDiplome;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderDate;
        private System.Windows.Forms.ColumnHeader columnHeaderDiplome;
        private System.Windows.Forms.Label labelDateDInscription;
    }
}