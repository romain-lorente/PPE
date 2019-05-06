using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE
{
    public class PPETablePhrase
    {
        private SqlConnection connexion;

        public PPETablePhrase(SqlConnection connexion)
        {
            this.connexion = connexion;
        }

        public Phrase SelectOne(int id)
        {
            List<Dictionary<string, object>> results = SQLUtils.ExecuteReader("SELECT * FROM Phrase WHERE id = " + id + ";", connexion);
            List<Phrase> parsedResults = ParseResults(results);
            if (parsedResults.Count > 0)
            {
                return parsedResults[0];
            }

            return null;
        }

        public void InsertOne(Phrase phrase)
        {
            string sqlCommand = string.Format(
                "INSERT INTO Phrase(texte) VALUES ('{0}');SELECT MAX(id) AS id FROM Phrase;",
                new object[]
                {
                    phrase.Texte
                }
            );

            List<Dictionary<string, object>> result = SQLUtils.ExecuteReader(sqlCommand, connexion);
            if (result.Count > 0 && result[0].ContainsKey("id"))
                phrase.Id = (int)result[0]["id"];

            foreach(MotDansPhrase mot in phrase.MotsDansPhrases)
            {
                PPEDataBase.MotDansPhrase.InsertOne(mot, phrase.Id);
            }
        }

        public List<Phrase> ParseResults(List<Dictionary<string, object>> results)
        {
            List<Phrase> liste = new List<Phrase>();
            foreach (Dictionary<string, object> row in results)
            {
                int id = (int)row["id"];
                string texte = (string)row["texte"];

                List<MotDansPhrase> listeMots = PPEDataBase.MotDansPhrase.SelectByPhrase(id);
                Phrase phrase = new Phrase(id, texte, listeMots.ToArray());

                liste.Add(phrase);
            }
            return liste;
        }
    }
}
