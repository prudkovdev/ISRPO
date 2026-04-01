using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace AlarmClockApp
{
    public static class DatabaseHelper
    {
        private static readonly string _ConnectionString =
            ConfigurationManager.ConnectionStrings["alarm_clock"].ConnectionString;

        public static List<Alarm> GetAlarms()
        {
            var alarms = new List<Alarm>();
            using (var conn = new SqlConnection(_ConnectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand("SELECT * FROM alarms", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        var alarm = new Alarm
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            AlarmTime = TimeSpan.Parse(reader["alarm_time"].ToString()),
                            IsActive = Convert.ToBoolean(reader["is_active"]),
                            RepeatDaily = Convert.ToBoolean(reader["repeat_daily"]),
                            Label = reader["label"].ToString(),
                            CreatedDate = Convert.ToDateTime(reader["created_date"])
                        };
                        alarms.Add(alarm);
                    }

            }
            return alarms;
        }

        public static void InsertAlarm(Alarm alarm)
        {
            string query = "INSERT INTO alarms (alarm_time, is_active, repeat_daily, label, created_date) " +
                "VALUES (@alarm_time, @is_active, @repeat_daily, @label, @created_date)";
            using (var conn = new SqlConnection(_ConnectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@alarm_time", alarm.AlarmTime);
                    cmd.Parameters.AddWithValue("@is_active", alarm.IsActive);
                    cmd.Parameters.AddWithValue("@repeat_daily", alarm.RepeatDaily);
                    cmd.Parameters.AddWithValue("@label", alarm.Label);
                    cmd.Parameters.AddWithValue("@created_date", alarm.CreatedDate);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateAlarm(Alarm alarm)
        {
            string query = "UPDATE alarms SET " +
                "alarm_time = @alarm_time, " +
                "is_active = @is_active, " +
                "repeat_daily = @repeat_daily, " +
                "label = @label, " +
                "created_date = @created_date " +
                "WHERE id = @id";
            using (var conn = new SqlConnection(_ConnectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", alarm.Id);
                    cmd.Parameters.AddWithValue("@alarm_time", alarm.AlarmTime);
                    cmd.Parameters.AddWithValue("@is_active", alarm.IsActive);
                    cmd.Parameters.AddWithValue("@repeat_daily", alarm.RepeatDaily);
                    cmd.Parameters.AddWithValue("@label", alarm.Label);
                    cmd.Parameters.AddWithValue("@created_date", alarm.CreatedDate);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void DeleteAlarm(int id)
        {
            string query = "DELETE FROM alarms WHERE id = @id";
            using (var conn = new SqlConnection(_ConnectionString))
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
