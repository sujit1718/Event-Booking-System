using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Addition1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = int.Parse(txt1.Text);
            b = int.Parse(txt2.Text);
            c = a + b;
            txt.Text = c.ToString();
            MessageBox.Show("Addition is : " + c);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    

 }
}    