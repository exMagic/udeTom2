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

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            textBox1.Text = folderBrowserDialog1.SelectedPath;
            button1.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            string[] files = Directory.GetFiles(textBox1.Text);
            //
            //for (int i = 0; i < files.Length; i++)
            //{
            //    richTextBox1.Text += files[i];
            //}

            foreach (string c in files)
            {
                richTextBox1.Text += $"{c} \n";
               

            }
        }
    }
}
