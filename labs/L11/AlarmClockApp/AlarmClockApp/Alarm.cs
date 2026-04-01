using System;

namespace AlarmClockApp
{
    public class Alarm
    {
        public int Id { get; set; } = 0;
        public TimeSpan AlarmTime { get; set; } = DateTime.Now.TimeOfDay;
        public bool IsActive { get; set; } = true;
        public bool RepeatDaily { get; set; } = false;
        public string Label { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
