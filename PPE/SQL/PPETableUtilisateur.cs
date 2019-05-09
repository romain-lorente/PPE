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

        //Retourne une liste de dix utilisateurs triés par score
        public Dictionary<string, string> SelectLeaderboard()
        {
            Dictionary<string, string> liste = new Dictionary<string, string>();

            List<Dictionary<string, object>> results = SQLUtils.ExecuteReader("SELECT TOP 10 username, bstScore FROM Utilisateur ORDER BY bstScore DESC;", connexion);
            foreach (Dictionary<string, object> row in results)
            {
                string username = (string)row["username"];
                string bstScore = row["bstScore"].ToString();

                liste.Add(username, bstScore);
            }

            return liste;
        }

        public List<Utilisateur> SelectAll()
        {
            List<Utilisateur> liste = new List<Utilisateur>();

            List<Dictionary<string, object>> results = SQLUtils.ExecuteReader("SELECT * FROM Utilisateur ORDER BY 1;", connexion);
            foreach (Dictionary<string, object> row in results)
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
            List<Dictionary<string, object>> results = SQLUtils.ExecuteReader("SELECT * FROM Utilisateur WHERE username = '" + usernameToFind + "';", connexion);
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
            string sqlCommand = string.Format(
                "INSERT INTO Utilisateur(username, password, nom, prenom, bstScore, isAdmin) VALUES ('{0}', '{1}', '{2}', '{3}', {4}, {5});",
                new object[]
                {
                    utilisateur.Login,
                    utilisateur.MotDePasse,
                    utilisateur.Nom,
                    utilisateur.Prenom,
                    utilisateur.MeilleurScore,
                    utilisateur.EstAdministrateur ? 1 : 0
                }
            );

            SQLUtils.Execute(sqlCommand, connexion);
        }

        public void UpdateOne(Utilisateur utilisateur)
        {
            string sqlCommand = string.Format(
                "UPDATE Utilisateur SET password = '{1}', nom = '{2}',  prenom = '{3}', bstScore = {4}, isAdmin = {5} WHERE username = '{0}'",
                new object[]
                {
                    utilisateur.Login,
                    utilisateur.MotDePasse,
                    utilisateur.Nom,
                    utilisateur.Prenom,
                    utilisateur.MeilleurScore,
                    utilisateur.EstAdministrateur ? 1 : 0
                }
            );

            SQLUtils.Execute(sqlCommand, connexion);
        }

        public bool Existe(string usernameToFind)
        {
            List<Dictionary<string, object>> results = SQLUtils.ExecuteReader("SELECT * FROM Utilisateur WHERE username = '" + usernameToFind + "';", connexion);
            return results.Count > 0;
        }
    }
}
