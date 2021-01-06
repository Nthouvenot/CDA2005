
namespace Papyrus
{
    partial class PrintUpdateDeleteSupplierDataWindow
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
            this.labelSuplier = new System.Windows.Forms.Label();
            this.textBoxSuplierNumber = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelSuplierName = new System.Windows.Forms.Label();
            this.textBoxSuplierName = new System.Windows.Forms.TextBox();
            this.textBoxSuplierZipCode = new System.Windows.Forms.TextBox();
            this.textBoxSuplierContact = new System.Windows.Forms.TextBox();
            this.textBoxSuplierCity = new System.Windows.Forms.TextBox();
            this.labelSuplierAdress = new System.Windows.Forms.Label();
            this.labelContact = new System.Windows.Forms.Label();
            this.labelSatisfaction = new System.Windows.Forms.Label();
            this.textBoxSuplierSatisfaction = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.errorProviderFournisseur = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBoxSuplierAdress = new System.Windows.Forms.TextBox();
            this.labelZipCodeCity = new System.Windows.Forms.Label();
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderAdress = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCpCity = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderContact = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCity = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderSatisfaction = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFournisseur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAdress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCpCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSatisfaction)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSuplier
            // 
            this.labelSuplier.AutoSize = true;
            this.labelSuplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSuplier.Location = new System.Drawing.Point(12, 25);
            this.labelSuplier.Name = "labelSuplier";
            this.labelSuplier.Size = new System.Drawing.Size(130, 20);
            this.labelSuplier.TabIndex = 0;
            this.labelSuplier.Text = "Code fournisseur";
            // 
            // textBoxSuplier
            // 
            this.textBoxSuplierNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSuplierNumber.Location = new System.Drawing.Point(169, 22);
            this.textBoxSuplierNumber.Name = "textBoxSuplier";
            this.textBoxSuplierNumber.Size = new System.Drawing.Size(183, 26);
            this.textBoxSuplierNumber.TabIndex = 1;
            this.textBoxSuplierNumber.TextChanged += new System.EventHandler(this.TextBoxSuplierCode_TextChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(380, 18);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(123, 35);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Rechercher";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // labelSuplierName
            // 
            this.labelSuplierName.AutoSize = true;
            this.labelSuplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSuplierName.Location = new System.Drawing.Point(16, 75);
            this.labelSuplierName.Name = "labelSuplierName";
            this.labelSuplierName.Size = new System.Drawing.Size(42, 20);
            this.labelSuplierName.TabIndex = 3;
            this.labelSuplierName.Text = "Nom";
            // 
            // textBoxSuplierName
            // 
            this.textBoxSuplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSuplierName.Location = new System.Drawing.Point(143, 72);
            this.textBoxSuplierName.Name = "textBoxSuplierName";
            this.textBoxSuplierName.Size = new System.Drawing.Size(272, 26);
            this.textBoxSuplierName.TabIndex = 4;
            this.textBoxSuplierName.TextChanged += new System.EventHandler(this.TextBoxSuplier_TextChanged);
            // 
            // textBoxSuplierZipCode
            // 
            this.textBoxSuplierZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSuplierZipCode.Location = new System.Drawing.Point(143, 140);
            this.textBoxSuplierZipCode.Name = "textBoxSuplierZipCode";
            this.textBoxSuplierZipCode.Size = new System.Drawing.Size(62, 26);
            this.textBoxSuplierZipCode.TabIndex = 5;
            this.textBoxSuplierZipCode.TextChanged += new System.EventHandler(this.TextBoxSuplier_TextChanged);
            // 
            // textBoxSuplierContact
            // 
            this.textBoxSuplierContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSuplierContact.Location = new System.Drawing.Point(143, 172);
            this.textBoxSuplierContact.Name = "textBoxSuplierContact";
            this.textBoxSuplierContact.Size = new System.Drawing.Size(272, 26);
            this.textBoxSuplierContact.TabIndex = 6;
            this.textBoxSuplierContact.TextChanged += new System.EventHandler(this.TextBoxSuplier_TextChanged);
            // 
            // textBoxSuplierCity
            // 
            this.textBoxSuplierCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSuplierCity.Location = new System.Drawing.Point(212, 140);
            this.textBoxSuplierCity.Name = "textBoxSuplierCity";
            this.textBoxSuplierCity.Size = new System.Drawing.Size(203, 26);
            this.textBoxSuplierCity.TabIndex = 7;
            this.textBoxSuplierCity.TextChanged += new System.EventHandler(this.TextBoxSuplier_TextChanged);
            // 
            // labelSuplierAdress
            // 
            this.labelSuplierAdress.AutoSize = true;
            this.labelSuplierAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSuplierAdress.Location = new System.Drawing.Point(16, 110);
            this.labelSuplierAdress.Name = "labelSuplierAdress";
            this.labelSuplierAdress.Size = new System.Drawing.Size(68, 20);
            this.labelSuplierAdress.TabIndex = 8;
            this.labelSuplierAdress.Text = "Adresse";
            // 
            // labelContact
            // 
            this.labelContact.AutoSize = true;
            this.labelContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContact.Location = new System.Drawing.Point(16, 175);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(65, 20);
            this.labelContact.TabIndex = 9;
            this.labelContact.Text = "Contact";
            // 
            // labelSatisfaction
            // 
            this.labelSatisfaction.AutoSize = true;
            this.labelSatisfaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSatisfaction.Location = new System.Drawing.Point(16, 207);
            this.labelSatisfaction.Name = "labelSatisfaction";
            this.labelSatisfaction.Size = new System.Drawing.Size(93, 20);
            this.labelSatisfaction.TabIndex = 10;
            this.labelSatisfaction.Text = "Satisfaction";
            // 
            // textBoxSuplierSatisfaction
            // 
            this.textBoxSuplierSatisfaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSuplierSatisfaction.Location = new System.Drawing.Point(143, 204);
            this.textBoxSuplierSatisfaction.Name = "textBoxSuplierSatisfaction";
            this.textBoxSuplierSatisfaction.Size = new System.Drawing.Size(27, 26);
            this.textBoxSuplierSatisfaction.TabIndex = 11;
            this.textBoxSuplierSatisfaction.TextChanged += new System.EventHandler(this.TextBoxSuplier_TextChanged);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(311, 245);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(104, 34);
            this.buttonDelete.TabIndex = 12;
            this.buttonDelete.Text = "Supprimer";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNew.Location = new System.Drawing.Point(16, 245);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(104, 34);
            this.buttonNew.TabIndex = 13;
            this.buttonNew.Text = "Nouveau";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.ButtonNew_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(169, 245);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(104, 34);
            this.buttonUpdate.TabIndex = 14;
            this.buttonUpdate.Text = "Ajouter";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // errorProviderFournisseur
            // 
            this.errorProviderFournisseur.ContainerControl = this;
            this.errorProviderFournisseur.RightToLeft = true;
            // 
            // textBoxSuplierAdress
            // 
            this.textBoxSuplierAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSuplierAdress.Location = new System.Drawing.Point(143, 105);
            this.textBoxSuplierAdress.Name = "textBoxSuplierAdress";
            this.textBoxSuplierAdress.Size = new System.Drawing.Size(272, 26);
            this.textBoxSuplierAdress.TabIndex = 15;
            this.textBoxSuplierAdress.TextChanged += new System.EventHandler(this.TextBoxSuplier_TextChanged);
            // 
            // labelZipCodeCity
            // 
            this.labelZipCodeCity.AutoSize = true;
            this.labelZipCodeCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZipCodeCity.Location = new System.Drawing.Point(16, 143);
            this.labelZipCodeCity.Name = "labelZipCodeCity";
            this.labelZipCodeCity.Size = new System.Drawing.Size(70, 20);
            this.labelZipCodeCity.TabIndex = 16;
            this.labelZipCodeCity.Text = "Cp / Ville";
            // 
            // errorProviderName
            // 
            this.errorProviderName.ContainerControl = this;
            this.errorProviderName.RightToLeft = true;
            // 
            // errorProviderAdress
            // 
            this.errorProviderAdress.ContainerControl = this;
            this.errorProviderAdress.RightToLeft = true;
            // 
            // errorProviderCpCity
            // 
            this.errorProviderCpCity.ContainerControl = this;
            this.errorProviderCpCity.RightToLeft = true;
            // 
            // errorProviderContact
            // 
            this.errorProviderContact.ContainerControl = this;
            this.errorProviderContact.RightToLeft = true;
            // 
            // errorProviderCity
            // 
            this.errorProviderCity.ContainerControl = this;
            // 
            // errorProviderSatisfaction
            // 
            this.errorProviderSatisfaction.ContainerControl = this;
            // 
            // PrintUpdateDeleteSupplierDataWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 303);
            this.Controls.Add(this.labelZipCodeCity);
            this.Controls.Add(this.textBoxSuplierAdress);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBoxSuplierSatisfaction);
            this.Controls.Add(this.labelSatisfaction);
            this.Controls.Add(this.labelContact);
            this.Controls.Add(this.labelSuplierAdress);
            this.Controls.Add(this.textBoxSuplierCity);
            this.Controls.Add(this.textBoxSuplierContact);
            this.Controls.Add(this.textBoxSuplierZipCode);
            this.Controls.Add(this.textBoxSuplierName);
            this.Controls.Add(this.labelSuplierName);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSuplierNumber);
            this.Controls.Add(this.labelSuplier);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "PrintUpdateDeleteSupplierDataWindow";
            this.Text = "Fournisseur";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PrintUpdateDeleteSupplierDataWindow_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFournisseur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAdress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCpCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSatisfaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSuplier;
        private System.Windows.Forms.TextBox textBoxSuplierNumber;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelSuplierName;
        private System.Windows.Forms.TextBox textBoxSuplierName;
        private System.Windows.Forms.TextBox textBoxSuplierZipCode;
        private System.Windows.Forms.TextBox textBoxSuplierContact;
        private System.Windows.Forms.TextBox textBoxSuplierCity;
        private System.Windows.Forms.Label labelSuplierAdress;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.Label labelSatisfaction;
        private System.Windows.Forms.TextBox textBoxSuplierSatisfaction;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.ErrorProvider errorProviderFournisseur;
        private System.Windows.Forms.TextBox textBoxSuplierAdress;
        private System.Windows.Forms.Label labelZipCodeCity;
        private System.Windows.Forms.ErrorProvider errorProviderName;
        private System.Windows.Forms.ErrorProvider errorProviderAdress;
        private System.Windows.Forms.ErrorProvider errorProviderCpCity;
        private System.Windows.Forms.ErrorProvider errorProviderContact;
        private System.Windows.Forms.ErrorProvider errorProviderCity;
        private System.Windows.Forms.ErrorProvider errorProviderSatisfaction;
    }
}