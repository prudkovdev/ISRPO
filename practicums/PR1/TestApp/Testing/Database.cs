using System.Data.SqlClient;
using System.Configuration;

namespace Testing
{
    public static class Database
    {
        public static SqlConnection Connection { get; } = new SqlConnection(ConfigurationManager.ConnectionStrings["test_db"].ConnectionString);

        public static void OpenConnection()
        {
            if (Connection.State == System.Data.ConnectionState.Closed)
                Connection.Open();
        }

        public static void CloseConnection()
        {
            if (Connection.State == System.Data.ConnectionState.Open)
                Connection.Close();
        }
    }
}
