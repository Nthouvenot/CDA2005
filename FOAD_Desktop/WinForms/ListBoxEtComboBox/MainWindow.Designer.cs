namespace ListBoxEtComboBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.labelSource = new System.Windows.Forms.Label();
            this.labelTarget = new System.Windows.Forms.Label();
            this.comboBoxSource = new System.Windows.Forms.ComboBox();
            this.listBoxTarget = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonAddAll = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonRemoveAll = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSource
            // 
            this.labelSource.AutoSize = true;
            this.labelSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSource.Location = new System.Drawing.Point(34, 13);
            this.labelSource.Name = "labelSource";
            this.labelSource.Size = new System.Drawing.Size(60, 20);
            this.labelSource.TabIndex = 0;
            this.labelSource.Text = "Source";
            // 
            // labelTarget
            // 
            this.labelTarget.AutoSize = true;
            this.labelTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTarget.Location = new System.Drawing.Point(380, 9);
            this.labelTarget.Name = "labelTarget";
            this.labelTarget.Size = new System.Drawing.Size(44, 20);
            this.labelTarget.TabIndex = 1;
            this.labelTarget.Text = "Cible";
            // 
            // comboBoxSource
            // 
            this.comboBoxSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSource.FormattingEnabled = true;
            this.comboBoxSource.Location = new System.Drawing.Point(12, 36);
            this.comboBoxSource.Name = "comboBoxSource";
            this.comboBoxSource.Size = new System.Drawing.Size(158, 28);
            this.comboBoxSource.TabIndex = 2;
            this.comboBoxSource.DropDown += new System.EventHandler(this.comboBoxSource_DropDown);
            this.comboBoxSource.SelectedIndexChanged += new System.EventHandler(this.comboBoxSource_SelectedIndexChanged);
            // 
            // listBoxTarget
            // 
            this.listBoxTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTarget.FormattingEnabled = true;
            this.listBoxTarget.ItemHeight = 20;
            this.listBoxTarget.Location = new System.Drawing.Point(326, 36);
            this.listBoxTarget.Name = "listBoxTarget";
            this.listBoxTarget.Size = new System.Drawing.Size(158, 204);
            this.listBoxTarget.TabIndex = 3;
            this.listBoxTarget.SelectedIndexChanged += new System.EventHandler(this.listBoxTarget_SelectedIndexChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Enabled = false;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(207, 36);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(77, 30);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = ">";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAddRemove_Click);
            // 
            // buttonAddAll
            // 
            this.buttonAddAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddAll.Location = new System.Drawing.Point(207, 83);
            this.buttonAddAll.Name = "buttonAddAll";
            this.buttonAddAll.Size = new System.Drawing.Size(77, 30);
            this.buttonAddAll.TabIndex = 5;
            this.buttonAddAll.Text = ">>";
            this.buttonAddAll.UseVisualStyleBackColor = true;
            this.buttonAddAll.Click += new System.EventHandler(this.buttonAddRemove_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Enabled = false;
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemove.Location = new System.Drawing.Point(207, 171);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(77, 30);
            this.buttonRemove.TabIndex = 6;
            this.buttonRemove.Text = "<";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonAddRemove_Click);
            // 
            // buttonRemoveAll
            // 
            this.buttonRemoveAll.Enabled = false;
            this.buttonRemoveAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveAll.Location = new System.Drawing.Point(207, 218);
            this.buttonRemoveAll.Name = "buttonRemoveAll";
            this.buttonRemoveAll.Size = new System.Drawing.Size(77, 30);
            this.buttonRemoveAll.TabIndex = 7;
            this.buttonRemoveAll.Text = "<<";
            this.buttonRemoveAll.UseVisualStyleBackColor = true;
            this.buttonRemoveAll.Click += new System.EventHandler(this.buttonAddRemove_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Enabled = false;
            this.buttonDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDown.Image = ((System.Drawing.Image)(resources.GetObject("buttonDown.Image")));
            this.buttonDown.Location = new System.Drawing.Point(406, 254);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(42, 50);
            this.buttonDown.TabIndex = 9;
            this.buttonDown.UseVisualStyleBackColor = true;
            // 
            // buttonUp
            // 
            this.buttonUp.Enabled = false;
            this.buttonUp.Image = ((System.Drawing.Image)(resources.GetObject("buttonUp.Image")));
            this.buttonUp.Location = new System.Drawing.Point(358, 254);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(42, 50);
            this.buttonUp.TabIndex = 10;
            this.buttonUp.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 319);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonRemoveAll);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAddAll);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBoxTarget);
            this.Controls.Add(this.comboBoxSource);
            this.Controls.Add(this.labelTarget);
            this.Controls.Add(this.labelSource);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSource;
        private System.Windows.Forms.Label labelTarget;
        private System.Windows.Forms.ComboBox comboBoxSource;
        private System.Windows.Forms.ListBox listBoxTarget;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonAddAll;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonRemoveAll;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonUp;
    }
}

