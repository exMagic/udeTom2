using System;
using System.Windows.Forms;

namespace udeTom2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            label2.Text = $"Amount:{decimal.Parse(textBox1.Text):C}";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal amount1 = decimal.Parse(textBox1.Text);
            decimal amount2 = decimal.Parse(textBox2.Text);
            decimal amount3 = decimal.Parse(textBox3.Text);

            if (comboBox1.SelectedIndex == 0) {
                label3.Text = $"{(amount1*0.25M):C}";
                label5.Text = $"{(amount2 * 0.25M):C}";
                label6.Text = $"{(amount3 * 0.25M):C}";
            }
            else if (comboBox1.SelectedIndex == 1) {
                label3.Text = $"{(amount1 * 0.5M):C}";
                label5.Text = $"{(amount2 * 0.5M):C}";
                label6.Text = $"{(amount3 * 0.5M):C}";
            }
            else if (comboBox1.SelectedIndex == 2) {
                label3.Text = $"{(amount1 * 0.7M):C}";
                label5.Text = $"{(amount2 * 0.7M):C}";
                label6.Text = $"{(amount3 * 0.7M):C}";
            }
            else if (comboBox1.SelectedIndex == 3) {
                label3.Text = $"{(amount1 * 0.75M):C}";
                label5.Text = $"{(amount2 * 0.75M):C}";
                label6.Text = $"{(amount3 * 0.75M):C}";
            }
            else if (comboBox1.SelectedIndex == 4) {
                label3.Text = $"{(amount1 * 0.9M):C}";
                label5.Text = $"{(amount2 * 0.9M):C}";
                label6.Text = $"{(amount3 * 0.9M):C}";
            }



            
        }


    }
}
