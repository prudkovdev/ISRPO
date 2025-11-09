namespace CaesarCipherApp
{
    public class CaesarCipher
    {
        private readonly char[] ENAlphabet =
        {
            'A', 'B', 'C', 'D', 'E', 'F', 'G',
            'H', 'I', 'J', 'K', 'L', 'M', 'N',
            'O', 'P', 'Q', 'R', 'S', 'T', 'U',
            'V', 'W', 'X', 'Y', 'Z'
        };

        private readonly char[] RUAlphabet = { 
            'А', 'Б', 'В', 'Г', 'Д', 'Е', 
            'Ё', 'Ж', 'З', 'И', 'Й', 'К',
            'Л', 'М', 'Н', 'О', 'П', 'Р',
            'С', 'Т', 'У', 'Ф', 'Х', 'Ц',
            'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ',
            'Э', 'Ю', 'Я'
        };

        public string ENEncrypt(string text, int shift)
        {
            string result = string.Empty;
            char[] chars = text.ToUpper().ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                for (int j = 0; j < ENAlphabet.Length; j++)
                {

                    if (chars[i] == ENAlphabet[j])
                    {
                        chars[i] = ENAlphabet[((j + shift) >= ENAlphabet.Length ? j + shift - ENAlphabet.Length : j + shift)];
                        break;
                    }
                }
            }

            foreach (char c in chars)
            {
                result += c.ToString();
            }

            return result;
        }

        public string RUEncrypt(string text, int shift)
        {
            string result = string.Empty;
            char[] chars = text.ToUpper().ToCharArray();
            
            for (int i = 0; i < chars.Length; i++)
            {
                for (int j = 0; j < RUAlphabet.Length; j++)
                {

                    if (chars[i] == RUAlphabet[j])
                    {
                        chars[i] = RUAlphabet[((j + shift) >= RUAlphabet.Length ? j + shift - RUAlphabet.Length : j + shift)];
                        break;
                    }
                }
            }

            foreach (char c in chars)
            {
                result += c.ToString();
            }

            return result;
        }

        public string ENDecrypt(string text, int shift)
        {
            string result = string.Empty;
            char[] chars = text.ToUpper().ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                for (int j = 0; j < ENAlphabet.Length; j++)
                {
                    if (chars[i] == ENAlphabet[j])
                    {
                        chars[i] = ENAlphabet[((j - shift) < 0 ? j - shift + ENAlphabet.Length : j - shift)];
                        break;
                    }
                }
            }

            foreach (char c in chars)
            {
                result += c.ToString();
            }

            return result;
        }

        public string RUDecrypt(string text, int shift)
        {
            string result = string.Empty;
            char[] chars = text.ToUpper().ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                for (int j = 0; j < RUAlphabet.Length; j++)
                {
                    if (chars[i] == RUAlphabet[j])
                    {
                        chars[i] = RUAlphabet[((j - shift) < 0 ? j - shift + RUAlphabet.Length : j - shift)];
                        break;
                    }
                }
            }

            foreach (char c in chars)
            {
                result += c.ToString();
            }

            return result;
        }
    }
}
