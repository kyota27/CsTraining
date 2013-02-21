using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Training1
{
    public static class TextBoxExtensions
    {
        public static int ToInt(this TextBox textBox)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
                textBox.Text = "0";

            int result; 
            if (!int.TryParse(textBox.Text, out result))
                throw new Exception(
                    string.Format(Properties.Resources.InputOutOfRangeMessage, 0, int.MaxValue));
            return result;
        }
    }
}
