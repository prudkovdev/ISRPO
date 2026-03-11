using System;
using System.Windows.Forms;

namespace Testing
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void bStart_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (tbFirstName.Text == string.Empty || tbLastName.Text == string.Empty)
                    throw new Exception("Пустое поле или поля");

                User.FirstName = tbFirstName.Text;
                User.LastName = tbLastName.Text;
                User.TestDate = DateTime.Now;

                using (var testForm = new TestForm())
                {
                    this.Hide();
                    testForm.ShowDialog();
                    this.Show();
                }

                tbFirstName.Clear();
                tbLastName.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
