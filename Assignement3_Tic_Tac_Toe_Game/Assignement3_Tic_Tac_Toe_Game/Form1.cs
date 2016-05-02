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
            MessageBox.Show("By Rijo Varghese", "About Assignement3 Tic Tac Toe");
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

            checkforwinner();
        }

        private void checkforwinner()
        {
            //check game winner
            bool we_have_a_winner = fales;
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                we_have_a_winner = true;
            if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                we_have_a_winner = true;
            if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                we_have_a_winner = true;

            if (we_have_a_winner)
            {
                string winner = "";
                if (turn)
                    winner = "O";
                else
                    winner = "X";
                //Box to display winner
                MessageBox.Show(winner + "Wins!", "Yay!");
            }
        }
    }
}
