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
            decimal max, min, average, sum;
            Class1.Summarize(values, out max, out min, out average, out sum);
            label1.Text = $"Average: {Math.Round(average)}\n";
            label1.Text += $"Sum: {sum}\n";
            label1.Text += $"Max: {max}\n";


        }
    }
}
