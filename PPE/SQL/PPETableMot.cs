using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE
{
    public class PPETableMot
    {
        private SqlConnection connexion;

        public PPETableMot(SqlConnection connexion)
        {
            this.connexion = connexion;
        }

        public List<Mot> SelectAll()
        {
            List<Dictionary<string, object>> results = SQLUtils.ExecuteReader("SELECT * FROM Mot ORDER BY 1;", connexion);
            return ParseResult(results);
        }

        public Mot SelectOne(int idToFind)
        {
            List<Dictionary<string, object>> results = SQLUtils.ExecuteReader("SELECT * FROM Mot WHERE id = " + idToFind + ";", connexion);
            List<Mot> parsedResult = ParseResult(results);
            if (parsedResult.Count > 0)
            {
                return parsedResult[0];
            }
            return null;
        }

        public List<Mot> SelectByText(string texte)
        {
            string sqlCommand = string.Format(
                "SELECT * FROM Mot WHERE texte = '{0}'",
                new object[]
                {
                    texte.Replace("'", "''")
                }
            );

            List<Dictionary<string, object>> results = SQLUtils.ExecuteReader(sqlCommand, connexion);
            return ParseResult(results);
        }

        public void InsertOne(Mot mot)
        {
            string sqlCommand = string.Format(
                "INSERT INTO Mot(texte, genre, nombre, type) VALUES ('{0}', '{1}', '{2}', '{3}');SELECT MAX(id) AS id FROM Mot;",
                new object[]
                {
                    mot.Texte.Replace("'", "''"),
                    mot.Genre,
                    mot.Nombre,
                    mot.GetType().Name
                }
            );

            List<Dictionary<string, object>> result = SQLUtils.ExecuteReader(sqlCommand, connexion);
            if(result.Count > 0 && result[0].ContainsKey("id"))
                mot.Id = (int)result[0]["id"];
			
            if(mot is Verbe verbe)
            {
                PPEDataBase.Verbe.InsertOne(verbe);
            }
            else if(mot is Nom nom)
            {
                PPEDataBase.Nom.InsertOne(nom);
            }
            else if(mot is Adjectif adjectif)
            {
                PPEDataBase.Adjectif.InsertOne(adjectif);
            }
        }

        private List<Mot> ParseResult(List<Dictionary<string, object>> results)
        {
            List<Mot> liste = new List<Mot>();

            foreach (Dictionary<string, object> row in results)
            {
                int id = (int)row["id"];
                string texte = (string)row["texte"];
                string genre = (string)row["genre"];
                string nombre = (string)row["nombre"];
                string type = (string)row["type"];

                switch (type)
                {
                    case "Verbe":
                        liste.Add(PPEDataBase.Verbe.SelectOne(new Mot(id, texte, genre, nombre)));
                        break;

                    case "Conjugaison":
                        Conjugaison conjugaison = new Conjugaison(id, texte, genre, nombre);
                        conjugaison.Verbe = PPEDataBase.Verbe.SelectOneForConjugaison(conjugaison);

                        liste.Add(conjugaison);
                        break;

                    case "Nom":
                        liste.Add(PPEDataBase.Nom.SelectOne(new Mot(id, texte, genre, nombre)));
                        break;

                    case "Adjectif":
                        liste.Add(PPEDataBase.Adjectif.SelectOne(new Mot(id, texte, genre, nombre)));
                        break;

                    default:
                        liste.Add(new Mot(id, texte, genre, nombre));
                        break;
                }
            }

            return liste;
        }
    }
}
