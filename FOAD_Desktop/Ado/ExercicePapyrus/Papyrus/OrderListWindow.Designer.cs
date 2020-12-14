
namespace Papyrus
{
    partial class OrderListWindow
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
            this.labelChooseSuplier = new System.Windows.Forms.Label();
            this.comboBoxSuplier = new System.Windows.Forms.ComboBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelOrderList = new System.Windows.Forms.Label();
            this.listViewOrders = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // labelChooseSuplier
            // 
            this.labelChooseSuplier.AutoSize = true;
            this.labelChooseSuplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChooseSuplier.Location = new System.Drawing.Point(13, 40);
            this.labelChooseSuplier.Name = "labelChooseSuplier";
            this.labelChooseSuplier.Size = new System.Drawing.Size(190, 20);
            this.labelChooseSuplier.TabIndex = 0;
            this.labelChooseSuplier.Text = "Choisissez un fournisseur";
            // 
            // comboBoxSuplier
            // 
            this.comboBoxSuplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSuplier.FormattingEnabled = true;
            this.comboBoxSuplier.Location = new System.Drawing.Point(225, 38);
            this.comboBoxSuplier.Name = "comboBoxSuplier";
            this.comboBoxSuplier.Size = new System.Drawing.Size(150, 28);
            this.comboBoxSuplier.TabIndex = 1;
            this.comboBoxSuplier.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSuplier_SelectedIndexChanged);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(346, 286);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(89, 28);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Quitter";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelOrderList
            // 
            this.labelOrderList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderList.Location = new System.Drawing.Point(17, 136);
            this.labelOrderList.Name = "labelOrderList";
            this.labelOrderList.Size = new System.Drawing.Size(126, 20);
            this.labelOrderList.TabIndex = 3;
            this.labelOrderList.Text = "Les commandes";
            // 
            // listViewOrders
            // 
            this.listViewOrders.HideSelection = false;
            this.listViewOrders.Location = new System.Drawing.Point(17, 169);
            this.listViewOrders.Name = "listViewOrders";
            this.listViewOrders.Size = new System.Drawing.Size(414, 99);
            this.listViewOrders.TabIndex = 4;
            this.listViewOrders.UseCompatibleStateImageBehavior = false;
            // 
            // OrderListWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 326);
            this.Controls.Add(this.listViewOrders);
            this.Controls.Add(this.labelOrderList);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.comboBoxSuplier);
            this.Controls.Add(this.labelChooseSuplier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "OrderListWindow";
            this.Text = "Liste des Commandes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderListWindow_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelChooseSuplier;
        private System.Windows.Forms.ComboBox comboBoxSuplier;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelOrderList;
        private System.Windows.Forms.ListView listViewOrders;
    }
}