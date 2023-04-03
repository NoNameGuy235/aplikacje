using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictocktoe
{
    public partial class MainForm : Form

    {
        string[] players = new string[2];
        int currentPlayerNumber;

        public MainForm()
        {
            InitializeComponent();
            comboWhoStartGame.SelectedIndex = 0;
            players[0] = "O";
            players[0] = "X";
            currentPlayerNumber = comboWhoStartGame.SelectedIndex;
            buttonBoard[0, 0] = buttonPosition00;

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            currentPlayerNumber = comboWhoStartGame.SelectedIndex;
            tableLayoutBoard.Visible = true;

        }

        private void ButtonPosition_Click(object sender, EventArgs e)
        {
            Button buttonSender = sender as Button;
            if (buttonSender.Text == null)
                return;

            if (buttonSender.Text != "")
                return;

            buttonSender.Text = players[currentPlayerNumber];
            if (CheckWin(currentPlayerNumber))
            {


                return;
            }



            ButtonPosition00.Text = players[currentPlayerNumber];

            currentPlayerNumber++;
            if (currentPlayerNumber == 2)
                currentPlayerNumber = 0;
        }

        private bool CheckWin(int currentPlayerNumber)
        {
            return false;
        }
    }
}
