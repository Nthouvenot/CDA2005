namespace ValidationSaisies
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.zipCode = new System.Windows.Forms.Label();
            this.textBoxZipCode = new System.Windows.Forms.TextBox();
            this.validate = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.errorProviderNom = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderAmount = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderZipCode = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderZipCode)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(29, 63);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(30, 13);
            this.date.TabIndex = 1;
            this.date.Text = "Date";
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Location = new System.Drawing.Point(29, 99);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(46, 13);
            this.amount.TabIndex = 2;
            this.amount.Text = "Montant";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(118, 28);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(141, 20);
            this.textBoxName.TabIndex = 3;
            this.textBoxName.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(118, 63);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(111, 20);
            this.textBoxDate.TabIndex = 4;
            this.textBoxDate.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(118, 99);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(111, 20);
            this.textBoxAmount.TabIndex = 5;
            this.textBoxAmount.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(29, 28);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(29, 13);
            this.name.TabIndex = 6;
            this.name.Text = "Nom";
            // 
            // zipCode
            // 
            this.zipCode.AutoSize = true;
            this.zipCode.Location = new System.Drawing.Point(32, 135);
            this.zipCode.Name = "zipCode";
            this.zipCode.Size = new System.Drawing.Size(63, 13);
            this.zipCode.TabIndex = 7;
            this.zipCode.Text = "Code postal";
            // 
            // textBoxZipCode
            // 
            this.textBoxZipCode.Location = new System.Drawing.Point(118, 135);
            this.textBoxZipCode.Name = "textBoxZipCode";
            this.textBoxZipCode.Size = new System.Drawing.Size(93, 20);
            this.textBoxZipCode.TabIndex = 8;
            this.textBoxZipCode.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // validate
            // 
            this.validate.Location = new System.Drawing.Point(296, 155);
            this.validate.Name = "validate";
            this.validate.Size = new System.Drawing.Size(75, 23);
            this.validate.TabIndex = 9;
            this.validate.Text = "Valider";
            this.validate.UseVisualStyleBackColor = true;
            this.validate.Click += new System.EventHandler(this.validate_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(296, 197);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 10;
            this.clear.Text = "Effacer";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // errorProviderNom
            // 
            this.errorProviderNom.ContainerControl = this;
            // 
            // errorProviderDate
            // 
            this.errorProviderDate.ContainerControl = this;
            // 
            // errorProviderAmount
            // 
            this.errorProviderAmount.ContainerControl = this;
            // 
            // errorProviderZipCode
            // 
            this.errorProviderZipCode.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(383, 232);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.validate);
            this.Controls.Add(this.textBoxZipCode);
            this.Controls.Add(this.zipCode);
            this.Controls.Add(this.name);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Les contrôles";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderZipCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label amount;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label zipCode;
        private System.Windows.Forms.TextBox textBoxZipCode;
        private System.Windows.Forms.Button validate;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.ErrorProvider errorProviderNom;
        private System.Windows.Forms.ErrorProvider errorProviderDate;
        private System.Windows.Forms.ErrorProvider errorProviderAmount;
        private System.Windows.Forms.ErrorProvider errorProviderZipCode;
    }
}