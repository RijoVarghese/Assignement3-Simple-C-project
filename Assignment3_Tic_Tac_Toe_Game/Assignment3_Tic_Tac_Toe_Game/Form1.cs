using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignement3_Tic_Tac_Toe_Game
{
    public partial class Form1 : Form
    {
        //When trun is true it's X and when turn is False its O
        bool turn = true;
        //variable to count the number of turns
        int count_turn = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tic Tac Toe \nby \n Rijo Varghese \n HU ID-156754", "About Assignement3");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void turn_click(object sender, EventArgs e)
        {
            Button clickturn = (Button)sender;
            if (turn)
                clickturn.Text = "X";
            else
                clickturn.Text = "O";

            turn = !turn;
            clickturn.Enabled = false;
            count_turn++;
            checkforwinner();
        }

        private void checkforwinner()
        {
            //check game winner
            bool we_have_a_winner = false;
            //hozizantal check
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                we_have_a_winner = true;
            if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                we_have_a_winner = true;
            if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                we_have_a_winner = true;

            //vertical check
            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                we_have_a_winner = true;
            if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!B2.Enabled))
                we_have_a_winner = true;
            if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                we_have_a_winner = true;

            //diagonal check
            if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                we_have_a_winner = true;
            if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
                we_have_a_winner = true;
            
            if (we_have_a_winner)
            {
                disablegameifwinner();
                string winner = "";
                if (turn)
                    winner = "O";
                else
                    winner = "X";
                //Box to display winner
                MessageBox.Show(winner + " - Wins!", "Hurry!");
            }
            //check for draw
            else
            {
                if (count_turn == 9)
                    MessageBox.Show("Its Draw!", "Try again!");
            }
        }

        private void disablegameifwinner()
        {
            try
            {
                foreach (Control clicktuncheck in Controls)
                {
                    Button clickturn = (Button)clicktuncheck;
                    clickturn.Enabled = false;
                }
            }
            catch { }
            

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            count_turn = 0;
            try
            {
                foreach (Control clicktuncheck in Controls)
                {
                    Button clickturn = (Button)clicktuncheck;
                    clickturn.Enabled = true;
                    clickturn.Text = "";
                }
            }
            catch { }
        }
    }
}
