using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace PPE_Desktop
{
    public partial class Ajout : Form
    {
        public Ajout()
        {
            InitializeComponent();
        }
        DBConnection dbCon = new DBConnection();
        private void bt_ajout_Click(object sender, EventArgs e)
        {
            DBConnection dbCon = new DBConnection();
            dbCon.Server = "localhost";
            dbCon.DatabaseName = "ppe";
            dbCon.UserName = "root";
            dbCon.Password = "";
            if (dbCon.IsConnect())
            {
                //Parcours Classique d'un curseur, adressage des colonnes par leur position ordinale dans la requête
                string query = "select idu, nom, prenom, mail from participant;";
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var TheReader = cmd.ExecuteReader();//Remplissage du curseur
                TheReader.Close();
            
                Participant UnParticipant = new Participant(); ;
            String NomParticipant, PrenomParticipant, EmailParticipant;
            NomParticipant = tb_Nom.Text;
            PrenomParticipant = tb_Prenom.Text;
            EmailParticipant = tb_Mail.Text;
            UnParticipant.Init(NomParticipant, PrenomParticipant, EmailParticipant);
            UnParticipant.Save(dbCon, TheReader);
                tb_Nom.Clear();
                tb_Prenom.Clear();
                tb_Mail.Clear();
                lb_sortie.Text = "ajout reussi";
            }
            else
            {
                MessageBox.Show("pas de connexion à la base de données");
            }
        }
    }
}
