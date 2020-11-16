namespace Emprunt
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelMoneyBoworred = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxMoneyBoworred = new System.Windows.Forms.TextBox();
            this.labelNumberOfMonths = new System.Windows.Forms.Label();
            this.labelMonthValue = new System.Windows.Forms.Label();
            this.hScrollBarNumberOfMonths = new System.Windows.Forms.HScrollBar();
            this.labelReimbursementPeriod = new System.Windows.Forms.Label();
            this.listBoxReimbursementPeriod = new System.Windows.Forms.ListBox();
            this.groupBoxInterestRate = new System.Windows.Forms.GroupBox();
            this.radioButtonNinePercent = new System.Windows.Forms.RadioButton();
            this.radioButtonEightPercent = new System.Windows.Forms.RadioButton();
            this.radioButtonSevenPercent = new System.Windows.Forms.RadioButton();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelMonths = new System.Windows.Forms.Label();
            this.labelMonthlyReimbursement = new System.Windows.Forms.Label();
            this.labelAmountPerMonth = new System.Windows.Forms.Label();
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderMoneyBoworred = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxInterestRate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMoneyBoworred)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(25, 28);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(42, 20);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Nom";
            // 
            // labelMoneyBoworred
            // 
            this.labelMoneyBoworred.AutoSize = true;
            this.labelMoneyBoworred.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMoneyBoworred.Location = new System.Drawing.Point(25, 61);
            this.labelMoneyBoworred.Name = "labelMoneyBoworred";
            this.labelMoneyBoworred.Size = new System.Drawing.Size(130, 20);
            this.labelMoneyBoworred.TabIndex = 1;
            this.labelMoneyBoworred.Text = "Capital emprunté";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(180, 28);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(124, 26);
            this.textBoxName.TabIndex = 2;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxMoneyBoworred
            // 
            this.textBoxMoneyBoworred.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMoneyBoworred.Location = new System.Drawing.Point(180, 61);
            this.textBoxMoneyBoworred.Name = "textBoxMoneyBoworred";
            this.textBoxMoneyBoworred.Size = new System.Drawing.Size(124, 26);
            this.textBoxMoneyBoworred.TabIndex = 3;
            this.textBoxMoneyBoworred.TextChanged += new System.EventHandler(this.textBoxMoneyBoworred_TextChanged);
            // 
            // labelNumberOfMonths
            // 
            this.labelNumberOfMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberOfMonths.Location = new System.Drawing.Point(29, 102);
            this.labelNumberOfMonths.Name = "labelNumberOfMonths";
            this.labelNumberOfMonths.Size = new System.Drawing.Size(140, 40);
            this.labelNumberOfMonths.TabIndex = 4;
            this.labelNumberOfMonths.Text = "Durée en mois du remboursement";
            // 
            // labelMonthValue
            // 
            this.labelMonthValue.AutoSize = true;
            this.labelMonthValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonthValue.Location = new System.Drawing.Point(175, 102);
            this.labelMonthValue.Name = "labelMonthValue";
            this.labelMonthValue.Size = new System.Drawing.Size(18, 20);
            this.labelMonthValue.TabIndex = 5;
            this.labelMonthValue.Text = "1";
            // 
            // hScrollBarNumberOfMonths
            // 
            this.hScrollBarNumberOfMonths.LargeChange = 1;
            this.hScrollBarNumberOfMonths.Location = new System.Drawing.Point(233, 102);
            this.hScrollBarNumberOfMonths.Maximum = 300;
            this.hScrollBarNumberOfMonths.Minimum = 1;
            this.hScrollBarNumberOfMonths.Name = "hScrollBarNumberOfMonths";
            this.hScrollBarNumberOfMonths.Size = new System.Drawing.Size(106, 20);
            this.hScrollBarNumberOfMonths.TabIndex = 6;
            this.hScrollBarNumberOfMonths.Value = 1;
            this.hScrollBarNumberOfMonths.ValueChanged += new System.EventHandler(this.hScrollBarNumberOfMonths_ValueChanged);
            // 
            // labelReimbursementPeriod
            // 
            this.labelReimbursementPeriod.AutoSize = true;
            this.labelReimbursementPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReimbursementPeriod.Location = new System.Drawing.Point(29, 164);
            this.labelReimbursementPeriod.Name = "labelReimbursementPeriod";
            this.labelReimbursementPeriod.Size = new System.Drawing.Size(192, 20);
            this.labelReimbursementPeriod.TabIndex = 7;
            this.labelReimbursementPeriod.Text = "Période de remoursement";
            // 
            // listBoxReimbursementPeriod
            // 
            this.listBoxReimbursementPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxReimbursementPeriod.FormattingEnabled = true;
            this.listBoxReimbursementPeriod.ItemHeight = 20;
            this.listBoxReimbursementPeriod.Location = new System.Drawing.Point(33, 187);
            this.listBoxReimbursementPeriod.Name = "listBoxReimbursementPeriod";
            this.listBoxReimbursementPeriod.Size = new System.Drawing.Size(233, 104);
            this.listBoxReimbursementPeriod.TabIndex = 8;
            // 
            // groupBoxInterestRate
            // 
            this.groupBoxInterestRate.Controls.Add(this.radioButtonNinePercent);
            this.groupBoxInterestRate.Controls.Add(this.radioButtonEightPercent);
            this.groupBoxInterestRate.Controls.Add(this.radioButtonSevenPercent);
            this.groupBoxInterestRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInterestRate.Location = new System.Drawing.Point(360, 28);
            this.groupBoxInterestRate.Name = "groupBoxInterestRate";
            this.groupBoxInterestRate.Size = new System.Drawing.Size(131, 114);
            this.groupBoxInterestRate.TabIndex = 9;
            this.groupBoxInterestRate.TabStop = false;
            this.groupBoxInterestRate.Text = "Taux d\'intêret";
            // 
            // radioButtonNinePercent
            // 
            this.radioButtonNinePercent.AutoSize = true;
            this.radioButtonNinePercent.Location = new System.Drawing.Point(7, 88);
            this.radioButtonNinePercent.Name = "radioButtonNinePercent";
            this.radioButtonNinePercent.Size = new System.Drawing.Size(50, 24);
            this.radioButtonNinePercent.TabIndex = 2;
            this.radioButtonNinePercent.TabStop = true;
            this.radioButtonNinePercent.Text = "9%";
            this.radioButtonNinePercent.UseVisualStyleBackColor = true;
            // 
            // radioButtonEightPercent
            // 
            this.radioButtonEightPercent.AutoSize = true;
            this.radioButtonEightPercent.Location = new System.Drawing.Point(7, 57);
            this.radioButtonEightPercent.Name = "radioButtonEightPercent";
            this.radioButtonEightPercent.Size = new System.Drawing.Size(50, 24);
            this.radioButtonEightPercent.TabIndex = 1;
            this.radioButtonEightPercent.TabStop = true;
            this.radioButtonEightPercent.Text = "8%";
            this.radioButtonEightPercent.UseVisualStyleBackColor = true;
            // 
            // radioButtonSevenPercent
            // 
            this.radioButtonSevenPercent.AutoSize = true;
            this.radioButtonSevenPercent.Location = new System.Drawing.Point(7, 26);
            this.radioButtonSevenPercent.Name = "radioButtonSevenPercent";
            this.radioButtonSevenPercent.Size = new System.Drawing.Size(50, 24);
            this.radioButtonSevenPercent.TabIndex = 0;
            this.radioButtonSevenPercent.TabStop = true;
            this.radioButtonSevenPercent.Text = "7%";
            this.radioButtonSevenPercent.UseVisualStyleBackColor = false;
            // 
            // buttonOk
            // 
            this.buttonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOk.Location = new System.Drawing.Point(514, 28);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 26);
            this.buttonOk.TabIndex = 10;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(514, 63);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 24);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Annuler";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelMonths
            // 
            this.labelMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonths.ForeColor = System.Drawing.Color.Red;
            this.labelMonths.Location = new System.Drawing.Point(303, 187);
            this.labelMonths.Name = "labelMonths";
            this.labelMonths.Size = new System.Drawing.Size(46, 27);
            this.labelMonths.TabIndex = 13;
            this.labelMonths.Text = "0";
            // 
            // labelMonthlyReimbursement
            // 
            this.labelMonthlyReimbursement.AutoSize = true;
            this.labelMonthlyReimbursement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonthlyReimbursement.Location = new System.Drawing.Point(360, 187);
            this.labelMonthlyReimbursement.Name = "labelMonthlyReimbursement";
            this.labelMonthlyReimbursement.Size = new System.Drawing.Size(136, 20);
            this.labelMonthlyReimbursement.TabIndex = 14;
            this.labelMonthlyReimbursement.Text = "Remboursements";
            // 
            // labelAmountPerMonth
            // 
            this.labelAmountPerMonth.AutoSize = true;
            this.labelAmountPerMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmountPerMonth.ForeColor = System.Drawing.Color.Red;
            this.labelAmountPerMonth.Location = new System.Drawing.Point(360, 231);
            this.labelAmountPerMonth.Name = "labelAmountPerMonth";
            this.labelAmountPerMonth.Size = new System.Drawing.Size(18, 20);
            this.labelAmountPerMonth.TabIndex = 15;
            this.labelAmountPerMonth.Text = "0";
            // 
            // errorProviderName
            // 
            this.errorProviderName.ContainerControl = this;
            // 
            // errorProviderMoneyBoworred
            // 
            this.errorProviderMoneyBoworred.ContainerControl = this;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 313);
            this.Controls.Add(this.labelAmountPerMonth);
            this.Controls.Add(this.labelMonthlyReimbursement);
            this.Controls.Add(this.labelMonths);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBoxInterestRate);
            this.Controls.Add(this.listBoxReimbursementPeriod);
            this.Controls.Add(this.labelReimbursementPeriod);
            this.Controls.Add(this.hScrollBarNumberOfMonths);
            this.Controls.Add(this.labelMonthValue);
            this.Controls.Add(this.labelNumberOfMonths);
            this.Controls.Add(this.textBoxMoneyBoworred);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelMoneyBoworred);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainWindow";
            this.Text = "Ok";
            this.groupBoxInterestRate.ResumeLayout(false);
            this.groupBoxInterestRate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMoneyBoworred)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelMoneyBoworred;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxMoneyBoworred;
        private System.Windows.Forms.Label labelNumberOfMonths;
        private System.Windows.Forms.Label labelMonthValue;
        private System.Windows.Forms.HScrollBar hScrollBarNumberOfMonths;
        private System.Windows.Forms.Label labelReimbursementPeriod;
        private System.Windows.Forms.ListBox listBoxReimbursementPeriod;
        private System.Windows.Forms.GroupBox groupBoxInterestRate;
        private System.Windows.Forms.RadioButton radioButtonNinePercent;
        private System.Windows.Forms.RadioButton radioButtonEightPercent;
        private System.Windows.Forms.RadioButton radioButtonSevenPercent;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelMonths;
        private System.Windows.Forms.Label labelMonthlyReimbursement;
        private System.Windows.Forms.Label labelAmountPerMonth;
        private System.Windows.Forms.ErrorProvider errorProviderName;
        private System.Windows.Forms.ErrorProvider errorProviderMoneyBoworred;
    }
}

