using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classy
{
    public static class Validator
	{
		private static string title = "Entry Error";

		public static string Title
		{
			get
			{
				return title;
			}
			set
			{
				title = value;
			}
		}

		//Check that text boxes have content
		public static bool IsPresent(TextBox textBox)
		{
			if (textBox.Text == "")
			{
				MessageBox.Show(textBox.Tag + " is a required field.", Title);
				textBox.Focus();
				return false;
			}
			return true;
		}

		//Check that values are decimal
		public static bool IsDecimal(TextBox textBox)
        {
            decimal number = 0m;
            if (Decimal.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(textBox.Tag + " must be a decimal value.", Title);
                textBox.Focus();
                return false;
            }
        }

		//Check that values are integers
		public static bool IsInt32(TextBox textBox)
		{
            int number = 0;
            if (Int32.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(textBox.Tag + " must be an integer.", Title);
                textBox.Focus();
                return false;
            }
		}

		//Check if boolean
		public static bool IsBoolean(TextBox textBox)
		{
			bool result = false;
			bool boolResult;
			if(Boolean.TryParse(textBox.Text, out boolResult)) 
			{
				result = true;
			}
			else
			{
                MessageBox.Show(textBox.Tag + " must be a boolean.", Title);
                textBox.Focus();
            }
			return result;
		}
	}
}
