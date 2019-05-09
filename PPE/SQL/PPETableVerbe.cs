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

        public Verbe SelectOneForConjugaison(Conjugaison conjugaison)
        {
            string sqlCommand = string.Format(
                "SELECT * FROM VerbeAndMot WHERE idMot_1P = {0} OR idMot_1S = {0} OR idMot_2P = {0} OR idMot_2S = {0} OR idMot_3P = {0} OR idMot_3S = {0}",
                new object[]
                {
                    conjugaison.Id

                }
            );

            List<Dictionary<string, object>> results = SQLUtils.ExecuteReader(sqlCommand, connexion);
            List<Verbe> parsedResults = ParseResults(results);
            if (parsedResults.Count > 0)
            {
                return parsedResults[0];
            }

            return null;
        }

        public Verbe SelectOne(Mot mot)
        {
            List<Dictionary<string, object>> results = SQLUtils.ExecuteReader("SELECT * FROM VerbeAndMot WHERE idMot = " + mot.Id + ";", connexion);
            List<Verbe> parsedResults = ParseResults(results);
            if (parsedResults.Count > 0)
            {
                return parsedResults[0];
            }

            return null;
        }

        public void InsertOne(Verbe verbe)
        {
            foreach (Mot conjugaison in verbe.Conjugaisons)
            {
                PPEDataBase.Mot.InsertOne(conjugaison);
                Console.WriteLine(conjugaison.Id);
            }

            string sqlCommand = string.Format(
                "INSERT INTO Verbe(idMot, idMot_1S, idMot_2S, idMot_3S, idMot_1P, idMot_2P, idMot_3P, fonction) VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6}, '{7}');",
                new object[]
                {
                    verbe.Id,
                    verbe.Conjugaisons[0].Id,
                    verbe.Conjugaisons[1].Id,
                    verbe.Conjugaisons[2].Id,
                    verbe.Conjugaisons[3].Id,
                    verbe.Conjugaisons[4].Id,
                    verbe.Conjugaisons[5].Id,
                    verbe.Fonction,
                }
            );

            SQLUtils.Execute(sqlCommand, connexion);
        }

        public List<Verbe> ParseResults(List<Dictionary<string, object>> results)
        {
            List<Verbe> verbes = new List<Verbe>();
            foreach (Dictionary<string, object> row in results)
            {
                string fonction = (string)row["fonction"];

                int idMot = (int)row["idMot"];
                int idMot_1S = (int)row["idMot_1S"];
                int idMot_2S = (int)row["idMot_2S"];
                int idMot_3S = (int)row["idMot_3S"];
                int idMot_1P = (int)row["idMot_1P"];
                int idMot_2P = (int)row["idMot_2P"];
                int idMot_3P = (int)row["idMot_3P"];

                string texte = (string)row["texte"];
                string texte_1S = (string)row["texte_1S"];
                string texte_2S = (string)row["texte_2S"];
                string texte_3S = (string)row["texte_3S"];
                string texte_1P = (string)row["texte_1P"];
                string texte_2P = (string)row["texte_2P"];
                string texte_3P = (string)row["texte_3P"];

                string genre = (string)row["genre"];
                string genre_1S = (string)row["genre_1S"];
                string genre_2S = (string)row["genre_2S"];
                string genre_3S = (string)row["genre_3S"];
                string genre_1P = (string)row["genre_1P"];
                string genre_2P = (string)row["genre_2P"];
                string genre_3P = (string)row["genre_3P"];

                string nombre = (string)row["nombre"];
                string nombre_1S = (string)row["nombre_1S"];
                string nombre_2S = (string)row["nombre_2S"];
                string nombre_3S = (string)row["nombre_3S"];
                string nombre_1P = (string)row["nombre_1P"];
                string nombre_2P = (string)row["nombre_2P"];
                string nombre_3P = (string)row["nombre_3P"];

                Conjugaison[] mots = new Conjugaison[]
                {
                new Conjugaison(idMot_1S, texte_1S, genre_1S, nombre_1S),
                new Conjugaison(idMot_2S, texte_2S, genre_2S, nombre_2S),
                new Conjugaison(idMot_3S, texte_3S, genre_3S, nombre_3S),
                new Conjugaison(idMot_1P, texte_1P, genre_1P, nombre_1P),
                new Conjugaison(idMot_2P, texte_2P, genre_2P, nombre_2P),
                new Conjugaison(idMot_3P, texte_3P, genre_3P, nombre_3P)
                };

                verbes.Add(new Verbe(idMot, texte, fonction, mots));
            }
            return verbes;
        }
    }

    public class CopyOfPPETableVerbe
    {
        private SqlConnection connexion;

        public CopyOfPPETableVerbe(SqlConnection connexion)
        {
            this.connexion = connexion;
        }

        public Verbe SelectOneForConjugaison(Conjugaison conjugaison)
        {
            string sqlCommand = string.Format(
                "SELECT * FROM VerbeAndMot WHERE idMot_1P = {0} OR idMot_1S = {0} OR idMot_2P = {0} OR idMot_2S = {0} OR idMot_3P = {0} OR idMot_3S = {0}",
                new object[]
                {
                    conjugaison.Id

                }
            );

            List<Dictionary<string, object>> results = SQLUtils.ExecuteReader(sqlCommand, connexion);
            List<Verbe> parsedResults = ParseResults(results);
            if (parsedResults.Count > 0)
            {
                return parsedResults[0];
            }

            return null;
        }

        public Verbe SelectOne(Mot mot)
        {
            List<Dictionary<string, object>> results = SQLUtils.ExecuteReader("SELECT * FROM VerbeAndMot WHERE idMot = " + mot.Id + ";", connexion);
            List<Verbe> parsedResults = ParseResults(results);
            if (parsedResults.Count > 0)
            {
                return parsedResults[0];
            }

            return null;
        }

        public void InsertOne(Verbe verbe)
        {
            foreach (Mot conjugaison in verbe.Conjugaisons)
            {
                PPEDataBase.Mot.InsertOne(conjugaison);
                Console.WriteLine(conjugaison.Id);
            }

            string sqlCommand = string.Format(
                "INSERT INTO Verbe(idMot, idMot_1S, idMot_2S, idMot_3S, idMot_1P, idMot_2P, idMot_3P, fonction) VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6}, '{7}');",
                new object[]
                {
                    verbe.Id,
                    verbe.Conjugaisons[0].Id,
                    verbe.Conjugaisons[1].Id,
                    verbe.Conjugaisons[2].Id,
                    verbe.Conjugaisons[3].Id,
                    verbe.Conjugaisons[4].Id,
                    verbe.Conjugaisons[5].Id,
                    verbe.Fonction,
                }
            );

            SQLUtils.Execute(sqlCommand, connexion);
        }

        public List<Verbe> ParseResults(List<Dictionary<string, object>> results)
        {
            List<Verbe> verbes = new List<Verbe>();
            foreach (Dictionary<string, object> row in results)
            {
                string fonction = (string)row["fonction"];

                int idMot = (int)row["idMot"];
                int idMot_1S = (int)row["idMot_1S"];
                int idMot_2S = (int)row["idMot_2S"];
                int idMot_3S = (int)row["idMot_3S"];
                int idMot_1P = (int)row["idMot_1P"];
                int idMot_2P = (int)row["idMot_2P"];
                int idMot_3P = (int)row["idMot_3P"];

                string texte = (string)row["texte"];
                string texte_1S = (string)row["texte_1S"];
                string texte_2S = (string)row["texte_2S"];
                string texte_3S = (string)row["texte_3S"];
                string texte_1P = (string)row["texte_1P"];
                string texte_2P = (string)row["texte_2P"];
                string texte_3P = (string)row["texte_3P"];

                string genre = (string)row["genre"];
                string genre_1S = (string)row["genre_1S"];
                string genre_2S = (string)row["genre_2S"];
                string genre_3S = (string)row["genre_3S"];
                string genre_1P = (string)row["genre_1P"];
                string genre_2P = (string)row["genre_2P"];
                string genre_3P = (string)row["genre_3P"];

                string nombre = (string)row["nombre"];
                string nombre_1S = (string)row["nombre_1S"];
                string nombre_2S = (string)row["nombre_2S"];
                string nombre_3S = (string)row["nombre_3S"];
                string nombre_1P = (string)row["nombre_1P"];
                string nombre_2P = (string)row["nombre_2P"];
                string nombre_3P = (string)row["nombre_3P"];

                Conjugaison[] mots = new Conjugaison[]
                {
                new Conjugaison(idMot_1S, texte_1S, genre_1S, nombre_1S),
                new Conjugaison(idMot_2S, texte_2S, genre_2S, nombre_2S),
                new Conjugaison(idMot_3S, texte_3S, genre_3S, nombre_3S),
                new Conjugaison(idMot_1P, texte_1P, genre_1P, nombre_1P),
                new Conjugaison(idMot_2P, texte_2P, genre_2P, nombre_2P),
                new Conjugaison(idMot_3P, texte_3P, genre_3P, nombre_3P)
                };

                verbes.Add(new Verbe(idMot, texte, fonction, mots));
            }
            return verbes;
        }
    }
}