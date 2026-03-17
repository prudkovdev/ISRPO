using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using KnapsackSolverApp.Debugging;

namespace KnapsackSolverApp.Database
{
    public static class DatabaseTester
    {
        private static readonly string _connectionString = ConfigurationManager.ConnectionStrings["knapsack"].ConnectionString;

        /// <summary>
        /// Проверяет подключение к базе данных и выводит диагностическую информацию
        /// </summary>
        [Conditional("DEBUG")]
        public static void TestConnection()
        {
            try
            {
                DebugLogger.Log("Проверка подключения к базе данных...");

                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    DebugLogger.Log("Подключение к базе данных успешно установлено");

                    // Проверка наличия данных в таблице objects
                    string query = "SELECT COUNT(*) FROM items";
                    using (var cmd = new SqlCommand(query, connection))
                    {
                        int count = (int)cmd.ExecuteScalar();
                        DebugLogger.Log($"В таблице items найдено {count} записей");
                    }

                    // Вывод списка всех таблиц в базе данных
                    string tablesQuery = @"
                        SELECT TABLE_NAME 
                        FROM INFORMATION_SCHEMA.TABLES 
                        WHERE TABLE_TYPE = 'BASE TABLE'";

                    using (var tablesCmd = new SqlCommand(tablesQuery, connection))
                    using (var reader = tablesCmd.ExecuteReader())
                    {
                        DebugLogger.Log("Доступные таблицы:");
                        while (reader.Read())
                        {
                            DebugLogger.Log($"  - {reader["TABLE_NAME"]}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                DebugLogger.Log($"Ошибка подключения к БД: {ex.Message}");
                DebugLogger.Log($"Stack trace: {ex.StackTrace}");
            }
        }
    }
}
