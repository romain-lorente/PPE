using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE
{
    public class PPEDataBase
    {
        private const string ADRESSE = "172.16.196.4";
        private const string DATABASE = "bdqlegrand";
        private const string USERNAME = "qlegrand";
        private const string PASSWORD = "Qwerty62";

        private static SqlConnection connexion;

        public static PPETableUtilisateur Utilisateur { private set; get; }
        public static PPETableVerbe Verbe { private set; get; }
        public static PPETableMot Mot { private set; get; }
        public static PPETableNom Nom { private set; get; }
        public static PPETableAdjectif Adjectif { private set; get; }
        public static PPETablePhrase Phrase { private set; get; }
        public static PPETableMotDansPhrase MotDansPhrase { private set; get; }

        public static void Connexion()
        {
            //Creation de la chaine de connexion
            string connexionStr = "";
            connexionStr += "Data Source=" + ADRESSE + ";";
            connexionStr += "Initial Catalog=" + DATABASE + ";";
            connexionStr += "Persist Security Info=True;";
            connexionStr += "User ID=" + USERNAME + ";";
            connexionStr += "Password=" + PASSWORD;

            //Ouverture de la connexion
            connexion = new SqlConnection(connexionStr);
            connexion.Open();
            
            //Creation des differente tables
            Utilisateur = new PPETableUtilisateur(connexion);
            Verbe = new PPETableVerbe(connexion);
            Mot = new PPETableMot(connexion);
            Nom = new PPETableNom(connexion);
            Adjectif = new PPETableAdjectif(connexion);
            Phrase = new PPETablePhrase(connexion);
            MotDansPhrase = new PPETableMotDansPhrase(connexion);
        }

        public static void Deconnexion()
        {
            //Fermeture de la connexion
            connexion.Close();
            connexion.Dispose();
        }

    }
}
