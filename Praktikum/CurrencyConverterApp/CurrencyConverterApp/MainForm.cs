using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace CurrencyConverterApp
{
    public partial class MainForm : Form
    {
        // Курсы валют к RUB
        private Dictionary<string, decimal> rates = new Dictionary<string, decimal>()
        {
            { "Российский рубль", 1m },
            { "Доллар США", 77.70m },
            { "Евро", 90.34m },
            { "Китайский юань", 10.96m },
            { "Южнокорейская вона", 0.0670m }
        };

        public MainForm()
        {
            InitializeComponent();
            InitializeCurrencies();
            InitializeEvents();
            UpdateResult();
        }

        private void InitializeCurrencies()
        {
            comboFrom.Items.AddRange(new object[]
            {
                "Российский рубль",
                "Доллар США",
                "Евро",
                "Китайский юань",
                "Южнокорейская вона"
            });

            comboTo.Items.AddRange(new object[]
            {
                "Российский рубль",
                "Доллар США",
                "Евро",
                "Китайский юань",
                "Южнокорейская вона"
            });

            comboFrom.SelectedItem = "Российский рубль";
            comboTo.SelectedItem = "Южнокорейская вона";
        }

        private void InitializeEvents()
        {
            comboFrom.SelectedIndexChanged += (s, e) => UpdateResult();
            comboTo.SelectedIndexChanged += (s, e) => UpdateResult();
            textAmount.TextChanged += (s, e) => UpdateResult();
            buttonSwap.Click += ButtonSwap_Click;
            buttonUpdateRates.Click += ButtonUpdateRates_Click;
        }

        private void UpdateResult()
        {
            if (comboFrom.SelectedItem == null || comboTo.SelectedItem == null)
                return;

            if (!decimal.TryParse(textAmount.Text.Replace(',', '.'),
                NumberStyles.Any,
                CultureInfo.InvariantCulture,
                out decimal amount))
            {
                textResult.Text = string.Empty;
                return;
            }

            string from = comboFrom.SelectedItem.ToString();
            string to = comboTo.SelectedItem.ToString();

            decimal rubAmount = amount * rates[from];
            decimal result = rubAmount / rates[to];

            textResult.Text = result.ToString("N2", new CultureInfo("ru-RU"));
        }

        private void ButtonSwap_Click(object sender, EventArgs e)
        {
            var temp = comboFrom.SelectedItem;
            comboFrom.SelectedItem = comboTo.SelectedItem;
            comboTo.SelectedItem = temp;
        }

        private void ButtonUpdateRates_Click(object sender, EventArgs e)
        {
            // Заглушка обновления курсов (можно заменить API)
            rates["Доллар США"] = 77.70m;
            rates["Евро"] = 90.34m;
            rates["Китайский юань"] = 10.96m;
            rates["Южнокорейская вона"] = 0.0670m;

            labelRates.Text =
                "1 USD = 77,70 RUB\n" +
                "1 EUR = 90,34 RUB\n" +
                "1 CNY = 10,96 RUB\n" +
                "1 KRW = 0,0670 RUB";

            UpdateResult();
        }
    }
}
