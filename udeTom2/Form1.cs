using System;
using System.Windows.Forms;
using System.IO;

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
            double sum = 0;
            double val;
            for(int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                sum += double.TryParse(dataGridView1[0, i].Value.ToString(), out val) ? val : 0.0;
            }
            label1.Text = $"Suma: {sum}";
        }
    }
}
