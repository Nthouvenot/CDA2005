namespace Defilement
{
    partial class FormDefilement
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
            this.hScrollBarRed = new System.Windows.Forms.HScrollBar();
            this.hScrollBarGreen = new System.Windows.Forms.HScrollBar();
            this.hScrollBarBlue = new System.Windows.Forms.HScrollBar();
            this.labelRed = new System.Windows.Forms.Label();
            this.labelGreen = new System.Windows.Forms.Label();
            this.labelBlue = new System.Windows.Forms.Label();
            this.labelPrintRed = new System.Windows.Forms.Label();
            this.labelPrintGreen = new System.Windows.Forms.Label();
            this.labelPrintBlue = new System.Windows.Forms.Label();
            this.numericUpDownRed = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownGreen = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBlue = new System.Windows.Forms.NumericUpDown();
            this.labelColorResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // hScrollBarRed
            // 
            this.hScrollBarRed.Location = new System.Drawing.Point(90, 25);
            this.hScrollBarRed.Maximum = 255;
            this.hScrollBarRed.Name = "hScrollBarRed";
            this.hScrollBarRed.Size = new System.Drawing.Size(270, 24);
            this.hScrollBarRed.TabIndex = 0;
            this.hScrollBarRed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar_ValueChangedOrScrolled);
            this.hScrollBarRed.ValueChanged += new System.EventHandler(this.hScrollBar_ValueChangedOrScrolled);
            // 
            // hScrollBarGreen
            // 
            this.hScrollBarGreen.Location = new System.Drawing.Point(90, 70);
            this.hScrollBarGreen.Maximum = 255;
            this.hScrollBarGreen.Name = "hScrollBarGreen";
            this.hScrollBarGreen.Size = new System.Drawing.Size(270, 24);
            this.hScrollBarGreen.TabIndex = 1;
            this.hScrollBarGreen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar_ValueChangedOrScrolled);
            this.hScrollBarGreen.ValueChanged += new System.EventHandler(this.hScrollBar_ValueChangedOrScrolled);
            // 
            // hScrollBarBlue
            // 
            this.hScrollBarBlue.Location = new System.Drawing.Point(90, 111);
            this.hScrollBarBlue.Maximum = 255;
            this.hScrollBarBlue.Name = "hScrollBarBlue";
            this.hScrollBarBlue.Size = new System.Drawing.Size(270, 24);
            this.hScrollBarBlue.TabIndex = 2;
            this.hScrollBarBlue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar_ValueChangedOrScrolled);
            this.hScrollBarBlue.ValueChanged += new System.EventHandler(this.hScrollBar_ValueChangedOrScrolled);
            // 
            // labelRed
            // 
            this.labelRed.AutoSize = true;
            this.labelRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRed.Location = new System.Drawing.Point(12, 25);
            this.labelRed.Name = "labelRed";
            this.labelRed.Size = new System.Drawing.Size(57, 20);
            this.labelRed.TabIndex = 3;
            this.labelRed.Text = "Rouge";
            // 
            // labelGreen
            // 
            this.labelGreen.AutoSize = true;
            this.labelGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGreen.Location = new System.Drawing.Point(12, 70);
            this.labelGreen.Name = "labelGreen";
            this.labelGreen.Size = new System.Drawing.Size(39, 20);
            this.labelGreen.TabIndex = 4;
            this.labelGreen.Text = "Vert";
            // 
            // labelBlue
            // 
            this.labelBlue.AutoSize = true;
            this.labelBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBlue.Location = new System.Drawing.Point(16, 111);
            this.labelBlue.Name = "labelBlue";
            this.labelBlue.Size = new System.Drawing.Size(41, 20);
            this.labelBlue.TabIndex = 5;
            this.labelBlue.Text = "Bleu";
            // 
            // labelPrintRed
            // 
            this.labelPrintRed.AutoSize = true;
            this.labelPrintRed.BackColor = System.Drawing.Color.Black;
            this.labelPrintRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrintRed.Location = new System.Drawing.Point(441, 29);
            this.labelPrintRed.Name = "labelPrintRed";
            this.labelPrintRed.Size = new System.Drawing.Size(49, 20);
            this.labelPrintRed.TabIndex = 6;
            this.labelPrintRed.Text = "          ";
            // 
            // labelPrintGreen
            // 
            this.labelPrintGreen.AutoSize = true;
            this.labelPrintGreen.BackColor = System.Drawing.Color.Black;
            this.labelPrintGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrintGreen.Location = new System.Drawing.Point(442, 72);
            this.labelPrintGreen.Name = "labelPrintGreen";
            this.labelPrintGreen.Size = new System.Drawing.Size(49, 20);
            this.labelPrintGreen.TabIndex = 7;
            this.labelPrintGreen.Text = "          ";
            // 
            // labelPrintBlue
            // 
            this.labelPrintBlue.AutoSize = true;
            this.labelPrintBlue.BackColor = System.Drawing.Color.Black;
            this.labelPrintBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrintBlue.Location = new System.Drawing.Point(442, 115);
            this.labelPrintBlue.Name = "labelPrintBlue";
            this.labelPrintBlue.Size = new System.Drawing.Size(49, 20);
            this.labelPrintBlue.TabIndex = 8;
            this.labelPrintBlue.Text = "          ";
            // 
            // numericUpDownRed
            // 
            this.numericUpDownRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownRed.Location = new System.Drawing.Point(380, 25);
            this.numericUpDownRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownRed.Name = "numericUpDownRed";
            this.numericUpDownRed.Size = new System.Drawing.Size(46, 26);
            this.numericUpDownRed.TabIndex = 9;
            this.numericUpDownRed.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // numericUpDownGreen
            // 
            this.numericUpDownGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownGreen.Location = new System.Drawing.Point(380, 70);
            this.numericUpDownGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownGreen.Name = "numericUpDownGreen";
            this.numericUpDownGreen.Size = new System.Drawing.Size(46, 26);
            this.numericUpDownGreen.TabIndex = 10;
            this.numericUpDownGreen.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // numericUpDownBlue
            // 
            this.numericUpDownBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownBlue.Location = new System.Drawing.Point(380, 111);
            this.numericUpDownBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownBlue.Name = "numericUpDownBlue";
            this.numericUpDownBlue.Size = new System.Drawing.Size(46, 26);
            this.numericUpDownBlue.TabIndex = 11;
            this.numericUpDownBlue.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // labelColorResult
            // 
            this.labelColorResult.AutoSize = true;
            this.labelColorResult.BackColor = System.Drawing.Color.Black;
            this.labelColorResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColorResult.Location = new System.Drawing.Point(14, 160);
            this.labelColorResult.Name = "labelColorResult";
            this.labelColorResult.Size = new System.Drawing.Size(476, 31);
            this.labelColorResult.TabIndex = 12;
            this.labelColorResult.Text = "                                                                  ";
            // 
            // FormDefilement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 450);
            this.Controls.Add(this.labelColorResult);
            this.Controls.Add(this.numericUpDownBlue);
            this.Controls.Add(this.numericUpDownGreen);
            this.Controls.Add(this.numericUpDownRed);
            this.Controls.Add(this.labelPrintBlue);
            this.Controls.Add(this.labelPrintGreen);
            this.Controls.Add(this.labelPrintRed);
            this.Controls.Add(this.labelBlue);
            this.Controls.Add(this.labelGreen);
            this.Controls.Add(this.labelRed);
            this.Controls.Add(this.hScrollBarBlue);
            this.Controls.Add(this.hScrollBarGreen);
            this.Controls.Add(this.hScrollBarRed);
            this.Name = "FormDefilement";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar hScrollBarRed;
        private System.Windows.Forms.HScrollBar hScrollBarGreen;
        private System.Windows.Forms.HScrollBar hScrollBarBlue;
        private System.Windows.Forms.Label labelRed;
        private System.Windows.Forms.Label labelGreen;
        private System.Windows.Forms.Label labelBlue;
        private System.Windows.Forms.Label labelPrintRed;
        private System.Windows.Forms.Label labelPrintGreen;
        private System.Windows.Forms.Label labelPrintBlue;
        private System.Windows.Forms.NumericUpDown numericUpDownRed;
        private System.Windows.Forms.NumericUpDown numericUpDownGreen;
        private System.Windows.Forms.NumericUpDown numericUpDownBlue;
        private System.Windows.Forms.Label labelColorResult;
    }
}

