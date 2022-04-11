using MySql.Data.MySqlClient;
using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE_Desktop
{
    public partial class QRcode : Form
    {
        public QRcode()
        {
            InitializeComponent();
        }
        private void bt_QRcode_Click(object sender, EventArgs e)
        {
            lb_sortie.Text = "";
            DBConnection dbCon = new DBConnection();
            dbCon.Server = "localhost";
            dbCon.DatabaseName = "ppe";
            dbCon.UserName = "root";
            dbCon.Password = "";
            if (dbCon.IsConnect())
            {
                String NomParticipant = tb_nom.Text;

                String query = "select nom,prenom,mail FROM participant where nom = ?nom";
                query = Tools.PrepareLigne(query, "?nom", Tools.PrepareChamp(NomParticipant, "Chaine"));
                var cmd = new MySqlCommand(query, dbCon.Connection);
                List<Participant> LesParticipantTrouves = new List<Participant>();
                MySqlDataReader TheReader = cmd.ExecuteReader();
                while (TheReader.Read())
                {

                    Participant unParticipant = new Participant
                    {
                        ParticipantNom = (string)TheReader["nom"],
                        ParticipantPrenom = (string)TheReader["prenom"],
                        ParticipantMail = (string)TheReader["mail"]
                    };
                    LesParticipantTrouves.Add(unParticipant);
                }
                if (LesParticipantTrouves.Count > 0)
                {
                    foreach (Participant leParticipant in LesParticipantTrouves)
                        lb_sortie.Text += (" nom : " + leParticipant.ParticipantNom + Environment.NewLine
                                            + " prenom : " + leParticipant.ParticipantPrenom + Environment.NewLine
                                            + " mail :" + leParticipant.ParticipantMail + Environment.NewLine);
                

                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(lb_sortie.Text, QRCodeGenerator.ECCLevel.Q);

                Base64QRCode qrCode = new Base64QRCode(qrCodeData);
                string qrCodeImageAsBase64 = qrCode.GetGraphic(20);

                StreamWriter monStreamWriter = new StreamWriter(@"BadgeSalon.html");//Necessite using System.IO;

                String strImage = "<img src = \"data:image/png;base64," + qrCodeImageAsBase64 + "\">";
                monStreamWriter.WriteLine("<html>");
                monStreamWriter.WriteLine("<body>");
                string temptext = "<P>" + "Le contenue du QRcode" + "</P>";
                monStreamWriter.WriteLine(temptext);
                temptext = "<P>" + lb_sortie.Text + "</P>";
                monStreamWriter.WriteLine(temptext);
                monStreamWriter.WriteLine(strImage);    //Ecriture de l'image base 64 dans le fichier
                monStreamWriter.WriteLine("</body>");
                monStreamWriter.WriteLine("</html>");

                // Fermeture du StreamWriter (Très important) 
                monStreamWriter.Close();
                lb_sortie.Text = "QRcode crée";
                }
                else
                {
                    MessageBox.Show("pas de résutal");
                    TheReader.Close();
                }
            }
            else
            {
                MessageBox.Show("pas de connexion à la base de données");
            }
        }
    }
}
