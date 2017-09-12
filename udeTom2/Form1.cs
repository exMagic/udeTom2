using System;
using System.Windows.Forms;

namespace udeTom2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            label1.Text = $"Average is 0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal fVal = decimal.Parse(textBox1.Text);
            decimal sVal = decimal.Parse(textBox2.Text);
            decimal ave = (fVal + sVal) / 2;
            label1.Text = $"Average is {ave:C}";
        }
    }
}
