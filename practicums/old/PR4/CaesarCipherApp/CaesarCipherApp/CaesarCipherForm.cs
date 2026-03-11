using System.Windows.Forms;

namespace CaesarCipherApp
{
    public partial class CaesarCipherForm : Form
    {
        public CaesarCipherForm()
        {
            InitializeComponent();
        }

        private void CaesarCipherForm_Load(object sender, System.EventArgs e)
        {
            comboBoxLanguage.SelectedIndex = 0;
        }

        private void buttonEncrypt_Click(object sender, System.EventArgs e)
        {
            CaesarCipher caesarCipher = new CaesarCipher();
            int shift = (int)numericUpDownShift.Value;
            string text = textBoxSourceText.Text;

            switch (comboBoxLanguage.Text)
            {
                case "Русский":
                    
                    textBoxResult.Text = caesarCipher.RUEncrypt(text, shift);
                    break;

                case "Английский":
                    textBoxResult.Text = caesarCipher.ENEncrypt(text, shift);
                    break;
            }
        }

        private void buttonDecrypt_Click(object sender, System.EventArgs e)
        {
            CaesarCipher caesarCipher = new CaesarCipher();
            int shift = (int)numericUpDownShift.Value;
            string text = textBoxSourceText.Text;

            switch (comboBoxLanguage.Text)
            {
                case "Русский":

                    textBoxResult.Text = caesarCipher.RUDecrypt(text, shift);
                    break;
                case "Английский":
                    textBoxResult.Text = caesarCipher.ENDecrypt(text, shift);
                    break;
            }
        }

        private void buttonClear_Click(object sender, System.EventArgs e)
        {
            textBoxSourceText.Text = string.Empty;
            textBoxResult.Text = string.Empty;
        }
    }
}
