namespace ValidationSaisies
{
    partial class Form2
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
            this.buttonShowForm1 = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonShowForm1
            // 
            this.buttonShowForm1.Location = new System.Drawing.Point(12, 21);
            this.buttonShowForm1.Name = "buttonShowForm1";
            this.buttonShowForm1.Size = new System.Drawing.Size(99, 32);
            this.buttonShowForm1.TabIndex = 0;
            this.buttonShowForm1.Text = "Afficher form";
            this.buttonShowForm1.UseVisualStyleBackColor = true;
            this.buttonShowForm1.Click += new System.EventHandler(this.buttonShowForm1_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(12, 68);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(99, 32);
            this.buttonUpdate.TabIndex = 1;
            this.buttonUpdate.Text = "Modifier";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 128);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonShowForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonShowForm1;
        private System.Windows.Forms.Button buttonUpdate;
    }
}