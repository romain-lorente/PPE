using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE
{
    public class PPETableAdjectif
    {
        private SqlConnection connexion;

        public PPETableAdjectif(SqlConnection connexion)
        {
            this.connexion = connexion;
        }

        public Adjectif SelectOne(Mot mot)
        {
            List<Dictionary<string, object>> results = SQLUtils.ExecuteReader("SELECT * FROM AdjectifAndMot WHERE idMot = " + mot.Id + ";", connexion);
            List<Adjectif> parsedResults = ParseResults(results);
            if (parsedResults.Count > 0)
            {
                return parsedResults[0];
            }

            return null;
        }


        public void InsertOne(Adjectif adjectif)
        {
            string sqlCommand = string.Format(
                "INSERT INTO Adjectif(idMot, fonction) VALUES ({0}, '{1}');",
                new object[]
                {
                    adjectif.Id,
                    adjectif.Fonction
                }
            );

            SQLUtils.Execute(sqlCommand, connexion);
        }

        public List<Adjectif> ParseResults(List<Dictionary<string, object>> results)
        {
            List<Adjectif> noms = new List<Adjectif>();
            foreach (Dictionary<string, object> row in results)
            {
                int idMot = (int)row["idMot"];
                string texte = (string)row["texte"];
                string genre = (string)row["genre"];
                string nombre = (string)row["nombre"];
                string fonction = (string)row["fonction"];

                noms.Add(new Adjectif(idMot, texte, genre, nombre, fonction));
            }
            return noms;
        }
    }
}
