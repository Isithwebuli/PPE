using System;
using MySql.Data.MySqlClient;
namespace PPE_Desktop
{
    public class Participant
    {
        public int ParticipantID { get; set; }
        public string ParticipantNom { get; set; }
        public string ParticipantPrenom { get; set; }
        public string ParticipantMail { get; set; }

        public void Init(String ParticipantN, String ParticipantP, String ParticipantM)
        {
            ParticipantNom = ParticipantN;
            ParticipantPrenom = ParticipantP;
            ParticipantMail = ParticipantM;
        }
        public void Save(DBConnection DataBaseConnection, MySqlDataReader TheReader)
        {
            if(ParticipantID > 0)
            {
                UpdateParticipant(DataBaseConnection, TheReader);
            }
            else
            {
                AddParticipant(DataBaseConnection, TheReader);
            }
        }
        private int GiveNewID(DBConnection DataBaseConnection, MySqlDataReader TheReader)
        {
            int Newidu = 0;
            try
            {
                String sqlString = "SELECT MAX(idu) FROM Participant;";
                var cmd = new MySqlCommand(sqlString, DataBaseConnection.Connection);
                TheReader = cmd.ExecuteReader();

                while (TheReader.Read())
                { Newidu = TheReader.GetInt32(0); }
                TheReader.Close();
                Newidu++;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.Write("Erreur N° " + ex.Number + " : " + ex.Message);
            }
            return Newidu;
        }


        private void AddParticipant(DBConnection DataBaseConnection, MySqlDataReader TheReader)
        {
            try
            {
                ParticipantID = GiveNewID(DataBaseConnection, TheReader);
                String sqlString = "INSERT INTO Participant(idu,nom,prenom,mail) VALUES(?idu,?nom,?prenom,?mail)";
                sqlString = Tools.PrepareLigne(sqlString, "?idu", Tools.PrepareChamp(ParticipantID.ToString(), "Nombre"));
                sqlString = Tools.PrepareLigne(sqlString, "?nom", Tools.PrepareChamp(ParticipantNom, "Chaine"));
                sqlString = Tools.PrepareLigne(sqlString, "?prenom", Tools.PrepareChamp(ParticipantPrenom, "Chaine"));
                sqlString = Tools.PrepareLigne(sqlString, "?mail", Tools.PrepareChamp(ParticipantMail, "Chaine"));
                var cmd = new MySqlCommand(sqlString, DataBaseConnection.Connection);
                cmd.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.Write("Erreur N° " + ex.Number + " : " + ex.Message);
            }

        }
        private void UpdateParticipant(DBConnection DataBaseConnection, MySqlDataReader TheReader)
        {
            try
            {
                String sqlString = "UPDATE Participant SET nom = ?nom, prenom = ?prenom, mail = ?mail WHERE idu = ?idu";
                sqlString = Tools.PrepareLigne(sqlString, "?idu", Tools.PrepareChamp(ParticipantID.ToString(), "Nombre"));
                sqlString = Tools.PrepareLigne(sqlString, "?nom", Tools.PrepareChamp(ParticipantNom, "Chaine"));
                sqlString = Tools.PrepareLigne(sqlString, "?prenom", Tools.PrepareChamp(ParticipantPrenom, "Chaine"));
                sqlString = Tools.PrepareLigne(sqlString, "?mail", Tools.PrepareChamp(ParticipantMail, "Chaine"));
                var cmd = new MySqlCommand(sqlString, DataBaseConnection.Connection);
                cmd.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.Write("Erreur N° " + ex.Number + " : " + ex.Message);
            }
        }
    }
}


