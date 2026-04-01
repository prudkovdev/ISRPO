using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace FieldOfMiraclesApp
{
    public static class DatabaseHelper
    {
        private static readonly string _ConnectionString =
            ConfigurationManager.ConnectionStrings["field_of_miracles"].ConnectionString;

        public static List<string> GetWords()
        {
            var words = new List<string>();
            using (var conn = new SqlConnection(_ConnectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand("SELECT word FROM words", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                        words.Add(reader.GetString(0));

            }
            return words;
        }

    }
}
