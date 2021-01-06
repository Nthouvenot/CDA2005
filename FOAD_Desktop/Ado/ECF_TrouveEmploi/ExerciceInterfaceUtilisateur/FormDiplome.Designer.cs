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
            this.comboBoxDiplomes = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDateDobtention = new System.Windows.Forms.DateTimePicker();
            this.buttonValider = new System.Windows.Forms.Button();
            this.labelDateDobtention = new System.Windows.Forms.Label();
            this.labelNiveau = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxDiplomes
            // 
            this.comboBoxDiplomes.FormattingEnabled = true;
            this.comboBoxDiplomes.Location = new System.Drawing.Point(253, 62);
            this.comboBoxDiplomes.Name = "comboBoxDiplomes";
            this.comboBoxDiplomes.Size = new System.Drawing.Size(139, 28);
            this.comboBoxDiplomes.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePickerDateDobtention.Location = new System.Drawing.Point(28, 62);
            this.dateTimePickerDateDobtention.Name = "dateTimePicker1";
            this.dateTimePickerDateDobtention.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerDateDobtention.TabIndex = 1;
            // 
            // buttonValider
            // 
            this.buttonValider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonValider.Location = new System.Drawing.Point(290, 108);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(112, 35);
            this.buttonValider.TabIndex = 2;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // labelDateDobtention
            // 
            this.labelDateDobtention.AutoSize = true;
            this.labelDateDobtention.Location = new System.Drawing.Point(24, 26);
            this.labelDateDobtention.Name = "labelDateDobtention";
            this.labelDateDobtention.Size = new System.Drawing.Size(127, 20);
            this.labelDateDobtention.TabIndex = 3;
            this.labelDateDobtention.Text = "Date d\'obtention";
            // 
            // labelNiveau
            // 
            this.labelNiveau.AutoSize = true;
            this.labelNiveau.Location = new System.Drawing.Point(251, 25);
            this.labelNiveau.Name = "labelNiveau";
            this.labelNiveau.Size = new System.Drawing.Size(141, 20);
            this.labelNiveau.TabIndex = 4;
            this.labelNiveau.Text = "Niveau du Diplome";
            // 
            // FormDiplome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 155);
            this.Controls.Add(this.labelNiveau);
            this.Controls.Add(this.labelDateDobtention);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.dateTimePickerDateDobtention);
            this.Controls.Add(this.comboBoxDiplomes);
            this.Name = "FormDiplome";
            this.Text = "Ajouter un Diplome";
            this.Load += new System.EventHandler(this.FormDiplome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDiplomes;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateDobtention;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Label labelDateDobtention;
        private System.Windows.Forms.Label labelNiveau;
    }
}