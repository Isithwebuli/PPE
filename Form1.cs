using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE_Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_Ajout_Click(object sender, EventArgs e)
        {
            Ajout ajout = new Ajout();
            ajout.Show();
        }

        private void bt_Recherche_Click(object sender, EventArgs e)
        {
            recherche Recherche = new recherche();
            Recherche.Show();
        }

        private void bt_QRcode_Click(object sender, EventArgs e)
        {
            QRcode QRcode = new QRcode();
            QRcode.Show();
        }
    }
}
