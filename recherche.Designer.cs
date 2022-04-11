
namespace PPE_Desktop
{
    partial class recherche
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
            this.tb_recherche = new System.Windows.Forms.TextBox();
            this.bt_recherche = new System.Windows.Forms.Button();
            this.lb_sortie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_recherche
            // 
            this.tb_recherche.Location = new System.Drawing.Point(247, 182);
            this.tb_recherche.Name = "tb_recherche";
            this.tb_recherche.Size = new System.Drawing.Size(313, 22);
            this.tb_recherche.TabIndex = 0;
            // 
            // bt_recherche
            // 
            this.bt_recherche.Location = new System.Drawing.Point(351, 210);
            this.bt_recherche.Name = "bt_recherche";
            this.bt_recherche.Size = new System.Drawing.Size(103, 23);
            this.bt_recherche.TabIndex = 1;
            this.bt_recherche.Text = "recherche";
            this.bt_recherche.UseVisualStyleBackColor = true;
            this.bt_recherche.Click += new System.EventHandler(this.bt_recherche_Click);
            // 
            // lb_sortie
            // 
            this.lb_sortie.AutoSize = true;
            this.lb_sortie.Location = new System.Drawing.Point(259, 269);
            this.lb_sortie.Name = "lb_sortie";
            this.lb_sortie.Size = new System.Drawing.Size(0, 17);
            this.lb_sortie.TabIndex = 3;
            // 
            // recherche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_sortie);
            this.Controls.Add(this.bt_recherche);
            this.Controls.Add(this.tb_recherche);
            this.Name = "recherche";
            this.Text = "recherche";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_recherche;
        private System.Windows.Forms.Button bt_recherche;
        private System.Windows.Forms.Label lb_sortie;
    }
}