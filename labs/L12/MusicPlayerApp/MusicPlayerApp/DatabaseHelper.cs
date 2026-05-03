using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace MusicPlayerApp
{
    public static class DatabaseHelper
    {
        private static readonly string _connectionString =
            ConfigurationManager.ConnectionStrings["music_player"].ConnectionString;

        public static void InsertMusicTrack(MusicTrack musicTrack)
        {
            string query = "INSERT INTO music_tracks (title, artist, album, genre, duration, file_name, file_data, file_size, added_date, play_count) " +
                "VALUES (@title, @artist, @album, @genre, @duration, @file_name, @file_data, @file_size, @added_date, @play_count)";
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@title", musicTrack.Title);
                    cmd.Parameters.AddWithValue("@artist", musicTrack.Artist);
                    cmd.Parameters.AddWithValue("@album", musicTrack.Album);
                    cmd.Parameters.AddWithValue("@genre", musicTrack.Genre);
                    cmd.Parameters.AddWithValue("@duration", musicTrack.Duration);
                    cmd.Parameters.AddWithValue("@file_name", musicTrack.FileName);
                    cmd.Parameters.AddWithValue("@file_data", musicTrack.FileData);
                    cmd.Parameters.AddWithValue("@file_size", musicTrack.FileSize);
                    cmd.Parameters.AddWithValue("@added_date", musicTrack.AddedDate);
                    cmd.Parameters.AddWithValue("@play_count", musicTrack.PlayCount);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<MusicTrack> GetMusicTracks()
        {
            var tracks = new List<MusicTrack>();
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand("SELECT * FROM music_tracks", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                        tracks.Add(new MusicTrack
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Title = reader["title"].ToString(),
                            Artist = reader["artist"].ToString(),
                            Album = reader["album"].ToString(),
                            Genre = reader["genre"].ToString(),
                            Duration = TimeSpan.Parse(reader["duration"].ToString()),
                            FileName = reader["file_name"].ToString(),
                            FileData = (byte[])reader["file_data"],
                            FileSize = Convert.ToInt64(reader["file_size"]),
                            AddedDate = Convert.ToDateTime(reader["added_date"]),
                            PlayCount = Convert.ToInt32(reader["play_count"])
                        });
            }
            return tracks;
        }

        public static void UpdatePlayCount(int id, int newPlayCount)
        {
            string query = "UPDATE music_tracks SET play_count = @play_count WHERE id = @id";
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@play_count", newPlayCount);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void DeleteMusicTrack(int id)
        {
            string query = "DELETE FROM music_tracks WHERE id = @id";
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
}
