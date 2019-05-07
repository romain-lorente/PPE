using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE
{
    public class PPETableMotDansPhrase
    {
        private SqlConnection connexion;

        public PPETableMotDansPhrase(SqlConnection connexion)
        {
            this.connexion = connexion;
        }

        public List<MotDansPhrase> SelectByPhrase(int idPhrase)
        {
            string sqlCommand = string.Format(
                "SELECT * FROM MotDansPhrase WHERE idPhrase = '{0}' ORDER BY position",
                new object[]
                {
                    idPhrase
                }
            );

            List<Dictionary<string, object>> results = SQLUtils.ExecuteReader(sqlCommand, connexion);
            return ParseResult(results);
        }

        public void InsertOne(MotDansPhrase motDansPhrase, int idPhrase)
        {
            string sqlCommand = string.Format(
                "INSERT INTO MotDansPhrase(idMot, idPhrase, position) VALUES ('{0}', '{1}', '{2}');SELECT MAX(id) AS id FROM MotDansPhrase;",
                new object[]
                {
                    motDansPhrase.Mot.Id,
                    idPhrase,
                    motDansPhrase.Position
                }
            );

            List<Dictionary<string, object>> result = SQLUtils.ExecuteReader(sqlCommand, connexion);
            if(result.Count > 0 && result[0].ContainsKey("id"))
                motDansPhrase.Id = (int)result[0]["id"];
        }

        private List<MotDansPhrase> ParseResult(List<Dictionary<string, object>> results)
        {
            List<MotDansPhrase> liste = new List<MotDansPhrase>();

            foreach (Dictionary<string, object> row in results)
            {
                int id = (int)row["id"];
                int idMot = (int)row["idMot"];
                int position = (int)row["position"];

                liste.Add(new MotDansPhrase(id, PPEDataBase.Mot.SelectOne(idMot), position));
            }

            return liste;
        }
    }
}
