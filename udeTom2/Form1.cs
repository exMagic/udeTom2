﻿using System;
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
            double input = double.Parse(textBox1.Text);
            label1.Text = $"13% of {input} is {input * 0.13}";
        }
    }
}
