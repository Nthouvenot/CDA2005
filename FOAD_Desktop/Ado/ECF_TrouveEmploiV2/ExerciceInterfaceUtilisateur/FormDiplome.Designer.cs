namespace ExerciceInterfaceUtilisateur
{
    partial class FormDiplome
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
            this.comboBoxDiplomes = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDateDobtention = new System.Windows.Forms.DateTimePicker();
            this.buttonValider = new System.Windows.Forms.Button();
            this.labelDateDobtention = new System.Windows.Forms.Label();
            this.labelNiveau = new System.Windows.Forms.Label();
            this.errorProviderDate = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDate)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxDiplomes
            // 
            this.comboBoxDiplomes.FormattingEnabled = true;
            this.comboBoxDiplomes.Location = new System.Drawing.Point(169, 40);
            this.comboBoxDiplomes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxDiplomes.Name = "comboBoxDiplomes";
            this.comboBoxDiplomes.Size = new System.Drawing.Size(94, 21);
            this.comboBoxDiplomes.TabIndex = 0;
            // 
            // dateTimePickerDateDobtention
            // 
            this.dateTimePickerDateDobtention.Location = new System.Drawing.Point(19, 40);
            this.dateTimePickerDateDobtention.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerDateDobtention.Name = "dateTimePickerDateDobtention";
            this.dateTimePickerDateDobtention.Size = new System.Drawing.Size(135, 20);
            this.dateTimePickerDateDobtention.TabIndex = 1;
            this.dateTimePickerDateDobtention.ValueChanged += new System.EventHandler(this.DateTimePickerDateDobtention_ValueChanged);
            // 
            // buttonValider
            // 
            this.buttonValider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonValider.Location = new System.Drawing.Point(193, 70);
            this.buttonValider.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(75, 23);
            this.buttonValider.TabIndex = 2;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.ButtonValider_Click);
            // 
            // labelDateDobtention
            // 
            this.labelDateDobtention.AutoSize = true;
            this.labelDateDobtention.Location = new System.Drawing.Point(16, 17);
            this.labelDateDobtention.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDateDobtention.Name = "labelDateDobtention";
            this.labelDateDobtention.Size = new System.Drawing.Size(85, 13);
            this.labelDateDobtention.TabIndex = 3;
            this.labelDateDobtention.Text = "Date d\'obtention";
            // 
            // labelNiveau
            // 
            this.labelNiveau.AutoSize = true;
            this.labelNiveau.Location = new System.Drawing.Point(167, 16);
            this.labelNiveau.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNiveau.Name = "labelNiveau";
            this.labelNiveau.Size = new System.Drawing.Size(97, 13);
            this.labelNiveau.TabIndex = 4;
            this.labelNiveau.Text = "Niveau du Diplome";
            // 
            // errorProviderDate
            // 
            this.errorProviderDate.ContainerControl = this;
            // 
            // FormDiplome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 101);
            this.Controls.Add(this.labelNiveau);
            this.Controls.Add(this.labelDateDobtention);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.dateTimePickerDateDobtention);
            this.Controls.Add(this.comboBoxDiplomes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormDiplome";
            this.Text = "Ajouter un Diplome";
            this.Load += new System.EventHandler(this.FormDiplome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDiplomes;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateDobtention;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Label labelDateDobtention;
        private System.Windows.Forms.Label labelNiveau;
        private System.Windows.Forms.ErrorProvider errorProviderDate;
    }
}