using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Global
        {
            public static bool turn, button_disable;
                public static int p1 = 0, player1_wins = 0, player2_wins = 0, tie = 0, rounds = 0, A = 0, B = 0, C = 0, D = 0, E = 0, F = 0, G = 0, H = 0, I = 0;

        }

        //  Action in Button 1
        private void button1_Click(object sender, EventArgs e)  
        {
            // Verify turn: Player 1 (X)
            if(Global.turn == false && Global.button_disable == false && Global.A == 0)
            {
                button1.Text = "X";
                button1.BackColor = Color.DarkSalmon;
                Global.A = 1;
                Global.rounds++;
                checkingWinner();
                Global.turn = true;
            }

            //  Verify turn: Player 2 (O)

            if(Global.turn == true && Global.button_disable == false && Global.A == 0)
            {
                button1.Text = "O";
                button1.BackColor = Color.AliceBlue;
                Global.A = 2;
                Global.rounds++;
                checkingWinner();
                Global.turn = false;
            }
        }

        private void checkingWinner()
        {
            // Checking if Player 1(X) won - horizontal 
            if (Global.A == 1 && Global.B == 1 && Global.C == 1)
            {
                Global.p1 = 1;
                wins();
            }

            if (Global.D == 1 && Global.E == 1 && Global.F == 1)
            {
                Global.p1 = 1;
                wins();
            }

            if (Global.G == 1 && Global.H == 1 && Global.I == 1)
            {
                Global.p1 = 1;
                wins();
            }

            //  Checking if Player 1(X) won - vertical
            if (Global.A == 1 && Global.D == 1 && Global.G == 1)
            {
                Global.p1 = 1;
                wins();
            }

            if (Global.B == 1 && Global.E == 1 && Global.H == 1)
            {
                Global.p1 = 1;
                wins();
            }

            if (Global.C == 1 && Global.F == 1 && Global.I == 1)
            {
                Global.p1 = 1;
                wins();
            }

            // Checking if Player 1(X) won - diagonal
            if (Global.A == 1 && Global.E == 1 && Global.I == 1)
            {
                Global.p1 = 1;
                wins();
            }

            if (Global.C == 1 && Global.E == 1 && Global.G == 1)
            {
                Global.p1 = 1;
                wins();
            }

            // Checking if Player 2(O) won - horizontal 
            if (Global.A == 2 && Global.B == 2 && Global.C == 2)
            {
                Global.p1 = 2;
                wins();
            }

            if (Global.D == 2 && Global.E == 2 && Global.F == 2)
            {
                Global.p1 = 2;
                wins();
            }

            if (Global.G == 2 && Global.H == 2 && Global.I == 2)
            {
                Global.p1 = 2;
                wins();
            }

            //  Checking if Player 2(O) won - vertical
            if (Global.A == 2 && Global.D == 2 && Global.G == 2)
            {
                Global.p1 = 2;
                wins();
            }

            if (Global.B == 2 && Global.E == 2 && Global.H == 2)
            {
                Global.p1 = 2;
                wins();
            }

            if (Global.C == 2 && Global.F == 2 && Global.I == 2)
            {
                Global.p1 = 2;
                wins();
            }

            // Checking if Player 2(O) won - diagonal
            if (Global.A == 2 && Global.E == 2 && Global.I == 2)
            {
                Global.p1 = 2;
                wins();
            }

            if (Global.C == 2 && Global.E == 2 && Global.G == 2)
            {
                Global.p1 = 2;
                wins();
            }

            //  Checking if it's a draw
            if (Global.p1 == 0 && Global.rounds == 9)
            {
                Global.tie++;
                label6.Text = Convert.ToString(Global.tie);
                MessageBox.Show("Draw!");
                Global.button_disable = true;

            }
        }

        //  Action in Button 2
        private void button2_Click(object sender, EventArgs e)  
        {
            // Verify turn: Player 1 (X)
            if (Global.turn == false && Global.button_disable == false && Global.B == 0)
            {
                button2.Text = "X";
                button2.BackColor = Color.DarkSalmon;
                Global.B = 1;
                Global.rounds++;
                checkingWinner();
                Global.turn = true;
            }

            //  Verify turn: Player 2 (O)

            if (Global.turn == true && Global.button_disable == false && Global.B == 0)
            {
                button2.Text = "O";
                button2.BackColor = Color.AliceBlue;
                Global.B = 2;
                Global.rounds++;
                checkingWinner();
                Global.turn = false;
            }
        }

        //  Action in Button 3
        private void button3_Click(object sender, EventArgs e)
        {
            // Verify turn: Player 1 (X)
            if (Global.turn == false && Global.button_disable == false && Global.C == 0)
            {
                button3.Text = "X";
                button3.BackColor = Color.DarkSalmon;
                Global.C = 1;
                Global.rounds++;
                checkingWinner();
                Global.turn = true;
            }

            //  Verify turn: Player 2 (O)

            if (Global.turn == true && Global.button_disable == false && Global.C == 0)
            {
                button3.Text = "O";
                button3.BackColor = Color.AliceBlue;
                Global.C = 2;
                Global.rounds++;
                checkingWinner();
                Global.turn = false;
            }
        }

        // Action in Button 4
        private void button4_Click(object sender, EventArgs e)
        {
            // Verify turn: Player 1 (X)
            if (Global.turn == false && Global.button_disable == false && Global.D == 0)
            {
                button4.Text = "X";
                button4.BackColor = Color.DarkSalmon;
                Global.D = 1;
                Global.rounds++;
                checkingWinner();
                Global.turn = true;
            }

            //  Verify turn: Player 2 (O)

            if (Global.turn == true && Global.button_disable == false && Global.D == 0)
            {
                button4.Text = "O";
                button4.BackColor = Color.AliceBlue;
                Global.D = 2;
                Global.rounds++;
                checkingWinner();
                Global.turn = false;
            }
        }

        //  Action in Button 5
        private void button5_Click(object sender, EventArgs e)
        {
            // Verify turn: Player 1 (X)
            if (Global.turn == false && Global.button_disable == false && Global.E == 0)
            {
                button5.Text = "X";
                button5.BackColor = Color.DarkSalmon;
                Global.E = 1;
                Global.rounds++;
                checkingWinner();
                Global.turn = true;
            }

            //  Verify turn: Player 2 (O)

            if (Global.turn == true && Global.button_disable == false && Global.E == 0)
            {
                button5.Text = "O";
                button5.BackColor = Color.AliceBlue;
                Global.E = 2;
                Global.rounds++;
                checkingWinner();
                Global.turn = false;
            }
        }

        // Action in Button 6
        private void button6_Click(object sender, EventArgs e)
        {
            // Verify turn: Player 1 (X)
            if (Global.turn == false && Global.button_disable == false && Global.F == 0)
            {
                button6.Text = "X";
                button6.BackColor = Color.DarkSalmon;
                Global.F = 1;
                Global.rounds++;
                checkingWinner();
                Global.turn = true;
            }

            //  Verify turn: Player 2 (O)

            if (Global.turn == true && Global.button_disable == false && Global.F == 0)
            {
                button6.Text = "O";
                button6.BackColor = Color.AliceBlue;
                Global.F = 2;
                Global.rounds++;
                checkingWinner();
                Global.turn = false;
            }
        }

        //  Action in Button 7
        private void button7_Click(object sender, EventArgs e)
        {
            // Verify turn: Player 1 (X)
            if (Global.turn == false && Global.button_disable == false && Global.G == 0)
            {
                button7.Text = "X";
                button7.BackColor = Color.DarkSalmon;
                Global.G = 1;
                Global.rounds++;
                checkingWinner();
                Global.turn = true;
            }

            //  Verify turn: Player 2 (O)

            if (Global.turn == true && Global.button_disable == false && Global.G == 0)
            {
                button7.Text = "O";
                button7.BackColor = Color.AliceBlue;
                Global.G = 2;
                Global.rounds++;
                checkingWinner();
                Global.turn = false;
            }
        }
        
        //  Action in Button 8
        private void button8_Click(object sender, EventArgs e)
        {
            // Verify turn: Player 1 (X)
            if (Global.turn == false && Global.button_disable == false && Global.H == 0)
            {
                button8.Text = "X";
                button8.BackColor = Color.DarkSalmon;
                Global.H = 1;
                Global.rounds++;
                checkingWinner();
                Global.turn = true;
            }

            //  Verify turn: Player 2 (O)

            if (Global.turn == true && Global.button_disable == false && Global.H == 0)
            {
                button8.Text = "O";
                button8.BackColor = Color.AliceBlue;
                Global.H = 2;
                Global.rounds++;
                checkingWinner();
                Global.turn = false;
            }
        }

        //  Action in Button 9
        private void button9_Click(object sender, EventArgs e)
        {
            // Verify turn: Player 1 (X)
            if (Global.turn == false && Global.button_disable == false && Global.I == 0)
            {
                button9.Text = "X";
                button9.BackColor = Color.DarkSalmon;
                Global.I = 1;
                Global.rounds++;
                checkingWinner();
                Global.turn = true;
            }

            //  Verify turn: Player 2 (O)

            if (Global.turn == true && Global.button_disable == false && Global.I == 0)
            {
                button9.Text = "O";
                button9.BackColor = Color.AliceBlue;
                Global.I = 2;
                Global.rounds++;
                checkingWinner();
                Global.turn = false;
            }
        }

        private void wins()
        {
            if (Global.p1 == 1)
            {
                Global.player1_wins++;
                label4.Text = Convert.ToString(Global.player1_wins);
                MessageBox.Show("Player 1 wins!");
                Global.button_disable = true;
            }
            else if (Global.p1 == 2)
            {
                Global.player2_wins++;
                label5.Text = Convert.ToString(Global.player2_wins);
                MessageBox.Show("Player 2 wins!");
                Global.button_disable = true;
            }

        }

        // Reset game
        private void button10_Click(object sender, EventArgs e)
        {
            Global.A = 0;
            Global.B = 0;
            Global.C = 0;
            Global.D = 0;
            Global.E = 0;
            Global.F = 0;
            Global.G = 0;
            Global.H = 0;
            Global.I = 0;
            Global.rounds = 0;
            button1.Text = " ";
            button2.Text = " ";
            button3.Text = " ";
            button4.Text = " ";
            button4.Text = " ";
            button5.Text = " ";
            button6.Text = " ";
            button7.Text = " ";
            button8.Text = " ";
            button9.Text = " ";
            button1.BackColor = Color.Empty;
            button2.BackColor = Color.Empty;
            button3.BackColor = Color.Empty;
            button4.BackColor = Color.Empty;
            button5.BackColor = Color.Empty;
            button6.BackColor = Color.Empty;
            button7.BackColor = Color.Empty;
            button8.BackColor = Color.Empty;
            button9.BackColor = Color.Empty;

            Global.button_disable = false;

            if (Global.p1 == 1 || Global.p1 == 0)
            {
                Global.turn = false;
                Global.p1 = 0;
            }
            else if (Global.p1 == 2)
            {
                Global.turn = true;
                Global.p1 = 0;
            }
        }

        // Go to Player vs Computer
        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm2 = new Form2();
            frm2.Show();
        }
    }
}
