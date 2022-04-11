
namespace PPE_Desktop
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
            this.bt_Ajout = new System.Windows.Forms.Button();
            this.bt_Recherche = new System.Windows.Forms.Button();
            this.bt_QRcode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_Ajout
            // 
            this.bt_Ajout.Location = new System.Drawing.Point(342, 145);
            this.bt_Ajout.Name = "bt_Ajout";
            this.bt_Ajout.Size = new System.Drawing.Size(104, 38);
            this.bt_Ajout.TabIndex = 0;
            this.bt_Ajout.Text = "Ajout";
            this.bt_Ajout.UseVisualStyleBackColor = true;
            this.bt_Ajout.Click += new System.EventHandler(this.bt_Ajout_Click);
            // 
            // bt_Recherche
            // 
            this.bt_Recherche.Location = new System.Drawing.Point(342, 189);
            this.bt_Recherche.Name = "bt_Recherche";
            this.bt_Recherche.Size = new System.Drawing.Size(104, 38);
            this.bt_Recherche.TabIndex = 1;
            this.bt_Recherche.Text = "Recherche";
            this.bt_Recherche.UseVisualStyleBackColor = true;
            this.bt_Recherche.Click += new System.EventHandler(this.bt_Recherche_Click);
            // 
            // bt_QRcode
            // 
            this.bt_QRcode.Location = new System.Drawing.Point(342, 233);
            this.bt_QRcode.Name = "bt_QRcode";
            this.bt_QRcode.Size = new System.Drawing.Size(104, 38);
            this.bt_QRcode.TabIndex = 2;
            this.bt_QRcode.Text = "QRcode";
            this.bt_QRcode.UseVisualStyleBackColor = true;
            this.bt_QRcode.Click += new System.EventHandler(this.bt_QRcode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_QRcode);
            this.Controls.Add(this.bt_Recherche);
            this.Controls.Add(this.bt_Ajout);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_Ajout;
        private System.Windows.Forms.Button bt_Recherche;
        private System.Windows.Forms.Button bt_QRcode;
    }
}

