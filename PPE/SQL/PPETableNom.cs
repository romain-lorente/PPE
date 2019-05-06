using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE
{
    class PPETableNom
    {
        private SqlConnection connexion;

        public PPETableNom(SqlConnection connexion)
        {
            this.connexion = connexion;
        }

        public Nom SelectOne(Mot mot)
        {
            List<Dictionary<string, object>> results = SQLUtils.ExecuteReader("SELECT * FROM Nom WHERE idMot = " + mot.Id + ";", connexion);
            List<Nom> parsedResults = ParseResults(results);
            if (parsedResults.Count > 0)
            {
                return parsedResults[0];
            }

            return null;
        }


        public void InsertOne(Nom nom)
        {
            string sqlCommand = string.Format(
                "INSERT INTO Nom(idMot, nature) VALUES ({0}, '{1}');",
                new object[]
                {
                    nom.Id,
                    nom.Nature
                }
            );

            SQLUtils.Execute(sqlCommand, connexion);
        }

        public List<Nom> ParseResults(List<Dictionary<string, object>> results)
        {
            List<Nom> noms = new List<Nom>();
            foreach (Dictionary<string, object> row in results)
            {
                int idMot = (int)row["idMot"];
                string texte = (string)row["texte"];
                string genre = (string)row["genre"];
                string nombre = (string)row["nombre"];
                string nature = (string)row["fonction"];

                noms.Add(new Nom(idMot, texte, genre, nombre, nature));
            }
            return noms;
        }
    }
}
