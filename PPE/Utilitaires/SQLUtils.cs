using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PPE
{
    public class SQLUtils
    {
        public static List<Dictionary<string, object>> ExecuteReader(string commandSql, SqlConnection connexion)
        {
            List<Dictionary<string, object>> results = new List<Dictionary<string, object>>();

            SqlCommand command = new SqlCommand(commandSql, connexion);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        Dictionary<string, object> row = new Dictionary<string, object>();
                        for(int i = 0; i < reader.FieldCount; i++)
                        {
                            row.Add(reader.GetName(i), reader.GetValue(i));
                        }
                        results.Add(row);
                    }
                }
            }

            return results;
        }

        public static void Execute(string commandSql, SqlConnection connexion)
        {
            SqlCommand command = new SqlCommand(commandSql, connexion);
            command.ExecuteNonQuery();
        }

        public static void PrintResult(List<Dictionary<string, object>> results)
        {
            if(results.Count > 0)
            {
                Console.WriteLine("*****************************************************************");
                Console.WriteLine("**                         Resultats                           **");
                Console.WriteLine("*****************************************************************");
                foreach (Dictionary<string, object> row in results)
                {
                    foreach (string columnName in row.Keys)
                    {
                        Console.WriteLine("[" + columnName + "] - " + row[columnName]);
                    }
                    Console.WriteLine("*****************************************************************");
                }
            }
        }
    }
}
