using System.Collections.Generic;
using System.Windows.Forms;

namespace PublishingApp
{
    public partial class MainForm : Form
    {
        private DatabaseHelper databaseHelper = new DatabaseHelper();
        private int _selectedDGVBooksRow;

        private int DGVBooksSelectedRow
        {
            get { return _selectedDGVBooksRow; }
            set
            {
                _selectedDGVBooksRow = value;

                dataGridViewBooks.ClearSelection();
                dataGridViewBooks.Rows[_selectedDGVBooksRow].Selected = true;
                FillBookFields();
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void DGVBooksInit(List<Models.Book> books)
        {
            dataGridViewBooks.DataSource = books;

            dataGridViewBooks.Columns[0].Visible = false;
            dataGridViewBooks.Columns[2].Visible = false;

            dataGridViewBooks.Columns[1].HeaderText = "Название";
            dataGridViewBooks.Columns[3].HeaderText = "Автор";
            dataGridViewBooks.Columns[4].HeaderText = "Год издания";
            dataGridViewBooks.Columns[5].HeaderText = "Кол-во страниц";
            dataGridViewBooks.Columns[6].HeaderText = "Тираж";
        }

        private void FillBookFields()
        {
            DataGridViewRow row = dataGridViewBooks.Rows[DGVBooksSelectedRow];

            textBoxBookName.Text = row.Cells[1].Value.ToString();
            textBoxAuthor.Text = row.Cells[3].Value.ToString();
            textBoxReleaseYear.Text = row.Cells[4].Value.ToString();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            List<Models.Book> books = databaseHelper.GetBooks();

            DGVBooksInit(books);
            DGVBooksSelectedRow = 0;
        }

        private void dataGridViewBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DGVBooksSelectedRow = e.RowIndex;
            }
        }

        private void buttonOrder_Click(object sender, System.EventArgs e)
        {
            OrderForm orderForm = new OrderForm(DGVBooksSelectedRow);
            orderForm.ShowDialog();
        }

        private void buttonExit_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
