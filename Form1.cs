using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacDanny
{
    public partial class Form1 : Form
    {
        bool playerTurn = true; //X Turn -> true, O Turn -> false
        int turnCount = 0;
        int winStreak = 0; // Positive for x , neg for O


        public Form1()
        {
            InitializeComponent();
            updateWinStreak("");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void buttonClick(object sender, EventArgs e)
        {
            Button theButton = (Button)sender;

            if (playerTurn)
            {
                theButton.Text = "X";
                theButton.Enabled = false;
            }
            else
            {
                theButton.Text = "O";
                theButton.Enabled = false;
            }
            turnCount++; //for the draws, max play is 9
            playerTurn = !playerTurn;
            checkWinner();
        }
        private void checkWinner()
        {
            /*foreach(Control x in Controls)//emmunmeration of all control{}
             */
            bool weHaveWinner = false;


            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A2.Enabled))
                weHaveWinner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B2.Enabled))
                weHaveWinner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C2.Enabled))
                weHaveWinner = true;

            // |||
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!B1.Enabled))
                weHaveWinner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!B2.Enabled))
                weHaveWinner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!B3.Enabled))
                weHaveWinner = true;

            //X
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!B2.Enabled))
                weHaveWinner = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!B2.Enabled))
                weHaveWinner = true;


            if (weHaveWinner)
            {
                //disableAllbtn();

                String winner = "";

                if (playerTurn)
                    winner = "O";
                else
                    winner = "X";
                updateWinStreak(winner);

                MessageBox.Show(winner + " Wins!", "GG");
                autoNewGame();
            }
            else
            {
                if (turnCount == 9)
                {
                    MessageBox.Show("Draw");
                    //disableAllbtn();
                    autoNewGame();
                }

            }


        }

        private void ResetGame()
        {
            List<Button> buttons;
            buttons = new List<Button> { A1, A2, A3, B1, B2, B3, C1, C2, C3 };

            foreach (Button b in buttons)
            {
                b.Enabled = true;
                b.Text = "";
            }

        }
        private void autoNewGame()
        {
            playerTurn = true;
            turnCount = 0;

            try
            {
                foreach (Control c in Controls)
                {
                    if (c is Button)
                    {
                        (c as Button).Enabled = true;
                        (c as Button).Text = "";
                    }
                }
            }
            catch { }
        }

        private void updateWinStreak(string winner)
        {
            if (winner == "X")
            {
                if (winStreak < 0) // If O was on a win streak, zero it before incrementing
                    winStreak = 0;
                winStreak++;
            }
            else if (winner == "O")
            {
                if (winStreak > 0) // If X was on a win streak, zero it before decrementing
                    winStreak = 0;
                winStreak--;
            }
            else
            {
                winStreak = 0;
            }

            winStreakLabel.Visible = (winStreak != 0);
            winStreakLabel.Text = String.Format("{0} is on a win streak of {1}", winner, Math.Abs(winStreak));
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void winStreakLabel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reset the win streak?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                updateWinStreak("");
            }
        }

    }

}



