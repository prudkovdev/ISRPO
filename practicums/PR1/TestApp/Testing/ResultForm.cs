using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Testing
{
    public partial class ResultForm : Form
    {
        private List<UserAnswer> _userAnswers;

        public ResultForm(List<UserAnswer> userAnswers)
        {
            InitializeComponent();
            _userAnswers = userAnswers;
        }

        private void ResultForm_Load(object sender, System.EventArgs e)
        {
            lCorrectAnswers.Text = $"Правильных ответов: {User.Score} из {_userAnswers.Count}";

            double a = Convert.ToDouble(_userAnswers.Count) / User.Score;
            double percent = 100.00 / a;
            lResult.Text = $"Результат {Convert.ToInt32(percent)}%";

            //string query = "SELECT " +
            //    "q.question_order AS [Номер вопроса], " +
            //    "q.question_text AS [Вопрос], " +
            //    "CASE ua.selected_answer " +
            //    "WHEN 1 THEN q.option1 " +
            //    "WHEN 2 THEN q.option2 " +
            //    "WHEN 3 THEN q.option3 " +
            //    "WHEN 4 THEN q.option4 " +
            //    "ELSE NULL " +
            //    "END AS [Выбранный ответ], " +
            //    "CASE q.correct_answer " +
            //    "WHEN 1 THEN q.option1 " +
            //    "WHEN 2 THEN q.option2 " +
            //    "WHEN 3 THEN q.option3 " +
            //    "WHEN 4 THEN q.option4 " +
            //    "ELSE NULL " +
            //    "END AS [Правильный ответ], " +
            //    "CASE ua.is_correct WHEN 1 THEN 'Верно' ELSE 'Неверно' END AS [Верно/Неверно], " +
            //    "FORMAT(ua.answer_time, N'mm:ss') AS [Время] " +
            //    "FROM user_answers ua " +
            //    "INNER JOIN questions q ON ua.question_id = q.id " +
            //    "WHERE ua.user_id = @user_id   -- параметр для конкретного пользователя " +
            //    "ORDER BY q.question_order;";

            string query = "SELECT " +
                "first_name + ' ' + last_name AS [Пользователь], " +
                "test_date AS [Дата теста], " +
                "score AS [Баллы], " +
                "time_spent AS [Время (сек)] " +
                "FROM users " +
                "WHERE id = @id";

            Database.OpenConnection();
            using (var cmd = new SqlCommand(query, Database.Connection))
            {
                cmd.Parameters.AddWithValue("@id", User.Id);

                using (var adapter = new SqlDataAdapter())
                {
                    using (var table = new DataTable())
                    {
                        adapter.SelectCommand = cmd;
                        adapter.Fill(table);

                        dgvResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dgvResult.DataSource = table;
                    }
                }
            }
        }

        private void bExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void bAgain_Click(object sender, System.EventArgs e)
        {
            var result = MessageBox.Show("Вы действительно хотите начать тест заново? Текущий результат будет сохранён", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                User.TestDate = DateTime.Now;
                User.Score = 0;
                User.IsCompleted = false;

                using (var form = new TestForm())
                {
                    this.Hide();
                    form.ShowDialog();
                    this.Close();
                }
            }
        }
    }
}
