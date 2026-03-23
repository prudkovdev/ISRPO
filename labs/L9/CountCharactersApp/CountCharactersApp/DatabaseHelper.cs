using System;
using System.Data.SqlClient;
using System.Configuration;

namespace CountCharactersApp
{
    public static class DatabaseHelper
    {
        private static readonly string _masterConnectionString =
            ConfigurationManager.ConnectionStrings["master"].ConnectionString;

        private static readonly string _mainConnectionString =
            ConfigurationManager.ConnectionStrings["characters_counting"].ConnectionString;

        private static void InitializeDatabase()
        {
            using (SqlConnection conn = new SqlConnection(_masterConnectionString))
            {
                conn.Open();
                string query1 = @"
                    IF DB_ID('characters_counting') IS NULL 
                    CREATE DATABASE characters_counting;";
                using (SqlCommand cmd1 = new SqlCommand(query1, conn))
                {
                    cmd1.ExecuteNonQuery();
                }

                string query2 = "SELECT DB_ID('characters_counting')";
                using (SqlCommand cmd2 = new SqlCommand(query2, conn))
                {
                    if (cmd2.ExecuteScalar() == DBNull.Value)
                        throw new Exception("Не удалось создать базу данных");
                }
            }
        }

        public static void SaveToDatabase(string filePath, string content, int characterCount, string operationType)
        {
            try
            {
                // Проверяем, существует ли база данных
                InitializeDatabase();

                using (var conn = new SqlConnection(_mainConnectionString))
                {
                    conn.Open();

                    // Проверяем, существует ли таблица
                    string query1 = @"
                        IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='file_operations' AND xtype='U')
                        BEGIN
                            CREATE TABLE file_operations (
                                id INT PRIMARY KEY IDENTITY(1,1),
                                file_path NVARCHAR(500),
                                content NVARCHAR(MAX),
                                character_count INT,
                                operation_type NVARCHAR(50),
                                operation_date DATETIME DEFAULT GETDATE()
                            )
                        END";

                    using (var cmd1 = new SqlCommand(query1, conn))
                        cmd1.ExecuteNonQuery();

                    // Вставляем запись об операции
                    string query2 = @"
                        INSERT INTO file_operations (file_path, content, character_count, operation_type) 
                        VALUES (@file_path, @content, @character_count, @operation_type)";

                    using (var command = new SqlCommand(query2, conn))
                    {
                        command.Parameters.AddWithValue("@file_path", filePath ?? "Без пути");
                        command.Parameters.AddWithValue("@content", content ?? "");
                        command.Parameters.AddWithValue("@character_count", characterCount);
                        command.Parameters.AddWithValue("@operation_type", operationType);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Записываем ошибку в отладочный вывод, но не показываем пользователю
                System.Diagnostics.Debug.WriteLine($"Ошибка при сохранении в БД: {ex.Message}");
            }
        }

    }
}
