using System;
using System.Text;
using System.Windows.Forms;
using NLog;

namespace Formator
{
    public partial class Formator : Form
    {
        static public Logger logger = LogManager.GetCurrentClassLogger();

        public Formator()
        {
            InitializeComponent(); 
            logger.Info("Программа запущена");
        }

        private void convertTextButton_Click(object sender, EventArgs e)
        {
            typographRichTextBox.Text = TypographyText(typographRichTextBox.Text);
            logger.Info("Был преобразован текст");
        }
        public static string TypographyText(string input)
        {
            StringBuilder result = new StringBuilder();

            bool hasSpace = false;

            Random rnd = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                char nextChar = (i < input.Length - 1) ? input[i + 1] : '\0';


                if (char.IsPunctuation(currentChar) && currentChar != '-' && !char.IsWhiteSpace(nextChar))
                {
                    result.Append(currentChar);
                    result.Append(' ');
                    hasSpace = true;
                }

                else if (char.IsWhiteSpace(currentChar))
                {
                    if (!hasSpace)
                    {
                        result.Append(currentChar);
                        hasSpace = true;
                    }
                }
                else
                {
                    result.Append(currentChar);
                    hasSpace = false;
                }

                if (currentChar == '-' && !char.IsWhiteSpace(nextChar))
                {
                    result.Append(' ');
                }
         
                if (currentChar == '.' && nextChar == '.' && i < input.Length - 2 && input[i + 2] == '.')
                {
                    result.Append('…');
                    i += 2;
                }

                if (currentChar == '(' && nextChar == 'c' && i < input.Length - 2 && input[i + 2] == ')')
                {
                    result.Append('©');
                    i += 2;
                }

                // абсурдное правило (4 пробела подряд меняем на фразу)
                input = input.Replace("    ", " не пиши 4 пробела подряд ");

            }

            return result.ToString();
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Типограф.\nВсе права защищены ©.");
        }
    }
}
