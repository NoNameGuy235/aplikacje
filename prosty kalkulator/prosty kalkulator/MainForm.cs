using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prosty_kalkulator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonDodawanie_Click(object sender, EventArgs e)
        {
            int firstNumber;
            int secondNumber;
            if (int.TryParse(textBoxFirstNumber.Text, out firstNumber)
                && int.TryParse(textBoxSecondNumber.Text, out secondNumber))
            {
                int result = firstNumber + secondNumber;
                labelReult.Text = "wynik dodawania" + result;

            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
