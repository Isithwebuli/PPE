using System;
using System.Collections.Generic;
using System.IO;
using MySql.Data.MySqlClient;
using QRCoder;
namespace PPE_Desktop
{
    public static class Interface
    {
        public static int MenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("...................Bienvenue au salon............");
            Console.WriteLine("1 : Ajouter un participant ");
            Console.WriteLine("2 : Rechercher un participant");
            Console.WriteLine("3 : Quitter");
            Console.WriteLine("");
            Console.Write("Votre choix : - ");
            try
            {
                String LeChoix = Console.ReadLine();
                return int.Parse(LeChoix);
            }
            catch
            {
                return 0; //Erreur de Saisie
            }
        }
        public static void TraiterChoix(int LeChoix, DBConnection dbCon, MySqlDataReader TheReader)
        {
            switch (LeChoix)
            {
                case 0:
                    Console.WriteLine("Les choix possibles sont 1, 2 ou 3. Appuyez sur une touche pour continuer");
                    Console.ReadKey();
                    break;

                case 1:
                    Console.WriteLine("Vous souhaitez ajouter un participant. Appuyez sur une touche pour continuer");
                    Console.ReadKey();
                    AjouterClient(dbCon, TheReader);
                    break;

                case 2:
                    Console.WriteLine("Vous souhaitez rechercher un participant. Appuyez sur une touche pour continuer");
                    Console.ReadKey();
                    rechercheClient(dbCon, TheReader);
                    break;

                case 3:
                    Console.WriteLine("Géneration du QRcode.....");
                    String IDParticipant, PrenomParticipant, EmailParticipant;
                    Console.Write("...................ID du participant ? ");
                    IDParticipant = Console.ReadLine();
                    Console.Write("...................Nom du participant ? ");
                    PrenomParticipant = Console.ReadLine();
                    Console.Write("...................Prenom du participant ? ");
                    EmailParticipant = Console.ReadLine();
                    FabriquerBadge(int.Parse(IDParticipant), PrenomParticipant, EmailParticipant);
                    break;
            }
        }

        public static void AjouterClient(DBConnection dbCon, MySqlDataReader TheReader)
        {
            Participant UnParticipant = new Participant(); ;
            String NomParticipant, PrenomParticipant, EmailParticipant;
            Console.Clear();
            Console.WriteLine(".....................................................");
            Console.Write("...................Nom du participant ? ");
            NomParticipant = Console.ReadLine();
            Console.Write("...................Prenom du participant ? ");
            PrenomParticipant = Console.ReadLine();
            Console.Write("...................email du participant ? ");
            EmailParticipant = Console.ReadLine();
            Console.WriteLine("...................Voulez-vous enregistrer ce participant (O/N) ?");
            String Reponse = "";
            do
                try
                {
                    Reponse = Console.ReadLine();
                    Reponse = Reponse.ToUpper();//On convertit en majuscule
                    if (Reponse == "O")
                        //Ici on effectue l'enregistrement dans la BDD
                        UnParticipant.Init(NomParticipant, PrenomParticipant, EmailParticipant);
                    UnParticipant.Save(dbCon, TheReader);
                    Console.WriteLine("Le participant est enregistré");
                    System.Threading.Thread.Sleep(2000);//On patiente deux secondes
                }
                catch
                {
                    Console.WriteLine("Choix incorrect");
                }
            while ((Reponse != "o") && (Reponse != "O") && (Reponse != "n") && (Reponse != "N"));
        }

        internal static void choixUtilisateur(int menu, DBConnection dbCon, object reader)
        {
            throw new NotImplementedException();
        }

        public static void rechercheClient(DBConnection DataBaseConnection, MySqlDataReader TheReader)
        {
                String NomParticipant;
                Console.Clear();
                Console.WriteLine(".....................................................");
                Console.Write("...................Nom du participant recherché : ");
                NomParticipant = Console.ReadLine();

                String query = "select nom,prenom,mail FROM participant where nom = ?nom";
                query = Tools.PrepareLigne(query, "?nom", Tools.PrepareChamp(NomParticipant, "Chaine"));
                var cmd = new MySqlCommand(query, DataBaseConnection.Connection);
                List<Participant> LesParticipantTrouves = new List<Participant>();
                TheReader = cmd.ExecuteReader();

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
                    Console.WriteLine(".................Participant trouves........................");
                    foreach (Participant leParticipant in LesParticipantTrouves)
                        Console.WriteLine(leParticipant.ParticipantNom
                                            + " " + leParticipant.ParticipantPrenom
                                            + " mail :" + leParticipant.ParticipantMail);

                }
                else
                    Console.WriteLine("je n'ai personne, ");
                Console.WriteLine("Appuyer sur une touche pour continuer");
                Console.ReadKey();
                TheReader.Close();
            }
        public static void FabriquerBadge(int TheparticipantID, String UnNom, String UnPrenom) //Fabrication du badge du participant dont on a reçu l'id
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(TheparticipantID.ToString(), QRCodeGenerator.ECCLevel.Q);

            Base64QRCode qrCode = new Base64QRCode(qrCodeData);
            string qrCodeImageAsBase64 = qrCode.GetGraphic(20);

            StreamWriter monStreamWriter = new StreamWriter(@"BadgeSalon.html");//Necessite using System.IO;

            String strImage = "<img src = \"data:image/png;base64," + qrCodeImageAsBase64 + "\">";
            monStreamWriter.WriteLine("<html>");
            monStreamWriter.WriteLine("<body>");
            string temptext = "<P>" + UnNom + "</P>";
            monStreamWriter.WriteLine(temptext);
            temptext = "<P>" + UnPrenom + "</P>";
            monStreamWriter.WriteLine(temptext);
            monStreamWriter.WriteLine(strImage);    //Ecriture de l'image base 64 dans le fichier
            monStreamWriter.WriteLine("</body>");
            monStreamWriter.WriteLine("</html>");

            // Fermeture du StreamWriter (Très important) 
            monStreamWriter.Close();
            Console.WriteLine("Le QRCode est généré. Appuyer sur une touche pour continuer");
            Console.ReadKey();

        }
    }
    }