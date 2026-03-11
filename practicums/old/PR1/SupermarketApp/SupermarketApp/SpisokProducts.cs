using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketApp
{
    public partial class SpisokProducts : Form
    {
        DataBase dataBase = new DataBase();

        public SpisokProducts()
        {
            InitializeComponent();
        }

        private void SpisokProducts_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string query = "select name, price from products";

            SqlCommand command = new SqlCommand(query, dataBase.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            table.Columns.Add("display", typeof(string), "name + ' - ' + CONVERT(price, 'System.String') + ' ₽'");

            comboBoxProductsList.DataSource = table;
            comboBoxProductsList.DisplayMember = "display";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            listAddProducts.Items.Add(comboBoxProductsList.Text);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listAddProducts.Items.Clear();
            textBoxTotal.Clear();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            decimal total = 0;

            foreach (var item in listAddProducts.Items)
            {
                // Извлекаем число из строки вида "Хлеб - 50 ₽"
                string text = item.ToString();
                string[] parts = text.Split('-');
                if (parts.Length > 1)
                {
                    string pricePart = parts[1].Replace("₽", "").Trim();
                    if (decimal.TryParse(pricePart, out decimal price))
                    {
                        total += price;
                    }
                }
            }

            textBoxTotal.Text = total.ToString("0.00 ₽");
        }
    }
}
