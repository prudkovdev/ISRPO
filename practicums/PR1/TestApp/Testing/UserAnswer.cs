using System;

namespace Testing
{
    public class UserAnswer
    {
        public int UserId { get; set; }
        public int QuestionId { get; set; }
        public int SelectedAnswer { get; set; }
        public bool IsCorrect { get; set; }
        public TimeSpan AnswerTime { get; set; }

        public string GetInfo()
        {
            return $"UserId: {UserId}, \n" +
                $"QuestionId: {QuestionId}, \n" +
                $"SelectedAnswer: {SelectedAnswer}, \n" +
                $"IsCorrect: {IsCorrect}, \n" +
                $"AnswerTime: {AnswerTime}";
        }
    }
}
