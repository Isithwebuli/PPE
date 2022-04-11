using System;
using System.Data;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
namespace PPE_Desktop
{
    public static class Tools
    {


        public static String PrepareChamp(String LaValeur, String LeType)
        {
            string ValeurPreparee = "";
            switch (LeType)
            {
                case "Chaine":
                    ValeurPreparee = "'" + LaValeur + "'";
                    break;

                case "Nombre":
                    ValeurPreparee = LaValeur;
                    break;
            }
            return ValeurPreparee;
        }

        public static String PrepareLigne(String LaLigne, String LeMotCle, String LaValeur)
        {
            string LignePreparee = "";
            LignePreparee = LaLigne.Replace(LeMotCle, LaValeur);
            return LignePreparee;
        }

        public static void AppelerProcedureStockee(DBConnection DataBaseConnection)
        {
            try
            {
                String sqlString = "Compter_Enregistrement";
                var cmd = new MySqlCommand(sqlString, DataBaseConnection.Connection);
                cmd.CommandType = CommandType.StoredProcedure; //Il faut System.Data pour cette ligne

                cmd.Parameters.Add("@NbLignes", MySqlDbType.Int32);
                cmd.Parameters["@NbLignes"].Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                Console.WriteLine("Nombre de Client(s): " + cmd.Parameters["@NbLignes"].Value);
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.Write("Erreur N° " + ex.Number + " : " + ex.Message);
            }
        }

    }
}
