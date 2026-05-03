using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DailyPlannerApp
{
    public static class DatabaseHelper
    {
        private static readonly string _connectionString = "Server=IDEAPADS145\\SQLEXPRESS;Database=daily_planner_db;Trusted_Connection=True;";

        public static List<Note> GetNotes()
        {
            var notes = new List<Note>();
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand("SELECT * FROM notes", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                        notes.Add(new Note
                        {
                            Id = reader.GetInt32(0),
                            DateTime = reader.GetDateTime(1),
                            Text = reader.GetString(2),
                            CreatedAt = reader.GetDateTime(3)
                        });
            }
            return notes;
        }

        public static void InsertNote(Note note)
        {
            string query = "INSERT INTO notes (datetime, text, created_at) VALUES " +
            "(@datetime, @text, @created_at)";
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@datetime", note.DateTime);
                    cmd.Parameters.AddWithValue("@text", note.Text);
                    cmd.Parameters.AddWithValue("@created_at", note.CreatedAt);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateNote(Note note)
        {
            string query = "UPDATE notes SET " +
            "datetime = @datetime," +
            "text = @text " +
            "WHERE id = @id";
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", note.Id);
                    cmd.Parameters.AddWithValue("@datetime", note.DateTime);
                    cmd.Parameters.AddWithValue("@text", note.Text);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void DeleteNote(int id)
        {
            string query = "DELETE FROM notes WHERE id = @id";
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }

    public class Note
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public string Text { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
