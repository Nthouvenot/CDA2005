namespace Calculatrice
{
    partial class Form1
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
            this.button0 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.printResult = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            this.calculer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(36, 143);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(76, 71);
            this.button0.TabIndex = 12;
            this.button0.Tag = "0";
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.MakeSum);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 71);
            this.button1.TabIndex = 1;
            this.button1.Tag = "1";
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.MakeSum);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(199, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 71);
            this.button2.TabIndex = 2;
            this.button2.Tag = "2";
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.MakeSum);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(281, 143);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 71);
            this.button3.TabIndex = 3;
            this.button3.Tag = "3";
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.MakeSum);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(363, 143);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(76, 71);
            this.button4.TabIndex = 4;
            this.button4.Tag = "4";
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.MakeSum);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(36, 220);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(76, 71);
            this.button5.TabIndex = 5;
            this.button5.Tag = "5";
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.MakeSum);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(118, 220);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(76, 71);
            this.button6.TabIndex = 6;
            this.button6.Tag = "6";
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.MakeSum);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(200, 220);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(76, 71);
            this.button7.TabIndex = 7;
            this.button7.Tag = "7";
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.MakeSum);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(282, 220);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(76, 71);
            this.button8.TabIndex = 8;
            this.button8.Tag = "8";
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.MakeSum);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(364, 220);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 71);
            this.button9.TabIndex = 9;
            this.button9.Tag = "9";
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.MakeSum);
            // 
            // printResult
            // 
            this.printResult.Location = new System.Drawing.Point(36, 12);
            this.printResult.Multiline = true;
            this.printResult.Name = "printResult";
            this.printResult.ReadOnly = true;
            this.printResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.printResult.Size = new System.Drawing.Size(404, 97);
            this.printResult.TabIndex = 10;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(36, 329);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(119, 35);
            this.clear.TabIndex = 11;
            this.clear.Text = "Vider";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // calculer
            // 
            this.calculer.Location = new System.Drawing.Point(320, 329);
            this.calculer.Name = "calculer";
            this.calculer.Size = new System.Drawing.Size(119, 35);
            this.calculer.TabIndex = 0;
            this.calculer.Text = "Calculer";
            this.calculer.Click += new System.EventHandler(this.calculer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(477, 450);
            this.Controls.Add(this.calculer);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.printResult);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button0);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox printResult;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button calculer;
    }
}

