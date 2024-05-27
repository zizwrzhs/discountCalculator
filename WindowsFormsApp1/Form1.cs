using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;



namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            origPrice.Text = "e.g. 14.99";
            origPrice.ForeColor = Color.LightGray;

            discount.Text = "e.g. 20";
            discount.ForeColor = Color.LightGray;

            label5.Text = "-";
            label5.ForeColor = Color.White;
            label6.Text = "-";
            label6.ForeColor = Color.White;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void discount_Enter(object sender, EventArgs e)
        {
            if (discount.Text == "e.g. 20")
            {
                discount.Text = "";
                discount.ForeColor = Color.Black;
            }
        }

        private void discount_Leave(object sender, EventArgs e)
        {
            if (discount.Text == "")
            {
                discount.Text = "e.g. 20";
                discount.ForeColor = Color.LightGray;
            }
        }

        private void origPrice_Enter(object sender, EventArgs e)
        {
            if (origPrice.Text == "e.g. 14.99")
            {
                origPrice.Text = "";
                origPrice.ForeColor = Color.Black;
            }
        }

        private void origPrice_Leave(object sender, EventArgs e)
        {
            if (origPrice.Text == "")
            {
                origPrice.Text = "e.g. 14.99";
                origPrice.ForeColor = Color.LightGray; 
            }
        }

        private void origPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (origPrice.Text == "0" && e.KeyChar != '.')
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                } else
                {
                    origPrice.Text = "";
                }
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.' && (sender as TextBox).Text.Contains('.')))
            {
                e.Handled = true;
            }
        }

        private void discount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (discount.Text == "0" && e.KeyChar != '.')
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
                else
                {
                    discount.Text = "";
                }
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.' && (sender as TextBox).Text.Contains('.')) || (e.KeyChar == '-' && (sender as TextBox).Text.Contains('-')))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double num1, num2, result, save;

            if (origPrice.Text == "" || discount.Text == "" || origPrice.Text == "e.g. 14.99" || discount.Text == "e.g. 20")
            {
                MessageBox.Show("Please make sure all required fields are filled in.", "Incomplete Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                num1 = Convert.ToDouble(origPrice.Text);
                num2 = Convert.ToDouble(discount.Text);
                result = (double)num1 - (double)num1 * num2 / 100;
                save = (double)num1 * num2 / 100;

                result = Math.Round(result, 2);
                save = Math.Round(save, 2);

                if (result < num1)
                {
                    label5.ForeColor = Color.LightGreen;

                }
                else if (result > num1)
                {
                    
                    label5.ForeColor = Color.LightCoral;
                }
                else if (result == num1)
                {
                    label5.ForeColor = Color.White;
                }

                if (save > 0)
                {
                    label6.ForeColor = Color.LightGreen;

                }
                else if (save < 0)
                {

                    label6.ForeColor = Color.LightCoral;

                }
                else if (save == 0)
                {
                    label6.ForeColor = Color.White;
                }

                label5.Text = result.ToString("0.00") + "€";

                label6.Text = save.ToString("0.00") + "€";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void Label_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }
    }
}
