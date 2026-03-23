using KnapsackSolverApp.Debugging;
using KnapsackSolverApp.Entities;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace KnapsackSolverApp.Database
{
    public static class DatabaseHelper
    {
        private static readonly string _masterConnectionString =
            ConfigurationManager.ConnectionStrings["master"].ConnectionString;

        private static readonly string _knapsackConnectionString =
            ConfigurationManager.ConnectionStrings["knapsack"].ConnectionString;

        public static void InitializeDatabase()
        {
            using (SqlConnection conn = new SqlConnection(_masterConnectionString))
            {
                conn.Open();

                string query =
                    "IF DB_ID('knapsack') IS NULL CREATE DATABASE knapsack";

                DebugLogger.LogSqlQuery(query);
                using (SqlCommand cmd = new SqlCommand(query, conn))
                    cmd.ExecuteNonQuery();
            }

            using (SqlConnection conn = new SqlConnection(_knapsackConnectionString))
            {
                conn.Open();

                string query =
                @"IF OBJECT_ID('items') IS NULL
                CREATE TABLE items (
                    Id INT PRIMARY KEY IDENTITY(1,1),
                    Name NVARCHAR(100) NOT NULL,
                    Weight INT NOT NULL,
                    Cost INT NOT NULL
                );

                IF NOT EXISTS (SELECT 1 FROM items)
                INSERT INTO items (Name, Weight, Cost) VALUES
                ('Книга',1,600),
                ('Бинокль',2,5000),
                ('Аптечка',4,1500),
                ('Ноутбук',2,40000),
                ('Котелок',1,500)";

                DebugLogger.LogSqlQuery(query);
                using (SqlCommand cmd = new SqlCommand(query, conn))
                    cmd.ExecuteNonQuery();
            }
        }

        public static List<Item> GetItems()
        {
            List<Item> items = new List<Item>();

            DebugLogger.Log("Загрузка данных из таблицы базы данных items");
            using (var conn = new SqlConnection(_knapsackConnectionString))
            {
                conn.Open();
                DebugLogger.LogSqlQuery("SELECT * FROM items");
                using (var cmd = new SqlCommand("SELECT * FROM items", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        items.Add(new Item
                        {
                            Id = (int)reader["Id"],
                            Name = reader["Name"].ToString(),
                            Weight = (int)reader["Weight"],
                            Cost = (int)reader["Cost"]
                        });

                    DebugLogger.Log($"Загружено {items.Count} записей");
                }
            }

            return items;
        }
    }
}
