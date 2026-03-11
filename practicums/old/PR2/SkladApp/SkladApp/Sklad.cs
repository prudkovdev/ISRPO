using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace SkladApp
{
    enum RowState
    {
        Modified,
        ModifiedNew,
        Deleted
    }

    public partial class Sklad : Form
    {
        DataBase dataBase = new DataBase();
        static string filePath;
        int index = 0;
        Boolean isLoad = false;

        public Sklad()
        {
            InitializeComponent();
        }

        private new void Update()
        {
            string query = String.Empty;

            dataBase.OpenConnection();

            for (int i = 0; i < dataGridViewProducts.Rows.Count; i++)
            {
                var rowState = (RowState)dataGridViewProducts.Rows[i].Cells[5].Value;
                var id = Convert.ToInt32(dataGridViewProducts.Rows[i].Cells[0].Value);

                switch (rowState)
                {
                    case RowState.Deleted:
                        query = $"delete from products where id = {id}";
                        break;

                    case RowState.Modified:
                        var name = dataGridViewProducts.Rows[i].Cells[1].Value.ToString();

                        query = $"update products set name = '{name}' where id = {id}";
                        break;
                }
            }

            SqlCommand command = new SqlCommand(query, dataBase.GetConnection());
            command.ExecuteNonQuery();

            dataBase.CloseConnection();
        }

        private void CreateColumns()
        {
            dataGridViewProducts.Columns.Add("id", "id");
            dataGridViewProducts.Columns.Add("name", "Название");
            dataGridViewProducts.Columns.Add("stillage", "Стеллаж");
            dataGridViewProducts.Columns.Add("cell", "Ячейка");
            dataGridViewProducts.Columns.Add("quantity", "Количество");
            dataGridViewProducts.Columns.Add("IsNew", String.Empty);
        }

        private void ReadSingleRow(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), record.GetInt32(3), record.GetInt32(4), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string query = $"select * from products";

            SqlCommand command = new SqlCommand(query, dataBase.GetConnection());

            dataBase.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgv, reader);
            }
            reader.Close();
        }
        
        private void RefreshFields()
        {
            index = comboBoxProductName.SelectedIndex;
            dataGridViewProducts.ClearSelection();
            dataGridViewProducts.Rows[index].Selected = true;

            DataGridViewRow row = dataGridViewProducts.Rows[index];

            numericUpDownStellazhNum.Value = Convert.ToInt32(row.Cells[2].Value);
            numericUpDownCellNum.Value = Convert.ToInt32(row.Cells[3].Value);
            numericUpDownQuantity.Value = Convert.ToInt32(row.Cells[4].Value);
        }

        private void RefreshComboBoxProductName()
        {
            comboBoxProductName.DataSource = null;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string query = "select name from products";

            SqlCommand command = new SqlCommand(query, dataBase.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            comboBoxProductName.DataSource = table;
            comboBoxProductName.DisplayMember = "name";
            comboBoxProductName.SelectedIndex = 0;
        }

        private void Sklad_Load(object sender, EventArgs e)
        {
            RefreshComboBoxProductName();
            CreateColumns();
            RefreshDataGrid(dataGridViewProducts);
            RefreshFields();
            isLoad = true;
        }

        private void comboBoxProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoad == true && comboBoxProductName.SelectedIndex != -1)
            {
                RefreshFields();
            }
        }

        private void buttonAddToTable_Click(object sender, EventArgs e)
        {
            var name = comboBoxProductName.Text;
            var stillage = numericUpDownStellazhNum.Value;
            var cell = numericUpDownCellNum.Value;
            var quantity = numericUpDownQuantity.Value;

            string query = $"insert into products (name, stillage, cell, quantity) values ('{name}', '{stillage}', '{cell}', '{quantity}')";

            SqlCommand command = new SqlCommand(query, dataBase.GetConnection());
            command.ExecuteNonQuery();

            MessageBox.Show("Запись создана успешно.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

            RefreshComboBoxProductName();
            RefreshDataGrid(dataGridViewProducts);
            RefreshFields();
        }

        private void SearchByName(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string query = $"select * from products where name like '%" + textBoxNameForSearch.Text + "%'";

            SqlCommand command = new SqlCommand(query, dataBase.GetConnection());

            dataBase.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgv, reader);
            }
            reader.Close();
        }

        private void SearchByCoords(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string query = String.Empty;

            if (numericUpDownStellazh.Value == 0 && numericUpDownCell.Value == 0)
            {
                query = $"select * from products";
            } else
            {
                query = $"select * from products where stillage like '%" + numericUpDownStellazh.Value + "%' and cell like '%" + numericUpDownCell.Value + "%'";
            }
            

            SqlCommand command = new SqlCommand(query, dataBase.GetConnection());

            dataBase.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgv, reader);
            }
            reader.Close();
        }

        private void buttonSearchByName_Click(object sender, EventArgs e)
        {
            SearchByName(dataGridViewProducts);
        }

        private void DeleteRow()
        {
            dataGridViewProducts.Rows[index].Visible = false;

            dataGridViewProducts.Rows[index].Cells[5].Value = RowState.Deleted;
        }

        private void buttonDeleteSelected_Click(object sender, EventArgs e)
        {
            DeleteRow();
            Update();

            RefreshComboBoxProductName();
            RefreshDataGrid(dataGridViewProducts);
            RefreshFields();
        }

        private void ChangeName()
        {
            DataGridViewRow row = dataGridViewProducts.Rows[index];

            var name = textBoxNewName.Text;

            row.Cells[1].Value = name;
            row.Cells[5].Value = RowState.Modified;
        }

        private void buttonAddNewName_Click(object sender, EventArgs e)
        {
            ChangeName();
            Update();

            RefreshComboBoxProductName();
            RefreshDataGrid(dataGridViewProducts);
            RefreshFields();
        }

        private void buttonSearchByCoords_Click(object sender, EventArgs e)
        {
            SearchByCoords(dataGridViewProducts);
        }

        private void SaveDataGridViewToCsv(DataGridView dgv, string filePath)
        {
            StringBuilder sb = new StringBuilder();

            // Заголовки
            string[] headers = dgv.Columns.Cast<DataGridViewColumn>()
                .Select(col => col.HeaderText)
                .ToArray();
            sb.AppendLine(string.Join(";", headers));

            // Строки
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (!row.IsNewRow)
                {
                    string[] cells = row.Cells.Cast<DataGridViewCell>()
                        .Select(c => c.Value?.ToString() ?? "")
                        .ToArray();
                    sb.AppendLine(string.Join(";", cells));
                }
            }

            File.WriteAllText(filePath, sb.ToString(), Encoding.UTF8);
        }

        private void LoadCsvToDataGridView(DataGridView dgv, string filePath)
        {
            // Проверяем, существует ли файл
            if (!File.Exists(filePath))
            {
                MessageBox.Show($"Файл \"{filePath}\" не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Очищаем текущие строки
            dgv.Rows.Clear();

            var lines = File.ReadAllLines(filePath, Encoding.UTF8);
            if (lines.Length <= 1)
            {
                MessageBox.Show("Файл пустой или не содержит данных.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Пропускаем заголовок (первая строка)
            for (int i = 1; i < lines.Length; i++)
            {
                string[] values = lines[i].Split(';');

                // Проверяем, чтобы количество колонок совпадало
                if (values.Length == dgv.Columns.Count)
                {
                    dgv.Rows.Add(values);
                }
                else
                {
                    MessageBox.Show($"Ошибка загрузки строки {i}: количество столбцов не совпадает.",
                                    "Ошибка данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void SaveDataGridViewToDatabase(DataGridView dgv)
        {
            string deleteQuery = "delete from products";

            SqlCommand command = new SqlCommand(deleteQuery, dataBase.GetConnection());
            command.ExecuteNonQuery();

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (!row.IsNewRow)
                {
                    string insertQuery = @"INSERT INTO Products (name, stillage, cell, quantity)
                                 VALUES (@name, @stillage, @cell, @quantity)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, dataBase.GetConnection()))
                    {
                        cmd.Parameters.AddWithValue("@name", row.Cells["name"].Value ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@stillage", row.Cells["stillage"].Value ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@cell", row.Cells["cell"].Value ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@quantity", row.Cells["quantity"].Value ?? DBNull.Value);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private void buttonSaveAs_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Введите название файла", "Сохранить как", "sklad.csv");
            
            if (input == string.Empty)
            {
                MessageBox.Show($"Таблица была не сохранена", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SaveDataGridViewToCsv(dataGridViewProducts, input);
                MessageBox.Show($"Таблица была успешно сохранена в {input}", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Введите название файла", "Сохранить как", "sklad.csv");

            if (input == string.Empty)
            {
                MessageBox.Show($"Данные не были загружены из файла", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                LoadCsvToDataGridView(dataGridViewProducts, input);
                SaveDataGridViewToDatabase(dataGridViewProducts);
                MessageBox.Show("Данные успешно загружены из файла и внесены в БД.", "Загрузка завершена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshComboBoxProductName();
                RefreshFields();
            }
        }
    }
}
