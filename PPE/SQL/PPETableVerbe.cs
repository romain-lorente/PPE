using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE
{
    public class PPETableVerbe
    {
        private SqlConnection connexion;

        public PPETableVerbe(SqlConnection connexion)
        {
            this.connexion = connexion;
        }

        public Verbe SelectOne(Mot mot)
        {
            List<Dictionary<string, object>> results = SQLUtils.ExecuteReader("SELECT * FROM VerbeAndMot WHERE idMot = " + mot.Id + ";", connexion);
            if(results.Count > 0)
            {
                string fonction = (string)results[0]["fonction"];

                int idMot = (int)results[0]["idMot"];
                int idMot_1S = (int)results[0]["idMot_1S"];
                int idMot_2S = (int)results[0]["idMot_2S"];
                int idMot_3S = (int)results[0]["idMot_3S"];
                int idMot_1P = (int)results[0]["idMot_1P"];
                int idMot_2P = (int)results[0]["idMot_2P"];
                int idMot_3P = (int)results[0]["idMot_3P"];

                string texte = (string)results[0]["texte"];
                string texte_1S = (string)results[0]["texte_1S"];
                string texte_2S = (string)results[0]["texte_2S"];
                string texte_3S = (string)results[0]["texte_3S"];
                string texte_1P = (string)results[0]["texte_1P"];
                string texte_2P = (string)results[0]["texte_2P"];
                string texte_3P = (string)results[0]["texte_3P"];

                string genre = (string)results[0]["genre"];
                string genre_1S = (string)results[0]["genre_1S"];
                string genre_2S = (string)results[0]["genre_2S"];
                string genre_3S = (string)results[0]["genre_3S"];
                string genre_1P = (string)results[0]["genre_1P"];
                string genre_2P = (string)results[0]["genre_2P"];
                string genre_3P = (string)results[0]["genre_3P"];

                string nombre = (string)results[0]["nombre"];
                string nombre_1S = (string)results[0]["nombre_1S"];
                string nombre_2S = (string)results[0]["nombre_2S"];
                string nombre_3S = (string)results[0]["nombre_3S"];
                string nombre_1P = (string)results[0]["nombre_1P"];
                string nombre_2P = (string)results[0]["nombre_2P"];
                string nombre_3P = (string)results[0]["nombre_3P"];

                Mot[] mots = new Mot[]
                {
                    new Mot(idMot_1S, texte_1S, genre_1S, nombre_1S),
                    new Mot(idMot_2S, texte_2S, genre_2S, nombre_2S),
                    new Mot(idMot_3S, texte_3S, genre_3S, nombre_3S),
                    new Mot(idMot_1P, texte_1P, genre_1P, nombre_1P),
                    new Mot(idMot_2P, texte_2P, genre_2P, nombre_2P),
                    new Mot(idMot_3P, texte_3P, genre_3P, nombre_3P)
                };

                return new Verbe(idMot, texte, fonction, mots);
            }


            return null; 
        }
    }
}
