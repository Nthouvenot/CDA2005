
namespace ApplicationMdi
{
    partial class TypingWindow
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
            this.labelTyping = new System.Windows.Forms.Label();
            this.textBoxTyping = new System.Windows.Forms.TextBox();
            this.buttonValidate = new System.Windows.Forms.Button();
            this.errorProviderTyping = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTyping)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTyping
            // 
            this.labelTyping.AutoSize = true;
            this.labelTyping.Location = new System.Drawing.Point(36, 24);
            this.labelTyping.Name = "labelTyping";
            this.labelTyping.Size = new System.Drawing.Size(131, 20);
            this.labelTyping.TabIndex = 0;
            this.labelTyping.Text = "Tapez votre texte";
            // 
            // textBoxTyping
            // 
            this.textBoxTyping.Location = new System.Drawing.Point(40, 57);
            this.textBoxTyping.Name = "textBoxTyping";
            this.textBoxTyping.Size = new System.Drawing.Size(390, 26);
            this.textBoxTyping.TabIndex = 1;
            this.textBoxTyping.TextChanged += new System.EventHandler(this.textBoxTyping_TextChanged);
            // 
            // buttonValidate
            // 
            this.buttonValidate.Enabled = false;
            this.buttonValidate.Location = new System.Drawing.Point(449, 57);
            this.buttonValidate.Name = "buttonValidate";
            this.buttonValidate.Size = new System.Drawing.Size(87, 26);
            this.buttonValidate.TabIndex = 2;
            this.buttonValidate.Text = "Valider";
            this.buttonValidate.UseVisualStyleBackColor = true;
            this.buttonValidate.Click += new System.EventHandler(this.buttonValidate_Click);
            // 
            // errorProviderTyping
            // 
            this.errorProviderTyping.ContainerControl = this;
            // 
            // TypingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 106);
            this.Controls.Add(this.buttonValidate);
            this.Controls.Add(this.textBoxTyping);
            this.Controls.Add(this.labelTyping);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TypingWindow";
            this.Text = "Saisie";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTyping)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTyping;
        private System.Windows.Forms.TextBox textBoxTyping;
        private System.Windows.Forms.Button buttonValidate;
        private System.Windows.Forms.ErrorProvider errorProviderTyping;
    }
}