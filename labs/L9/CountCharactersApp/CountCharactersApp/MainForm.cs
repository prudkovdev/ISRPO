using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CountCharactersApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void bOpen_Click(object sender, System.EventArgs e)
        {
            try
            {
                Debug.WriteLine("Начало открытия файла");
                using (var ofDialog = new OpenFileDialog())
                {
                    ofDialog.Filter = "Текстовые файлы (*.txt)|*.txt";
                    if (ofDialog.ShowDialog() == DialogResult.OK)
                    {
                        string content = File.ReadAllText(ofDialog.FileName, Encoding.UTF8);
                        Debug.WriteLine($"Выбран файл: {ofDialog.FileName}");
                        Debug.WriteLine($"Прочитано символов: {content.Length}");

                        tbPath.Text = ofDialog.FileName;
                        tbContent.Text = content;
                        tbCount.Text = content.Length.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при чтении файла: {ex.Message}",
                              "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bCount_Click(object sender, System.EventArgs e)
        {
            tbCount.Text = tbContent.Text.Length.ToString();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbPath.Text))
                MessageBox.Show("Сначала выберите файл для сохранения!",
                       "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    string filePath = tbPath.Text;
                    string content = tbContent.Text;
                    int count = tbContent.Text.Length;

                    File.WriteAllText(filePath, content, Encoding.UTF8);
                    DatabaseHelper.SaveToDatabase(filePath, content, count, "WRITE");

                    MessageBox.Show("Файл успешно сохранён!", "Успех",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}",
                           "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            tbContent.Clear();
            tbCount.Clear();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы действительно хотите выйти?", 
                "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
                this.Close();
        }
    }
}
