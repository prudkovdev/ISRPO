using System.Data.SqlClient;

namespace SkladApp
{
    class DataBase
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=IDEAPADS145\SQLEXPRESS;Initial Catalog=sklad;Integrated Security=True;Encrypt=False");

        public void OpenConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void CloseConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }
    }
}
