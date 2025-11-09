using System;
using System.Drawing;
using System.Windows.Forms;

namespace TicketApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            int TicketNum = random.Next(100000, 999999);
            char[] parts = TicketNum.ToString().ToCharArray();
            int firstPart = Convert.ToInt32(parts[0]) + Convert.ToInt32(parts[1]) + Convert.ToInt32(parts[2]);
            int secondPart = Convert.ToInt32(parts[3]) + Convert.ToInt32(parts[4]) + Convert.ToInt32(parts[5]);

            if (firstPart == secondPart)
            {
                label2.ForeColor = Color.Green;
                label3.ForeColor = Color.Green;

                label2.Text = TicketNum.ToString();
                label3.Text = "Счастливый билет";
            } else
            {
                label2.ForeColor = Color.Red;
                label3.ForeColor = Color.Red;

                label2.Text = TicketNum.ToString();
                label3.Text = "Обычный билет";
            }
        }
    }
}
