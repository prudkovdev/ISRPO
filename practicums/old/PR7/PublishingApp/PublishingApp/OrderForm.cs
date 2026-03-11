using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PublishingApp
{
    public partial class OrderForm : Form
    {
        private DatabaseHelper databaseHelper = new DatabaseHelper();
        private Models.Book book = null;
        private decimal price_rate = 340;

        public OrderForm(int bookIndex)
        {
            InitializeComponent();

            List<Models.Book> books = databaseHelper.GetBooks();

            book = books[bookIndex];
        }

        private void OutputTotal()
        {
            labelTotal.Text = $"Итого: {price_rate * numericUpDownQuantity.Value} руб.";
        }

        private void OrderForm_Load(object sender, System.EventArgs e)
        {
            labelBookName.Text += book.Name;
            labelAuthor.Text += book.AuthorName;

            List<Models.Office> offices = databaseHelper.GetOffices();
            
            comboBoxOffice.DataSource = offices;
            comboBoxOffice.DisplayMember = "Name";
            comboBoxOffice.SelectedIndex = 0;

            OutputTotal();
        }

        private void numericUpDownQuantity_ValueChanged(object sender, System.EventArgs e)
        {
            OutputTotal();
        }

        private void numericUpDownQuantity_KeyUp(object sender, KeyEventArgs e)
        {
            OutputTotal();
        }

        private void buttonConfirm_Click(object sender, System.EventArgs e)
        {
            if (textBoxCustomerName.Text != string.Empty && textBoxCustomerAddress.Text != string.Empty && textBoxCustomerPhone.Text != string.Empty)
            {
                Models.Customer customer = new Models.Customer();
                Models.Order order = new Models.Order();

                customer.Name = textBoxCustomerName.Text;
                customer.Address = textBoxCustomerAddress.Text;
                customer.Phone = textBoxCustomerPhone.Text;

                order.BookId = book.Id;
                order.OfficeId = databaseHelper.GetOffices()[comboBoxOffice.SelectedIndex].Id;
                order.CustomerId = databaseHelper.CreateCustomer(customer);
                order.OrderDate = DateTime.Now;

                DateTime temp = order.OrderDate;
                temp.AddDays(14);

                order.CompletionDate = temp.ToShortDateString();
                order.Price = price_rate * numericUpDownQuantity.Value;

                int orderId = databaseHelper.CreateOrder(order);

                order.Id = orderId;

                MessageBox.Show($"Заказ №{orderId} успешно оформлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ReceiptForm receiptForm = new ReceiptForm(order, book, customer, databaseHelper.GetOffices()[comboBoxOffice.SelectedIndex]);
                receiptForm.ShowDialog();

                Close();
            }
            else
            {
                MessageBox.Show("Поля должны быть все заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
