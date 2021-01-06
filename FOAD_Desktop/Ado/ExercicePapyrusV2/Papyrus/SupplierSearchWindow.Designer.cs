
namespace Papyrus
{
    partial class SupplierSearchWindow
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
            this.labelSupplierCode = new System.Windows.Forms.Label();
            this.textBoxSupplierCode = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.errorProviderCode = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCode)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSupplierCode
            // 
            this.labelSupplierCode.AutoSize = true;
            this.labelSupplierCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSupplierCode.Location = new System.Drawing.Point(12, 16);
            this.labelSupplierCode.Name = "labelSupplierCode";
            this.labelSupplierCode.Size = new System.Drawing.Size(130, 20);
            this.labelSupplierCode.TabIndex = 0;
            this.labelSupplierCode.Text = "Code fournisseur";
            // 
            // textBoxSupplierCode
            // 
            this.textBoxSupplierCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSupplierCode.Location = new System.Drawing.Point(224, 13);
            this.textBoxSupplierCode.Name = "textBoxSupplierCode";
            this.textBoxSupplierCode.Size = new System.Drawing.Size(100, 26);
            this.textBoxSupplierCode.TabIndex = 1;
            this.textBoxSupplierCode.TextChanged += new System.EventHandler(this.TextBoxSupplierCode_TextChanged);
            // 
            // buttonOk
            // 
            this.buttonOk.Enabled = false;
            this.buttonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOk.Location = new System.Drawing.Point(17, 56);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(87, 30);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "Valider";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(237, 56);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(87, 30);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Quitter";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // errorProviderCode
            // 
            this.errorProviderCode.ContainerControl = this;
            // 
            // SupplierSearchWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 104);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxSupplierCode);
            this.Controls.Add(this.labelSupplierCode);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "SupplierSearchWindow";
            this.Text = "Affichage Fournisseur";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSupplierCode;
        private System.Windows.Forms.TextBox textBoxSupplierCode;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ErrorProvider errorProviderCode;
    }
}