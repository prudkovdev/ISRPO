using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Testing
{
    public partial class TestForm : Form
    {
        private DataTable _questionsTable;
        private int _questionNum;
        private TimeSpan _time = TimeSpan.FromMinutes(25);
        private int _timeSpent = 0;
        private List<UserAnswer> _userAnswers;

        private int QuestionNum
        {
            get { return _questionNum; }
            set
            {
                if (value >= 0 && value < _questionsTable.Rows.Count)
                {
                    _questionNum = value;
                    LoadQuestion(_questionNum);
                }
            }
        }

        public TestForm()
        {
            InitializeComponent();
            var cmd = new SqlCommand("SELECT * FROM questions", Database.Connection);
            var adapter = new SqlDataAdapter();
            _questionsTable = new DataTable();
            _userAnswers = new List<UserAnswer>();

            adapter.SelectCommand = cmd;
            adapter.Fill(_questionsTable);
        }

        private void LoadQuestion(int questionNum)
        {
            lQuestionNum.Text = $"Вопрос {questionNum + 1} из {_questionsTable.Rows.Count}";
            lQuestion.Text = $"Вопрос: {_questionsTable.Rows[questionNum].ItemArray[1].ToString()}";

            rbOption1.Text = _questionsTable.Rows[questionNum].ItemArray[2].ToString();
            rbOption2.Text = _questionsTable.Rows[questionNum].ItemArray[3].ToString();
            rbOption3.Text = _questionsTable.Rows[questionNum].ItemArray[4].ToString();
            rbOption4.Text = _questionsTable.Rows[questionNum].ItemArray[5].ToString();
        }

        private void MapToInsertUser()
        {
            string query = "INSERT INTO users (first_name, last_name, test_date, score, time_spent, is_completed) " +
                "OUTPUT INSERTED.id " +
                "VALUES (@first_name, @last_name, @test_date, @score, @time_spent, @is_completed)";

            using (var cmd = new SqlCommand(query, Database.Connection))
            {
                cmd.Parameters.AddWithValue("@first_name", User.FirstName);
                cmd.Parameters.AddWithValue("@last_name", User.LastName);
                cmd.Parameters.AddWithValue("@test_date", User.TestDate);
                cmd.Parameters.AddWithValue("@score", User.Score);
                cmd.Parameters.AddWithValue("@time_spent", User.TimeSpent);
                cmd.Parameters.AddWithValue("@is_completed", User.IsCompleted);

                User.Id = (int)cmd.ExecuteScalar();
            }
        }

        private void MapToInsertUserAnswer(UserAnswer userAnswer)
        {
            string query = "INSERT INTO user_answers (user_id, question_id, selected_answer, is_correct, answer_time) " +
                "VALUES (@user_id, @question_id, @selected_answer, @is_correct, @answer_time)";

            using (var cmd = new SqlCommand(query, Database.Connection))
            {
                cmd.Parameters.AddWithValue("@user_id", User.Id);
                cmd.Parameters.AddWithValue("@question_id", userAnswer.QuestionId);
                cmd.Parameters.AddWithValue("@selected_answer", (object)userAnswer.SelectedAnswer ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@is_correct", (object)userAnswer.IsCorrect ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@answer_time", (object)userAnswer.AnswerTime ?? DBNull.Value);
                cmd.ExecuteNonQuery();
            }
        }

        private void Exit()
        {
            timerTest.Stop();
            timerTest.Dispose();

            User.TimeSpent = _timeSpent;
            if (User.Score == _userAnswers.Count)
                User.IsCompleted = true;
            else
                User.IsCompleted = false;

            Database.OpenConnection();

            MapToInsertUser();

            foreach (UserAnswer userAnswer in _userAnswers)
                if (userAnswer.SelectedAnswer != 0)
                    MapToInsertUserAnswer(userAnswer);

            Database.CloseConnection();

            using (var resultForm = new ResultForm(_userAnswers))
            {
                this.Hide();
                resultForm.ShowDialog();
                this.Close();
            }
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (_questionsTable.Rows.Count == 0)
                    throw new Exception("Вопросов нет)");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            DataRow[] rows = _questionsTable.Select("", "question_order ASC");
            DataTable table = _questionsTable.Clone();

            foreach (DataRow row in rows)
                table.ImportRow(row);

            _questionsTable = table;
            QuestionNum = 0;

            for (int i = 0; i < _questionsTable.Rows.Count; i++)
            {
                _userAnswers.Add(new UserAnswer
                {
                    UserId = User.Id,
                    QuestionId = Convert.ToInt32(_questionsTable.Rows[i].ItemArray[0])
                });
            }

            lTime.Text = $"Время: {_time.Minutes}:00";
            timerTest.Start();
        }

        private void timerTest_Tick(object sender, EventArgs e)
        {
            _time -= TimeSpan.FromSeconds(1);
            _timeSpent++;

            if ($"{_time.Minutes}:{_time.Seconds}" == "0:0")
            {
                MessageBox.Show("Время кончилось", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Exit();
            }

            lTime.Text = $"Время: {_time.Minutes}:{_time.Seconds}";
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            QuestionNum--;
            bNext.Text = "Далее -->";
        }

        private void bNext_Click(object sender, EventArgs e)
        {
            if (QuestionNum == _questionsTable.Rows.Count - 2)
                bNext.Text = "Завершить";

            int selectedAnswer;
            bool is_correct = false;
            if (rbOption1.Checked)
                selectedAnswer = 1;
            else if (rbOption2.Checked)
                selectedAnswer = 2;
            else if (rbOption3.Checked)
                selectedAnswer = 3;
            else
                selectedAnswer = 4;

            if (selectedAnswer == Convert.ToInt32(_questionsTable.Rows[QuestionNum].ItemArray[6]))
            {
                is_correct = true;
                User.Score++;
            }

            _userAnswers[QuestionNum].SelectedAnswer = selectedAnswer;
            _userAnswers[QuestionNum].IsCorrect = is_correct;
            _userAnswers[QuestionNum].AnswerTime = _time;

            if (QuestionNum == _questionsTable.Rows.Count - 1)
                Exit();

            QuestionNum++;
        }
    }
}
