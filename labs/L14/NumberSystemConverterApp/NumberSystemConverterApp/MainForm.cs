using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace NumberSystemConverterApp
{
    public partial class MainForm : Form
    {
        private readonly string _connectionString = "Server=IDEAPADS145\\SQLEXPRESS;Database=number_system_converter;Trusted_Connection=True;";
        private int _inputBase;
        private int _outputBase;
        private string[] _conversion;

        public MainForm()
        {
            InitializeComponent();
        }

        // ================= ВСПОМОГАТЕЛЬНЫЕ МЕТОДЫ КОНВЕРТАЦИИ =================
        private string GetValidChars(int baseVal)
        {
            if (baseVal <= 10)
                return "0123456789".Substring(0, baseVal);
            else if (baseVal == 16)
                return "0123456789ABCDEF";
            else
                throw new NotSupportedException($"Основание {baseVal} не поддерживается");
        }

        private bool IsValidNumber(string number, int baseVal)
        {
            string upperNumber = number.ToUpper();
            string validChars = GetValidChars(baseVal);
            foreach (char c in upperNumber)
                if (!validChars.Contains(c))
                    return false;
            return true;
        }

        private int ParseToDecimal(string number, int baseVal)
        {
            string upperNumber = number.ToUpper();
            int decimalValue = 0;
            for (int i = 0; i < upperNumber.Length; i++)
            {
                char c = upperNumber[i];
                int digitValue;
                if (c >= '0' && c <= '9')
                    digitValue = c - '0';
                else if (c >= 'A' && c <= 'F')
                    digitValue = 10 + (c - 'A');
                else
                    throw new FormatException($"Недопустимый символ '{c}' для системы с основанием {baseVal}");

                if (digitValue >= baseVal)
                    throw new FormatException($"Цифра '{c}' недопустима для системы с основанием {baseVal}");

                decimalValue = decimalValue * baseVal + digitValue;
            }
            return decimalValue;
        }

        private string ConvertFromDecimal(int decimalValue, int baseTo)
        {
            if (decimalValue == 0) return "0";
            string result = "";
            while (decimalValue > 0)
            {
                int remainder = decimalValue % baseTo;
                char digit;
                if (remainder < 10)
                    digit = (char)('0' + remainder);
                else
                    digit = (char)('A' + remainder - 10);
                result = digit + result;
                decimalValue /= baseTo;
            }
            return result;
        }
        // ================================================================

        private void RefreshHistoryDataGridView()
        {
            historyDataGridView.Rows.Clear();
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    using (var cmd = new SqlCommand("SELECT * FROM conversion_history", conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var bases = new string[2];
                                for (int i = 0; i < bases.Length; i++)
                                    switch (reader.GetInt32((i + 1) * 2))
                                    {
                                        case 2: bases[i] = "Двоичная (2)"; break;
                                        case 8: bases[i] = "Восьмеричная (8)"; break;
                                        case 10: bases[i] = "Десятичная (10)"; break;
                                        case 16: bases[i] = "Шестнадцатеричная (16)"; break;
                                    }
                                historyDataGridView.Rows.Add(
                                    reader.GetString(1),
                                    bases[0],
                                    reader.GetString(3),
                                    bases[1],
                                    reader.GetDateTime(5));
                            }
                        }
                    }
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Не удалось подключиться к базе данных", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var range = new string[] { "Двоичная (2)", "Восьмеричная (8)", "Десятичная (10)", "Шестнадцатеричная (16)" };
            inputBaseComboBox.Items.AddRange(range);
            inputBaseComboBox.Text = inputBaseComboBox.Items[2].ToString(); // десятичная
            outputBaseComboBox.Items.AddRange(range);
            outputBaseComboBox.Text = outputBaseComboBox.Items[0].ToString(); // двоичная

            // Принудительно вызываем события, чтобы проинициализировать _inputBase и _outputBase
            inputBaseComboBox_SelectedIndexChanged(inputBaseComboBox, EventArgs.Empty);
            outputBaseComboBox_SelectedIndexChanged(outputBaseComboBox, EventArgs.Empty);

            RefreshHistoryDataGridView();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            try
            {
                string inputNumber = inputNumberTextBox.Text.Trim();
                if (string.IsNullOrEmpty(inputNumber))
                    throw new Exception("Введите число для конвертации");

                // Проверка валидности символов для исходной системы
                if (!IsValidNumber(inputNumber, _inputBase))
                    throw new Exception($"Введенное число содержит символы, недопустимые для системы с основанием {_inputBase}");

                // Перевод в десятичное целое
                int decimalValue = ParseToDecimal(inputNumber, _inputBase);

                // Перевод из десятичного в целевую систему
                string resultNumber = ConvertFromDecimal(decimalValue, _outputBase);

                // Вывод результата
                outputNumberTextBox.Text = resultNumber;

                // Подготовка данных для сохранения в БД
                _conversion = new string[4];
                _conversion[0] = inputNumber;
                _conversion[1] = _inputBase.ToString();
                _conversion[2] = resultNumber;
                _conversion[3] = _outputBase.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка конвертации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                outputNumberTextBox.Clear();
                _conversion = null;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (_conversion != null)
            {
                try
                {
                    string query = "INSERT INTO conversion_history (input_number, input_base, output_number, output_base, conversion_datetime) " +
                    "VALUES (@input_number, @input_base, @output_number, @output_base, @conversion_datetime)";

                    using (var conn = new SqlConnection(_connectionString))
                    {
                        conn.Open();
                        using (var cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@input_number", _conversion[0]);
                            cmd.Parameters.AddWithValue("@input_base", _conversion[1]);
                            cmd.Parameters.AddWithValue("@output_number", _conversion[2]);
                            cmd.Parameters.AddWithValue("@output_base", _conversion[3]);
                            cmd.Parameters.AddWithValue("@conversion_datetime", DateTime.Now);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Результат сохранён в историю", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException)
                {
                    MessageBox.Show("Не удалось подключиться к базе данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                RefreshHistoryDataGridView();
            }
            else
            {
                MessageBox.Show("Нет данных для сохранения. Сначала выполните конвертацию.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void inputBaseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (inputBaseComboBox.SelectedIndex)
            {
                case 0: _inputBase = 2; break;
                case 1: _inputBase = 8; break;
                case 2: _inputBase = 10; break;
                case 3: _inputBase = 16; break;
            }
        }

        private void outputBaseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (outputBaseComboBox.SelectedIndex)
            {
                case 0: _outputBase = 2; break;
                case 1: _outputBase = 8; break;
                case 2: _outputBase = 10; break;
                case 3: _outputBase = 16; break;
            }
        }
    }
}