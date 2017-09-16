using System;
using System.Windows.Forms;
using System.Linq;

namespace udeTom2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal[] values = { numericUpDown1.Value, numericUpDown2.Value, numericUpDown3.Value };
            var list = values.ToList();
            label1.Text = $"Average: {values.Average()}\n";
            label1.Text += $"Sum: {values.Sum()}\n";
            label1.Text += $"Max: {values.Max()}\n";


        }
    }
}
