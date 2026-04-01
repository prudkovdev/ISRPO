using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FieldOfMiraclesApp
{
    public partial class MainForm : Form
    {
        private List<string> _words;
        private string _word;
        private Stack<Button> clickedButtons = new Stack<Button>();

        public MainForm()
        {
            InitializeComponent();
            _words = DatabaseHelper.GetWords();
        }

        private void NewGame(string word)
        {
            tbWord.Clear();
            if (string.IsNullOrEmpty(word))
                return;

            // Очищаем панель и стек нажатых кнопок
            pWords.Controls.Clear();
            clickedButtons.Clear();

            // Приводим слово к верхнему регистру
            word = word.ToUpper();

            // Преобразуем строку в список символов и перемешиваем
            List<char> letters = word.ToList();
            Random rng = new Random();
            for (int i = letters.Count - 1; i > 0; i--)
            {
                int j = rng.Next(i + 1);
                (letters[i], letters[j]) = (letters[j], letters[i]);
            }

            const int buttonSize = 32;
            const int gap = 16;

            int letterCount = letters.Count;
            int totalWidth = letterCount * buttonSize + (letterCount - 1) * gap;
            int startX = (pWords.Width - totalWidth) / 2;
            if (startX < 0) startX = 0;
            int startY = (pWords.Height - buttonSize) / 2;
            if (startY < 0) startY = 0;

            // Создаём кнопки в перемешанном порядке
            for (int i = 0; i < letterCount; i++)
            {
                Button btn = new Button
                {
                    Text = letters[i].ToString(),
                    Size = new Size(buttonSize, buttonSize),
                    Location = new Point(startX + i * (buttonSize + gap), startY),
                    FlatStyle = FlatStyle.Flat,
                    Enabled = true
                };

                btn.Click += (sender, e) =>
                {
                    Button clicked = sender as Button;
                    if (clicked != null && clicked.Enabled)
                    {
                        // Добавляем букву в текстовое поле
                        tbWord.Text += clicked.Text;
                        // Отключаем кнопку
                        clicked.Enabled = false;
                        // Запоминаем кнопку в стеке
                        clickedButtons.Push(clicked);
                    }
                };

                pWords.Controls.Add(btn);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _word = _words[new Random().Next(0, _words.Count)];
            NewGame(_word);
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            if (tbWord.Text.Length > 0 && clickedButtons.Count > 0)
            {
                // Удаляем последний символ из tbWord
                tbWord.Text = tbWord.Text.Remove(tbWord.Text.Length - 1);
                // Восстанавливаем последнюю отключённую кнопку
                Button lastButton = clickedButtons.Pop();
                lastButton.Enabled = true;
            }
        }

        private void bNewGame_Click(object sender, EventArgs e)
        {   
            _word = _words[new Random().Next(0, _words.Count)];
            NewGame(_word);
        }

        private void bCheck_Click(object sender, EventArgs e)
        {
            if (tbWord.Text == _word.ToUpper())
                MessageBox.Show("Слово угадано верно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Слово угадано неверно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
