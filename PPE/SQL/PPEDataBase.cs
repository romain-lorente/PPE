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
        private const string ADRESSE = "localhost"; // DESKTOP-VM2DUPG\\MSSQLSERVER01 pour romain
        private const string DATABASE = "PPE";
        private const string USERNAME = "Romain";
        private const string PASSWORD = "Epsi2019";

        private static SqlConnection connexion;

        public static PPETableUtilisateur Utilisateur { private set; get; }
        public static PPETableVerbe Verbe { private set; get; }
        public static PPETableMot Mot { private set; get; }
        public static PPETableNom Nom { private set; get; }
        public static PPETableAdjectif Adjectif { private set; get; }

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
        }

        public static void Deconnexion()
        {
            //Fermeture de la connexion
            connexion.Close();
            connexion.Dispose();
        }

    }
}
