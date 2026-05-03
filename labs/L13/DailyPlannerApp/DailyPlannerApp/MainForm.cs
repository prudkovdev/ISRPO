using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DailyPlannerApp
{
    public partial class MainForm : Form
    {
        private List<Note> _notes;
        private DateTime _selectedDateTime;
        private Note _selectedNote;

        public MainForm()
        {
            InitializeComponent();
            _notes = new List<Note>();
            _selectedDateTime = DateTime.Now;
        }

        private void UpdateEmptyMessage()
        {
            if (lvNotes.Items.Count == 0)
            {
                // Добавляем пустой элемент с текстом
                ListViewItem emptyItem = new ListViewItem("Нет заметок на этот день");
                emptyItem.Tag = "empty_placeholder"; // метка для опознания
                lvNotes.Items.Add(emptyItem);
            }
            else
            {
                // Удаляем элемент-заглушку, если он есть
                var emptyItem = lvNotes.Items.Cast<ListViewItem>()
                    .FirstOrDefault(i => i.Tag?.ToString() == "empty_placeholder");
                if (emptyItem != null)
                    lvNotes.Items.Remove(emptyItem);
            }
        }

        private void Clear()
        {
            tbText.Clear();
            dtpTime.Value = DateTime.Now;
            _selectedNote = null;
        }

        private void Show(DateTime dateTime)
        {
            lvNotes.Items.Clear();
            Clear();
            foreach (var note in _notes)
                if (note.DateTime.Date == dateTime.Date)
                {
                    var item = new ListViewItem();
                    item.Text = $"{note.DateTime.TimeOfDay} {note.Text}";
                    if (item.Text.Length > 60)
                    {
                        item.Text = item.Text.Remove(60);
                        item.Text += "...";
                    }
                    item.ToolTipText = note.Text;
                    item.Tag = note;
                    lvNotes.Items.Add(item);
                }
            UpdateEmptyMessage();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try { _notes = DatabaseHelper.GetNotes(); }
            catch
            {
                MessageBox.Show("Не удалось подключиться к БД", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Show(_selectedDateTime);
        }

        private void mCal_DateSelected(object sender, DateRangeEventArgs e)
        {
            _selectedDateTime = e.Start;
            Show(_selectedDateTime);
        }

        private void lvNotes_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.Item.Tag.ToString() != "empty_placeholder")
            {
                var note = (Note)e.Item.Tag;
                tbText.Text = note.Text;
                dtpTime.Value = note.DateTime;
                _selectedNote = note;
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            tbText.Text = tbText.Text.Trim();
            if (tbText.Text != string.Empty)
            {
                try
                {
                    DatabaseHelper.InsertNote(new Note
                    {
                        DateTime = Convert.ToDateTime($"{mCal.SelectionStart.ToShortDateString()} {dtpTime.Text}"),
                        Text = tbText.Text,
                        CreatedAt = DateTime.Now
                    });
                    MessageBox.Show("Заметка успешно добавлена!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _notes = DatabaseHelper.GetNotes();
                    Show(_selectedDateTime);
                }
                catch
                {
                    MessageBox.Show("Не удалось подключиться к БД", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Введите текст заметки!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            if (_selectedNote != null)
            {
                if (tbText.Text != string.Empty)
                {
                    try
                    {
                        _selectedNote.DateTime = Convert.ToDateTime($"{mCal.SelectionStart.ToShortDateString()} {dtpTime.Text}");
                        _selectedNote.Text = tbText.Text;
                        DatabaseHelper.UpdateNote(_selectedNote);
                        MessageBox.Show("Заметка успешно обновлена!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _notes = DatabaseHelper.GetNotes();
                        Show(_selectedDateTime);
                    }
                    catch
                    {
                        MessageBox.Show("Не удалось подключиться к БД", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("Введите текст заметки!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Выберите заметку для редактирования!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            if (_selectedNote != null)
            {
                try
                {
                    DatabaseHelper.DeleteNote(_selectedNote.Id);
                    MessageBox.Show("Заметка успешно удалена!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _notes = DatabaseHelper.GetNotes();
                    Show(_selectedDateTime);
                }
                catch
                {
                    MessageBox.Show("Не удалось подключиться к БД", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Выберите заметку для удаления!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
