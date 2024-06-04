using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;



namespace DiscCalc
{
    public partial class Form1 : Form   
    {

        private const string PlaceholderTextPrice = "e.g. 14.99";
        private const string PlaceholderTextDisc = "e.g. 20";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            origPrice.Text = PlaceholderTextPrice;
            origPrice.ForeColor = Color.LightGray;

            discount.Text = PlaceholderTextDisc;
            discount.ForeColor = Color.LightGray;

            fprice.Text = "-";
            fprice.ForeColor = Color.White;
            saved.Text = "-";
            saved.ForeColor = Color.White;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void Label_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void origPrice_TextChanged(object sender, EventArgs e)
        {
            if (origPrice.Text != PlaceholderTextPrice)
            {
                ValidateTextBox(origPrice);
            }

            LeadingZeros(sender, e);

            // CHAT GPT ↓

            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Text.Contains('.') /* mine -> */ && textBox.Text != PlaceholderTextPrice)
            {
                int maxLengthAfterDecimal = 2; // Set the maximum length after the decimal point
                int decimalIndex = textBox.Text.IndexOf('.');
                if (textBox.Text.Length - decimalIndex > maxLengthAfterDecimal + 1)
                {
                    textBox.Text = textBox.Text.Substring(0, decimalIndex + maxLengthAfterDecimal + 1);
                    textBox.SelectionStart = textBox.Text.Length;
                }
            }

            // CHAT GPT ↑
        }

        private void discount_TextChanged(object sender, EventArgs e)
        {
            if (discount.Text != PlaceholderTextDisc)
            {
                ValidateTextBox(discount);
            }

            LeadingZeros(sender, e);
        }

        private void origPrice_Enter(object sender, EventArgs e)
        {
            if (origPrice.Text == PlaceholderTextPrice)
            {
                origPrice.Text = "";
                origPrice.ForeColor = Color.Black;
            }
        }

        private void origPrice_Leave(object sender, EventArgs e)
        {
            if (origPrice.Text == "")
            {
                origPrice.Text = PlaceholderTextPrice;
                origPrice.ForeColor = Color.LightGray;
            }
        }

        private void discount_Enter(object sender, EventArgs e)
        {
            if (discount.Text == PlaceholderTextDisc)
            {
                discount.Text = "";
                discount.ForeColor = Color.Black;
            }
        }

        private void discount_Leave(object sender, EventArgs e)
        {
            if (discount.Text == "")
            {
                discount.Text = PlaceholderTextDisc;
                discount.ForeColor = Color.LightGray;
            }
        }

        private void origPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressTextBox(origPrice, sender, e);
        }

        private void discount_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressTextBox(discount, sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double num1, num2, result, save;

            if (origPrice.Text == "" || discount.Text == "" || origPrice.Text == PlaceholderTextPrice || discount.Text == PlaceholderTextDisc)
            {
                MessageBox.Show("Please make sure all required fields are filled in.", "Incomplete Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Ensure the text is interpreted as using the dot as the decimal separator
                // CHAT GPT ↓
                if (double.TryParse(origPrice.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out num1) &&
                    double.TryParse(discount.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out num2))
                {
                // CHAT GPT ↑

                    save = num1 * num2 / 100.0;
                    result = num1 - save;

                    save = Math.Round(save, 2);

                    if (result < num1)
                    {
                        fprice.ForeColor = Color.LightGreen;
                        saved.ForeColor = Color.LightGreen;
                    }
                    else
                    {
                        fprice.ForeColor = Color.White;
                        saved.ForeColor = Color.White;
                    }

                    CultureInfo culture = new CultureInfo("el-GR");

                    fprice.Text = string.Format(culture, "{0:C}", result);

                    saved.Text = string.Format(culture, "{0:C}", save);
                }
            }
        }

        // FUNCTIONS

        // CHAT GPT ↓

        private void ValidateTextBox(TextBox textBox)
        {
            string text = textBox.Text;
            int dotCount = text.Count(c => c == '.');

            // Check if the text contains only numbers and at most one dot
            if (text.All(c => char.IsDigit(c) || c == '.') && dotCount <= 1)
            {
                // Text is valid
                textBox.BackColor = System.Drawing.Color.White;
            }
            else
            {
                if (textBox == origPrice)
                {
                    MessageBox.Show("Please make sure valid inputs are entered.", "Original Price Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Please make sure valid inputs are entered.", "Discount Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                // Optionally clear the invalid input
                textBox.Text = string.Empty;
            }
        }

        // CHAT GPT ↑

        private void KeyPressTextBox(TextBox textBox, object sender, KeyPressEventArgs e)
        {
            if (textBox.Text == "0" && e.KeyChar != '.')
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
                else
                {
                    textBox.Text = "";
                }
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.' && (sender as TextBox).Text.Contains('.')) && textBox.SelectionLength == 0)
            {
                e.Handled = true;
            }

            if (textBox.Text != "" && e.KeyChar == '0' && textBox.SelectionStart == 0 && textBox.SelectionLength < textBox.Text.Length)
            {
                e.Handled = true;
            }
        }

        // CHAT GPT ↓

        private void LeadingZeros(object sender, EventArgs e) 
        {
            TextBox textBox = sender as TextBox;

            if (textBox != null)
            {
                // Get the current text
                string currentText = textBox.Text;

                // Check if the text starts with leading zeros and does not contain a decimal point at the start
                if (currentText.Length > 1 && currentText.StartsWith("0") && !currentText.StartsWith("0."))
                {
                    // Remove leading zeros
                    string newText = currentText.TrimStart('0');

                    // If the text becomes empty after trimming or starts with '.', set it to "0"
                    if (string.IsNullOrEmpty(newText) || newText.StartsWith("."))
                    {
                        newText = "0";
                    }

                    // Update the text only if it has changed to avoid recursive TextChanged events
                    if (newText != currentText)
                    {
                        textBox.Text = newText;
                        // Set the cursor to the end of the text
                        textBox.SelectionStart = newText.Length;
                    }
                }
            }
        }

        // CHAT GPT ↑

    }
}
