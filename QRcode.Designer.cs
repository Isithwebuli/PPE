
namespace PPE_Desktop
{
    partial class QRcode
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
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_QRcode = new System.Windows.Forms.Button();
            this.lb_sortie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_nom
            // 
            this.tb_nom.Location = new System.Drawing.Point(297, 187);
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.Size = new System.Drawing.Size(226, 22);
            this.tb_nom.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "nom";
            // 
            // bt_QRcode
            // 
            this.bt_QRcode.Location = new System.Drawing.Point(297, 228);
            this.bt_QRcode.Name = "bt_QRcode";
            this.bt_QRcode.Size = new System.Drawing.Size(226, 23);
            this.bt_QRcode.TabIndex = 6;
            this.bt_QRcode.Text = "Générer le QRcode";
            this.bt_QRcode.UseVisualStyleBackColor = true;
            this.bt_QRcode.Click += new System.EventHandler(this.bt_QRcode_Click);
            // 
            // lb_sortie
            // 
            this.lb_sortie.AutoSize = true;
            this.lb_sortie.Location = new System.Drawing.Point(271, 311);
            this.lb_sortie.Name = "lb_sortie";
            this.lb_sortie.Size = new System.Drawing.Size(0, 17);
            this.lb_sortie.TabIndex = 7;
            // 
            // QRcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_sortie);
            this.Controls.Add(this.bt_QRcode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_nom);
            this.Name = "QRcode";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_nom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_QRcode;
        private System.Windows.Forms.Label lb_sortie;
    }
}