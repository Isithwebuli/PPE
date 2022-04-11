
namespace PPE_Desktop
{
    partial class Ajout
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Nom = new System.Windows.Forms.TextBox();
            this.tb_Mail = new System.Windows.Forms.TextBox();
            this.tb_Prenom = new System.Windows.Forms.TextBox();
            this.bt_ajout = new System.Windows.Forms.Button();
            this.lb_sortie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prenom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mail";
            // 
            // tb_Nom
            // 
            this.tb_Nom.Location = new System.Drawing.Point(173, 94);
            this.tb_Nom.Name = "tb_Nom";
            this.tb_Nom.Size = new System.Drawing.Size(213, 22);
            this.tb_Nom.TabIndex = 3;
            // 
            // tb_Mail
            // 
            this.tb_Mail.Location = new System.Drawing.Point(173, 150);
            this.tb_Mail.Name = "tb_Mail";
            this.tb_Mail.Size = new System.Drawing.Size(213, 22);
            this.tb_Mail.TabIndex = 4;
            // 
            // tb_Prenom
            // 
            this.tb_Prenom.Location = new System.Drawing.Point(172, 122);
            this.tb_Prenom.Name = "tb_Prenom";
            this.tb_Prenom.Size = new System.Drawing.Size(213, 22);
            this.tb_Prenom.TabIndex = 5;
            // 
            // bt_ajout
            // 
            this.bt_ajout.Location = new System.Drawing.Point(293, 204);
            this.bt_ajout.Name = "bt_ajout";
            this.bt_ajout.Size = new System.Drawing.Size(92, 39);
            this.bt_ajout.TabIndex = 6;
            this.bt_ajout.Text = "Ajouter";
            this.bt_ajout.UseVisualStyleBackColor = true;
            this.bt_ajout.Click += new System.EventHandler(this.bt_ajout_Click);
            // 
            // lb_sortie
            // 
            this.lb_sortie.AutoSize = true;
            this.lb_sortie.Location = new System.Drawing.Point(172, 264);
            this.lb_sortie.Name = "lb_sortie";
            this.lb_sortie.Size = new System.Drawing.Size(0, 17);
            this.lb_sortie.TabIndex = 7;
            // 
            // Ajout
            // 
            this.ClientSize = new System.Drawing.Size(751, 456);
            this.Controls.Add(this.lb_sortie);
            this.Controls.Add(this.bt_ajout);
            this.Controls.Add(this.tb_Prenom);
            this.Controls.Add(this.tb_Mail);
            this.Controls.Add(this.tb_Nom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ajout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Nom;
        private System.Windows.Forms.TextBox tb_Mail;
        private System.Windows.Forms.TextBox tb_Prenom;
        private System.Windows.Forms.Button bt_ajout;
        private System.Windows.Forms.Label lb_sortie;
    }
}