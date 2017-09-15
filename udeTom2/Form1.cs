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

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = $"{Class1.Add(numericUpDown1.Value, numericUpDown2.Value)}";
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = $"{Class1.Add(numericUpDown1.Value, numericUpDown2.Value)}";
        }
    }
}
