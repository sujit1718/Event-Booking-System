using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FirstDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int year;
            year = int.Parse(txt_year.Text);
            if (year % 4 == 0)
            {
                MessageBox.Show("GIven year is leap year");
            }
            else 
            {
                MessageBox.Show("Given year is not Leap Year");
            }

        }
    }
}
