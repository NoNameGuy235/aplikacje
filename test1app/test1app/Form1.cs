using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int wynik = 0;
            if(odp3.Checked)
            {
                wynik++;
            }

            if (odp7.Checked)
            {
                wynik++;

            }

            if (checkBox1.Checked && checkBox4.Checked)
            {
                wynik++;
            }

            if (textBox1.Text =="jeden")
            {
                wynik++;
            }

            MessageBox.Show("zdobyles " + wynik + " z 4 punktuw");
        }
    }
}
