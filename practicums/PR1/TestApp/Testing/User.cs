using System;

namespace Testing
{
    public static class User
    {
        public static int Id { get; set; } = 0;
        public static string FirstName { get; set; } = string.Empty;
        public static string LastName { get; set; } = string.Empty;
        public static DateTime TestDate { get; set; } = DateTime.Now;
        public static int Score { get; set; } = 0;
        public static int TimeSpent { get; set; } = 0;
        public static bool IsCompleted { get; set; } = false;
    }
}
