using System.Drawing;
using System.Windows.Forms;

namespace PublishingApp
{
    public partial class ReceiptForm : Form
    {
        private Models.Order order = null;
        private Models.Book book = null;
        private Models.Customer customer = null;
        private Models.Office office = null;
        private Bitmap memoryImage = null;

        public ReceiptForm(Models.Order order, Models.Book book, Models.Customer customer, Models.Office office)
        {
            InitializeComponent();

            this.order = order;
            this.book = book;
            this.customer = customer;
            this.office = office;
        }

        private void ReceiptForm_Load(object sender, System.EventArgs e)
        {
            labelOrderNumber.Text += order.Id;
            labelDate.Text += order.OrderDate;
            labelBook.Text += book.Name;
            labelCustomer.Text += customer.Name;
            labelOffice.Text += office.Name;
            labelAmount.Text = $"{order.Price} руб.";
        }

        private void buttonPrint_Click(object sender, System.EventArgs e)
        {
            printDialog1.ShowDialog();
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);

            printDocument1.Print();
        }

        private void buttonClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void printDocument1_PrintPage(
           System.Object sender,
           System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }
    }
}
