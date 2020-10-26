namespace ListBoxMain
{
    partial class mainWindow
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
            this.labelText = new System.Windows.Forms.Label();
            this.labelIndex = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxIndex = new System.Windows.Forms.TextBox();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonEmpty = new System.Windows.Forms.Button();
            this.buttonAddList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxName = new System.Windows.Forms.ListBox();
            this.labelProporties = new System.Windows.Forms.Label();
            this.labelItems = new System.Windows.Forms.Label();
            this.labelSelectedIndex = new System.Windows.Forms.Label();
            this.labelTextName = new System.Windows.Forms.Label();
            this.textBoxItems = new System.Windows.Forms.TextBox();
            this.textBoxSelectedIndex = new System.Windows.Forms.TextBox();
            this.textBoxTextName = new System.Windows.Forms.TextBox();
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderIndex = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIndex)).BeginInit();
            this.SuspendLayout();
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText.Location = new System.Drawing.Point(12, 9);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(143, 20);
            this.labelText.TabIndex = 0;
            this.labelText.Text = "Nouvel Eléments";
            // 
            // labelIndex
            // 
            this.labelIndex.AutoSize = true;
            this.labelIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIndex.Location = new System.Drawing.Point(214, 9);
            this.labelIndex.Name = "labelIndex";
            this.labelIndex.Size = new System.Drawing.Size(124, 20);
            this.labelIndex.TabIndex = 1;
            this.labelIndex.Text = "Index Elément";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(16, 43);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(150, 26);
            this.textBoxName.TabIndex = 2;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxIndex
            // 
            this.textBoxIndex.Location = new System.Drawing.Point(218, 43);
            this.textBoxIndex.Name = "textBoxIndex";
            this.textBoxIndex.Size = new System.Drawing.Size(39, 20);
            this.textBoxIndex.TabIndex = 3;
            this.textBoxIndex.TextChanged += new System.EventHandler(this.textBoxIndex_TextChanged);
            // 
            // buttonSelect
            // 
            this.buttonSelect.Enabled = false;
            this.buttonSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelect.Location = new System.Drawing.Point(304, 43);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(150, 30);
            this.buttonSelect.TabIndex = 4;
            this.buttonSelect.Text = "Sélectionner";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // buttonEmpty
            // 
            this.buttonEmpty.Enabled = false;
            this.buttonEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmpty.Location = new System.Drawing.Point(304, 79);
            this.buttonEmpty.Name = "buttonEmpty";
            this.buttonEmpty.Size = new System.Drawing.Size(150, 30);
            this.buttonEmpty.TabIndex = 5;
            this.buttonEmpty.Text = "Vider la liste";
            this.buttonEmpty.UseVisualStyleBackColor = true;
            this.buttonEmpty.Click += new System.EventHandler(this.buttonEmpty_Click);
            // 
            // buttonAddList
            // 
            this.buttonAddList.Enabled = false;
            this.buttonAddList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddList.Location = new System.Drawing.Point(16, 79);
            this.buttonAddList.Name = "buttonAddList";
            this.buttonAddList.Size = new System.Drawing.Size(150, 30);
            this.buttonAddList.TabIndex = 6;
            this.buttonAddList.Text = "Ajout liste";
            this.buttonAddList.UseVisualStyleBackColor = true;
            this.buttonAddList.Click += new System.EventHandler(this.buttonAddList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "LstListe";
            // 
            // listBoxName
            // 
            this.listBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxName.FormattingEnabled = true;
            this.listBoxName.ItemHeight = 20;
            this.listBoxName.Location = new System.Drawing.Point(20, 170);
            this.listBoxName.Name = "listBoxName";
            this.listBoxName.Size = new System.Drawing.Size(150, 104);
            this.listBoxName.TabIndex = 8;
            this.listBoxName.SelectedIndexChanged += new System.EventHandler(this.listBoxName_SelectedIndexChanged);
            // 
            // labelProporties
            // 
            this.labelProporties.AutoSize = true;
            this.labelProporties.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProporties.Location = new System.Drawing.Point(214, 136);
            this.labelProporties.Name = "labelProporties";
            this.labelProporties.Size = new System.Drawing.Size(91, 20);
            this.labelProporties.TabIndex = 9;
            this.labelProporties.Text = "Propriétés";
            // 
            // labelItems
            // 
            this.labelItems.AutoSize = true;
            this.labelItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItems.Location = new System.Drawing.Point(218, 170);
            this.labelItems.Name = "labelItems";
            this.labelItems.Size = new System.Drawing.Size(96, 20);
            this.labelItems.TabIndex = 10;
            this.labelItems.Text = "Items.Count";
            // 
            // labelSelectedIndex
            // 
            this.labelSelectedIndex.AutoSize = true;
            this.labelSelectedIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectedIndex.Location = new System.Drawing.Point(218, 204);
            this.labelSelectedIndex.Name = "labelSelectedIndex";
            this.labelSelectedIndex.Size = new System.Drawing.Size(111, 20);
            this.labelSelectedIndex.TabIndex = 11;
            this.labelSelectedIndex.Text = "SelectedIndex";
            // 
            // labelTextName
            // 
            this.labelTextName.AutoSize = true;
            this.labelTextName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextName.Location = new System.Drawing.Point(218, 237);
            this.labelTextName.Name = "labelTextName";
            this.labelTextName.Size = new System.Drawing.Size(39, 20);
            this.labelTextName.TabIndex = 12;
            this.labelTextName.Text = "Text";
            // 
            // textBoxItems
            // 
            this.textBoxItems.Enabled = false;
            this.textBoxItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxItems.Location = new System.Drawing.Point(354, 167);
            this.textBoxItems.Name = "textBoxItems";
            this.textBoxItems.Size = new System.Drawing.Size(35, 26);
            this.textBoxItems.TabIndex = 13;
            // 
            // textBoxSelectedIndex
            // 
            this.textBoxSelectedIndex.Enabled = false;
            this.textBoxSelectedIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSelectedIndex.Location = new System.Drawing.Point(354, 201);
            this.textBoxSelectedIndex.Name = "textBoxSelectedIndex";
            this.textBoxSelectedIndex.Size = new System.Drawing.Size(35, 26);
            this.textBoxSelectedIndex.TabIndex = 14;
            // 
            // textBoxTextName
            // 
            this.textBoxTextName.Enabled = false;
            this.textBoxTextName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTextName.Location = new System.Drawing.Point(354, 234);
            this.textBoxTextName.Name = "textBoxTextName";
            this.textBoxTextName.Size = new System.Drawing.Size(100, 26);
            this.textBoxTextName.TabIndex = 15;
            // 
            // errorProviderName
            // 
            this.errorProviderName.ContainerControl = this;
            // 
            // errorProviderIndex
            // 
            this.errorProviderIndex.ContainerControl = this;
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 288);
            this.Controls.Add(this.textBoxTextName);
            this.Controls.Add(this.textBoxSelectedIndex);
            this.Controls.Add(this.textBoxItems);
            this.Controls.Add(this.labelTextName);
            this.Controls.Add(this.labelSelectedIndex);
            this.Controls.Add(this.labelItems);
            this.Controls.Add(this.labelProporties);
            this.Controls.Add(this.listBoxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddList);
            this.Controls.Add(this.buttonEmpty);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.textBoxIndex);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelIndex);
            this.Controls.Add(this.labelText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "mainWindow";
            this.Text = "ListBox et leurs propriétés";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIndex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Label labelIndex;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxIndex;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Button buttonEmpty;
        private System.Windows.Forms.Button buttonAddList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxName;
        private System.Windows.Forms.Label labelProporties;
        private System.Windows.Forms.Label labelItems;
        private System.Windows.Forms.Label labelSelectedIndex;
        private System.Windows.Forms.Label labelTextName;
        private System.Windows.Forms.TextBox textBoxItems;
        private System.Windows.Forms.TextBox textBoxSelectedIndex;
        private System.Windows.Forms.TextBox textBoxTextName;
        private System.Windows.Forms.ErrorProvider errorProviderName;
        private System.Windows.Forms.ErrorProvider errorProviderIndex;
    }
}

