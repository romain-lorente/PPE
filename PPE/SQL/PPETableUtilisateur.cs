using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE
{
    public class PPETableUtilisateur
    {
        private SqlConnection connexion;

        public PPETableUtilisateur(SqlConnection connexion)
        {
            this.connexion = connexion;
        }

        public List<Utilisateur> SelectAll()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Utilisateur ORDER BY 1;", connexion);

            List<Utilisateur> liste = new List<Utilisateur>();

            List<Dictionary<string, object>> results = SQLUtils.ReadResult(command);
            foreach(Dictionary<string, object> row in results)
            {
                string username = (string)row["username"];
                string password = (string)row["password"];
                string nom = (string)row["nom"];
                string prenom = (string)row["prenom"];
                int bstScore = (int)row["bstScore"];
                bool isAdmin = (int)row["isAdmin"] > 0;

                liste.Add(new Utilisateur(username, password, nom, prenom, bstScore, isAdmin));
            }

            return liste;
        }

        public Utilisateur SelectOne(string usernameToFind)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Utilisateur WHERE username = '" + usernameToFind + "';", connexion);

            List<Dictionary<string, object>> results = SQLUtils.ReadResult(command);
            if (results.Count > 0)
            {
                Dictionary<string, object> row = results[0];

                string username = (string)row["username"];
                string password = (string)row["password"];
                string nom = (string)row["nom"];
                string prenom = (string)row["prenom"];
                int bstScore = (int)row["bstScore"];
                bool isAdmin = (int)row["isAdmin"] > 0;

                return new Utilisateur(username, password, nom, prenom, bstScore, isAdmin);
            }
            return null;
        }

        public void InsertOne(Utilisateur utilisateur)
        {
            string sqlCommand = "INSERT INTO Utilisateur(username, password, nom, prenom, bstScore, isAdmin) VALUES ('{0}', '{1}', '{2}', '{3}', {4}, {5});";

            object[] args = new object[]
            {
                utilisateur.Login,
                utilisateur.MotDePasse,
                utilisateur.Nom,
                utilisateur.Prenom,
                utilisateur.MeilleurScore,
                utilisateur.EstAdministrateur ? 1 : 0
            };

            sqlCommand = string.Format(sqlCommand, args);

            SqlCommand command = new SqlCommand(sqlCommand, connexion);
            command.ExecuteNonQuery();
        }

        public void UpdateOne(Utilisateur utilisateur)
        {
            string sqlCommand = "UPDATE Utilisateur SET password = '{1}', nom = '{2}',  prenom = '{3}', bstScore = {4}, isAdmin = {5} WHERE username = '{0}'";

            object[] args = new object[]
            {
                utilisateur.Login,
                utilisateur.MotDePasse,
                utilisateur.Nom,
                utilisateur.Prenom,
                utilisateur.MeilleurScore,
                utilisateur.EstAdministrateur ? 1 : 0
            };

            sqlCommand = string.Format(sqlCommand, args);

            Console.WriteLine("Mise a jour dans la base de données: " + sqlCommand);


            SqlCommand command = new SqlCommand(sqlCommand, connexion);
            command.ExecuteNonQuery();
        }

        public bool Existe(string usernameToFind)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Utilisateur WHERE username = '" + usernameToFind + "';", connexion);
            List<Dictionary<string, object>> results = SQLUtils.ReadResult(command);
            return results.Count > 0;
        }
    }
}
