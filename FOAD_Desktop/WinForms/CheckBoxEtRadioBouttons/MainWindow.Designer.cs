namespace CheckBoxEtRadioBouttons
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
            this.labelTyping = new System.Windows.Forms.Label();
            this.textBoxTyping = new System.Windows.Forms.TextBox();
            this.groupBoxChoice = new System.Windows.Forms.GroupBox();
            this.checkBoxCase = new System.Windows.Forms.CheckBox();
            this.checkBoxFontColor = new System.Windows.Forms.CheckBox();
            this.checkBoxBackgroundColor = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxBackgroudColor = new System.Windows.Forms.GroupBox();
            this.radioButtonBkgBlue = new System.Windows.Forms.RadioButton();
            this.radioButtonBkgGreen = new System.Windows.Forms.RadioButton();
            this.radioButtonBkgRed = new System.Windows.Forms.RadioButton();
            this.groupBoxFontColor = new System.Windows.Forms.GroupBox();
            this.radioButtonFontBlack = new System.Windows.Forms.RadioButton();
            this.radioButtonFontWhite = new System.Windows.Forms.RadioButton();
            this.radioButtonFontRed = new System.Windows.Forms.RadioButton();
            this.groupBoxCase = new System.Windows.Forms.GroupBox();
            this.radioButtonCaseLower = new System.Windows.Forms.RadioButton();
            this.radioButtonCaseUpper = new System.Windows.Forms.RadioButton();
            this.labelResultTyping = new System.Windows.Forms.Label();
            this.errorProviderTyping = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxChoice.SuspendLayout();
            this.groupBoxBackgroudColor.SuspendLayout();
            this.groupBoxFontColor.SuspendLayout();
            this.groupBoxCase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTyping)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTyping
            // 
            this.labelTyping.AutoSize = true;
            this.labelTyping.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTyping.Location = new System.Drawing.Point(13, 13);
            this.labelTyping.Name = "labelTyping";
            this.labelTyping.Size = new System.Drawing.Size(131, 20);
            this.labelTyping.TabIndex = 0;
            this.labelTyping.Text = "Tapez votre texte";
            // 
            // textBoxTyping
            // 
            this.textBoxTyping.Location = new System.Drawing.Point(13, 48);
            this.textBoxTyping.Name = "textBoxTyping";
            this.textBoxTyping.Size = new System.Drawing.Size(318, 20);
            this.textBoxTyping.TabIndex = 1;
            this.textBoxTyping.TextChanged += new System.EventHandler(this.textBoxTyping_TextChanged);
            // 
            // groupBoxChoice
            // 
            this.groupBoxChoice.Controls.Add(this.checkBoxCase);
            this.groupBoxChoice.Controls.Add(this.checkBoxFontColor);
            this.groupBoxChoice.Controls.Add(this.checkBoxBackgroundColor);
            this.groupBoxChoice.Enabled = false;
            this.groupBoxChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxChoice.Location = new System.Drawing.Point(360, 13);
            this.groupBoxChoice.Name = "groupBoxChoice";
            this.groupBoxChoice.Size = new System.Drawing.Size(228, 128);
            this.groupBoxChoice.TabIndex = 2;
            this.groupBoxChoice.TabStop = false;
            this.groupBoxChoice.Text = "Choix";
            // 
            // checkBoxCase
            // 
            this.checkBoxCase.AutoSize = true;
            this.checkBoxCase.Location = new System.Drawing.Point(18, 97);
            this.checkBoxCase.Name = "checkBoxCase";
            this.checkBoxCase.Size = new System.Drawing.Size(73, 24);
            this.checkBoxCase.TabIndex = 2;
            this.checkBoxCase.Text = "Casse";
            this.checkBoxCase.UseVisualStyleBackColor = true;
            this.checkBoxCase.CheckedChanged += new System.EventHandler(this.CheckBoxChoice_CheckedChanged);
            // 
            // checkBoxFontColor
            // 
            this.checkBoxFontColor.AutoSize = true;
            this.checkBoxFontColor.Location = new System.Drawing.Point(18, 66);
            this.checkBoxFontColor.Name = "checkBoxFontColor";
            this.checkBoxFontColor.Size = new System.Drawing.Size(192, 24);
            this.checkBoxFontColor.TabIndex = 1;
            this.checkBoxFontColor.Text = "Couleur des caractéres";
            this.checkBoxFontColor.UseVisualStyleBackColor = true;
            this.checkBoxFontColor.CheckedChanged += new System.EventHandler(this.CheckBoxChoice_CheckedChanged);
            // 
            // checkBoxBackgroundColor
            // 
            this.checkBoxBackgroundColor.AutoSize = true;
            this.checkBoxBackgroundColor.Location = new System.Drawing.Point(18, 35);
            this.checkBoxBackgroundColor.Name = "checkBoxBackgroundColor";
            this.checkBoxBackgroundColor.Size = new System.Drawing.Size(141, 24);
            this.checkBoxBackgroundColor.TabIndex = 0;
            this.checkBoxBackgroundColor.Text = "Couleur du fond";
            this.checkBoxBackgroundColor.UseVisualStyleBackColor = true;
            this.checkBoxBackgroundColor.CheckedChanged += new System.EventHandler(this.CheckBoxChoice_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // groupBoxBackgroudColor
            // 
            this.groupBoxBackgroudColor.Controls.Add(this.radioButtonBkgBlue);
            this.groupBoxBackgroudColor.Controls.Add(this.radioButtonBkgGreen);
            this.groupBoxBackgroudColor.Controls.Add(this.radioButtonBkgRed);
            this.groupBoxBackgroudColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBackgroudColor.Location = new System.Drawing.Point(13, 170);
            this.groupBoxBackgroudColor.Name = "groupBoxBackgroudColor";
            this.groupBoxBackgroudColor.Size = new System.Drawing.Size(95, 124);
            this.groupBoxBackgroudColor.TabIndex = 4;
            this.groupBoxBackgroudColor.TabStop = false;
            this.groupBoxBackgroudColor.Text = "Font";
            // 
            // radioButtonBkgBlue
            // 
            this.radioButtonBkgBlue.AutoSize = true;
            this.radioButtonBkgBlue.Location = new System.Drawing.Point(7, 87);
            this.radioButtonBkgBlue.Name = "radioButtonBkgBlue";
            this.radioButtonBkgBlue.Size = new System.Drawing.Size(59, 24);
            this.radioButtonBkgBlue.TabIndex = 2;
            this.radioButtonBkgBlue.TabStop = true;
            this.radioButtonBkgBlue.Text = "Bleu";
            this.radioButtonBkgBlue.UseVisualStyleBackColor = true;
            this.radioButtonBkgBlue.CheckedChanged += new System.EventHandler(this.radioButtonBackgroundColor_CheckedChanged);
            // 
            // radioButtonBkgGreen
            // 
            this.radioButtonBkgGreen.AutoSize = true;
            this.radioButtonBkgGreen.Location = new System.Drawing.Point(7, 57);
            this.radioButtonBkgGreen.Name = "radioButtonBkgGreen";
            this.radioButtonBkgGreen.Size = new System.Drawing.Size(57, 24);
            this.radioButtonBkgGreen.TabIndex = 1;
            this.radioButtonBkgGreen.TabStop = true;
            this.radioButtonBkgGreen.Text = "Vert";
            this.radioButtonBkgGreen.UseVisualStyleBackColor = true;
            this.radioButtonBkgGreen.CheckedChanged += new System.EventHandler(this.radioButtonBackgroundColor_CheckedChanged);
            // 
            // radioButtonBkgRed
            // 
            this.radioButtonBkgRed.AutoSize = true;
            this.radioButtonBkgRed.Location = new System.Drawing.Point(7, 26);
            this.radioButtonBkgRed.Name = "radioButtonBkgRed";
            this.radioButtonBkgRed.Size = new System.Drawing.Size(75, 24);
            this.radioButtonBkgRed.TabIndex = 0;
            this.radioButtonBkgRed.TabStop = true;
            this.radioButtonBkgRed.Text = "Rouge";
            this.radioButtonBkgRed.UseVisualStyleBackColor = true;
            this.radioButtonBkgRed.CheckedChanged += new System.EventHandler(this.radioButtonBackgroundColor_CheckedChanged);
            // 
            // groupBoxFontColor
            // 
            this.groupBoxFontColor.Controls.Add(this.radioButtonFontBlack);
            this.groupBoxFontColor.Controls.Add(this.radioButtonFontWhite);
            this.groupBoxFontColor.Controls.Add(this.radioButtonFontRed);
            this.groupBoxFontColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFontColor.Location = new System.Drawing.Point(115, 170);
            this.groupBoxFontColor.Name = "groupBoxFontColor";
            this.groupBoxFontColor.Size = new System.Drawing.Size(109, 124);
            this.groupBoxFontColor.TabIndex = 5;
            this.groupBoxFontColor.TabStop = false;
            this.groupBoxFontColor.Text = "Caractères";
            // 
            // radioButtonFontBlack
            // 
            this.radioButtonFontBlack.AutoSize = true;
            this.radioButtonFontBlack.Location = new System.Drawing.Point(6, 87);
            this.radioButtonFontBlack.Name = "radioButtonFontBlack";
            this.radioButtonFontBlack.Size = new System.Drawing.Size(55, 24);
            this.radioButtonFontBlack.TabIndex = 2;
            this.radioButtonFontBlack.TabStop = true;
            this.radioButtonFontBlack.Text = "Noir";
            this.radioButtonFontBlack.UseVisualStyleBackColor = true;
            this.radioButtonFontBlack.CheckedChanged += new System.EventHandler(this.groupBoxFontColor_CheckedChanged);
            // 
            // radioButtonFontWhite
            // 
            this.radioButtonFontWhite.AutoSize = true;
            this.radioButtonFontWhite.Location = new System.Drawing.Point(6, 57);
            this.radioButtonFontWhite.Name = "radioButtonFontWhite";
            this.radioButtonFontWhite.Size = new System.Drawing.Size(67, 24);
            this.radioButtonFontWhite.TabIndex = 1;
            this.radioButtonFontWhite.TabStop = true;
            this.radioButtonFontWhite.Text = "Blanc";
            this.radioButtonFontWhite.UseVisualStyleBackColor = true;
            this.radioButtonFontWhite.CheckedChanged += new System.EventHandler(this.groupBoxFontColor_CheckedChanged);
            // 
            // radioButtonFontRed
            // 
            this.radioButtonFontRed.AutoSize = true;
            this.radioButtonFontRed.Location = new System.Drawing.Point(6, 26);
            this.radioButtonFontRed.Name = "radioButtonFontRed";
            this.radioButtonFontRed.Size = new System.Drawing.Size(75, 24);
            this.radioButtonFontRed.TabIndex = 0;
            this.radioButtonFontRed.TabStop = true;
            this.radioButtonFontRed.Text = "Rouge";
            this.radioButtonFontRed.UseVisualStyleBackColor = true;
            this.radioButtonFontRed.CheckedChanged += new System.EventHandler(this.groupBoxFontColor_CheckedChanged);
            // 
            // groupBoxCase
            // 
            this.groupBoxCase.Controls.Add(this.radioButtonCaseLower);
            this.groupBoxCase.Controls.Add(this.radioButtonCaseUpper);
            this.groupBoxCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCase.Location = new System.Drawing.Point(230, 196);
            this.groupBoxCase.Name = "groupBoxCase";
            this.groupBoxCase.Size = new System.Drawing.Size(132, 98);
            this.groupBoxCase.TabIndex = 6;
            this.groupBoxCase.TabStop = false;
            this.groupBoxCase.Text = "Casse";
            // 
            // radioButtonCaseLower
            // 
            this.radioButtonCaseLower.AutoSize = true;
            this.radioButtonCaseLower.Location = new System.Drawing.Point(6, 33);
            this.radioButtonCaseLower.Name = "radioButtonCaseLower";
            this.radioButtonCaseLower.Size = new System.Drawing.Size(98, 24);
            this.radioButtonCaseLower.TabIndex = 1;
            this.radioButtonCaseLower.TabStop = true;
            this.radioButtonCaseLower.Text = "Minuscule";
            this.radioButtonCaseLower.UseVisualStyleBackColor = true;
            this.radioButtonCaseLower.CheckedChanged += new System.EventHandler(this.radioButtonCase_CheckedChanged);
            // 
            // radioButtonCaseUpper
            // 
            this.radioButtonCaseUpper.AutoSize = true;
            this.radioButtonCaseUpper.Location = new System.Drawing.Point(6, 63);
            this.radioButtonCaseUpper.Name = "radioButtonCaseUpper";
            this.radioButtonCaseUpper.Size = new System.Drawing.Size(98, 24);
            this.radioButtonCaseUpper.TabIndex = 0;
            this.radioButtonCaseUpper.TabStop = true;
            this.radioButtonCaseUpper.Text = "Majuscule";
            this.radioButtonCaseUpper.UseVisualStyleBackColor = true;
            this.radioButtonCaseUpper.CheckedChanged += new System.EventHandler(this.radioButtonCase_CheckedChanged);
            // 
            // labelResultTyping
            // 
            this.labelResultTyping.AutoSize = true;
            this.labelResultTyping.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultTyping.Location = new System.Drawing.Point(13, 89);
            this.labelResultTyping.Name = "labelResultTyping";
            this.labelResultTyping.Size = new System.Drawing.Size(13, 20);
            this.labelResultTyping.TabIndex = 7;
            this.labelResultTyping.Text = " ";
            // 
            // errorProviderTyping
            // 
            this.errorProviderTyping.ContainerControl = this;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 307);
            this.Controls.Add(this.labelResultTyping);
            this.Controls.Add(this.groupBoxCase);
            this.Controls.Add(this.groupBoxFontColor);
            this.Controls.Add(this.groupBoxBackgroudColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxChoice);
            this.Controls.Add(this.textBoxTyping);
            this.Controls.Add(this.labelTyping);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainWindow";
            this.Text = "CheckBox et RadioButtons";
            this.groupBoxChoice.ResumeLayout(false);
            this.groupBoxChoice.PerformLayout();
            this.groupBoxBackgroudColor.ResumeLayout(false);
            this.groupBoxBackgroudColor.PerformLayout();
            this.groupBoxFontColor.ResumeLayout(false);
            this.groupBoxFontColor.PerformLayout();
            this.groupBoxCase.ResumeLayout(false);
            this.groupBoxCase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTyping)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTyping;
        private System.Windows.Forms.TextBox textBoxTyping;
        private System.Windows.Forms.GroupBox groupBoxChoice;
        private System.Windows.Forms.CheckBox checkBoxCase;
        private System.Windows.Forms.CheckBox checkBoxFontColor;
        private System.Windows.Forms.CheckBox checkBoxBackgroundColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxBackgroudColor;
        private System.Windows.Forms.RadioButton radioButtonBkgBlue;
        private System.Windows.Forms.RadioButton radioButtonBkgGreen;
        private System.Windows.Forms.RadioButton radioButtonBkgRed;
        private System.Windows.Forms.GroupBox groupBoxFontColor;
        private System.Windows.Forms.RadioButton radioButtonFontBlack;
        private System.Windows.Forms.RadioButton radioButtonFontWhite;
        private System.Windows.Forms.RadioButton radioButtonFontRed;
        private System.Windows.Forms.GroupBox groupBoxCase;
        private System.Windows.Forms.RadioButton radioButtonCaseLower;
        private System.Windows.Forms.RadioButton radioButtonCaseUpper;
        private System.Windows.Forms.Label labelResultTyping;
        private System.Windows.Forms.ErrorProvider errorProviderTyping;
    }
}

