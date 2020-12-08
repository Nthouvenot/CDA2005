
namespace Papyrus
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
            this.labelServeur = new System.Windows.Forms.Label();
            this.labelDatabase = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.textBoxServeurName = new System.Windows.Forms.TextBox();
            this.textBoxDataBaseName = new System.Windows.Forms.TextBox();
            this.buttonDsiconect = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelConnexionState = new System.Windows.Forms.Label();
            this.textBoxDbMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelServeur
            // 
            this.labelServeur.AutoSize = true;
            this.labelServeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServeur.Location = new System.Drawing.Point(13, 37);
            this.labelServeur.Name = "labelServeur";
            this.labelServeur.Size = new System.Drawing.Size(72, 20);
            this.labelServeur.TabIndex = 0;
            this.labelServeur.Text = "Serveur :";
            // 
            // labelDatabase
            // 
            this.labelDatabase.AutoSize = true;
            this.labelDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatabase.Location = new System.Drawing.Point(17, 82);
            this.labelDatabase.Name = "labelDatabase";
            this.labelDatabase.Size = new System.Drawing.Size(142, 20);
            this.labelDatabase.TabIndex = 1;
            this.labelDatabase.Text = "Base de données :";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnect.Location = new System.Drawing.Point(33, 129);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(100, 32);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Connexion";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // textBoxServeurName
            // 
            this.textBoxServeurName.Location = new System.Drawing.Point(252, 28);
            this.textBoxServeurName.Name = "textBoxServeurName";
            this.textBoxServeurName.Size = new System.Drawing.Size(210, 20);
            this.textBoxServeurName.TabIndex = 3;
            // 
            // textBoxDataBaseName
            // 
            this.textBoxDataBaseName.Location = new System.Drawing.Point(252, 82);
            this.textBoxDataBaseName.Name = "textBoxDataBaseName";
            this.textBoxDataBaseName.Size = new System.Drawing.Size(210, 20);
            this.textBoxDataBaseName.TabIndex = 4;
            // 
            // buttonDsiconect
            // 
            this.buttonDsiconect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDsiconect.Location = new System.Drawing.Point(310, 129);
            this.buttonDsiconect.Name = "buttonDsiconect";
            this.buttonDsiconect.Size = new System.Drawing.Size(112, 32);
            this.buttonDsiconect.TabIndex = 5;
            this.buttonDsiconect.Text = "Deconnexion";
            this.buttonDsiconect.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(310, 167);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(112, 32);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Quitter";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // labelConnexionState
            // 
            this.labelConnexionState.AutoSize = true;
            this.labelConnexionState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConnexionState.Location = new System.Drawing.Point(33, 246);
            this.labelConnexionState.Name = "labelConnexionState";
            this.labelConnexionState.Size = new System.Drawing.Size(214, 20);
            this.labelConnexionState.TabIndex = 8;
            this.labelConnexionState.Text = "Etat de la connexion : Closed";
            // 
            // textBoxDbMessage
            // 
            this.textBoxDbMessage.Location = new System.Drawing.Point(37, 270);
            this.textBoxDbMessage.Multiline = true;
            this.textBoxDbMessage.Name = "textBoxDbMessage";
            this.textBoxDbMessage.ReadOnly = true;
            this.textBoxDbMessage.Size = new System.Drawing.Size(425, 159);
            this.textBoxDbMessage.TabIndex = 9;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 450);
            this.Controls.Add(this.textBoxDbMessage);
            this.Controls.Add(this.labelConnexionState);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonDsiconect);
            this.Controls.Add(this.textBoxDataBaseName);
            this.Controls.Add(this.textBoxServeurName);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.labelDatabase);
            this.Controls.Add(this.labelServeur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainWindow";
            this.Text = "Connexion a la base de données";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelServeur;
        private System.Windows.Forms.Label labelDatabase;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.TextBox textBoxServeurName;
        private System.Windows.Forms.TextBox textBoxDataBaseName;
        private System.Windows.Forms.Button buttonDsiconect;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelConnexionState;
        private System.Windows.Forms.TextBox textBoxDbMessage;
    }
}

