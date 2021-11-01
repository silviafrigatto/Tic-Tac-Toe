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
    public partial class Form2 : Form
    {
        bool turn, button_disable;
        int x_wins = 0, o_wins = 0, draws = 0, rounds = 0, winner = 0;

        public Form2()
        {
            InitializeComponent();
        }

        //  AI
        
        private void Offensive()
        {
            if (turn == true)
            {
                for (int i = 1; i <= 17; i++)
                {
                    if (i == 17 && turn == true)
                    {
                        Defensive();
                    }
                    if (button1.Text == "O" && button2.Text == "O" && button3.Text == "" && turn == true || button6.Text == "O" && button6.Text == "O" && button3.Text == "" && turn == true)
                    {
                        button3.Text = "O";
                        rounds++;
                        turn = false;
                        checkWinner();
                    }

                    if (button1.Text == "O" && button3.Text == "O" && button2.Text == "" && turn == true || button5.Text == "O" && button8.Text == "O" && button2.Text == "" && turn == true)
                    {
                        button2.Text = "O";
                        rounds++;
                        turn = false;
                        checkWinner();
                    }

                    if (button2.Text == "O" && button3.Text == "O" && button1.Text == "" && turn == true || button4.Text == "O" && button7.Text == "O" && button1.Text == "" && turn == true)
                    {
                        button1.Text = "O";
                        rounds++;
                        turn = false;
                        checkWinner();
                    }
                    if (button4.Text == "O" && button5.Text == "O" && button6.Text == "" && turn == true || button3.Text == "O" && button9.Text == "O" && button6.Text == "" && turn == true)
                    {
                        button6.Text = "O";
                        rounds++;
                        turn = false;
                        checkWinner();
                    }
                    if (button5.Text == "O" && button6.Text == "O" && button4.Text == "" && turn == true || button1.Text == "O" && button7.Text == "O" && button4.Text == "" && turn == true)
                    {
                        button4.Text = "O";
                        rounds++;
                        turn = false;
                        checkWinner();
                    }
                    if (button4.Text == "O" && button6.Text == "O" && button5.Text == "" && turn == true || button2.Text == "O" && button8.Text == "O" && button5.Text == "" && turn == true)
                    {
                        button5.Text = "O";
                        rounds++;
                        turn = false;
                        checkWinner();
                    }
                    if (button7.Text == "O" && button8.Text == "O" && button9.Text == "" && turn == true || button3.Text == "O" && button6.Text == "O" && button9.Text == "" && turn == true)
                    {
                        button9.Text = "O";
                        rounds++;
                        turn = false;
                        checkWinner();
                    }

                    if (button8.Text == "O" && button9.Text == "O" && button7.Text == "" && turn == true || button1.Text == "O" && button4.Text == "O" && button7.Text == "" && turn == true)
                    {
                        button7.Text = "O";
                        rounds++;
                        turn = false;
                        checkWinner();
                    }
                    if (button7.Text == "O" && button9.Text == "O" && button8.Text == "" && turn == true || button2.Text == "O" && button5.Text == "O" && button8.Text == "" && turn == true)
                    {
                        button8.Text = "O";
                        rounds++;
                        turn = false;
                        checkWinner();
                    }
                    if (button2.Text == "O" && button4.Text == "O" && button8.Text == "" && turn == true)
                    {
                        button8.Text = "O";
                        rounds++;
                        turn = false;
                        checkWinner();
                    }
                    if (button4.Text == "O" && button8.Text == "O" && button2.Text == "" && turn == true)
                    {
                        button2.Text = "O";
                        rounds++;
                        turn = false;
                        checkWinner();
                    }
                    if (button1.Text == "O" && button5.Text == "O" && button9.Text == "" && turn == true)
                    {
                        button9.Text = "O";
                        rounds++;
                        turn = false;
                        checkWinner();
                    }
                    if (button3.Text == "O" && button5.Text == "O" && button7.Text == "" && turn == true)
                    {
                        button7.Text = "O";
                        rounds++;
                        turn = false;
                        checkWinner();
                    }
                    if (button5.Text == "O" && button9.Text == "O" && button1.Text == "" && turn == true)
                    {
                        button1.Text = "O";
                        rounds++;
                        turn = false;
                        checkWinner();
                    }
                    if (button7.Text == "O" && button5.Text == "O" && button3.Text == "" && turn == true)
                    {
                        button3.Text = "O";
                        rounds++;
                        turn = false;
                        checkWinner();
                    }
                    if (button1.Text == "O" && button9.Text == "O" && button5.Text == "" && turn == true || button3.Text == "O" && button7.Text == "O" && button5.Text == "" && turn == true)
                    {
                        button5.Text = "O";
                        rounds++;
                        turn = false;
                        checkWinner();
                    }
                }
            }
        }

        private void Defensive()
        {
            if (turn == true)
            {
                for (int j = 1; j <= 17; j++)
                {
                    if (j == 17 && turn == true)
                    {
                        Random();
                    }
                    if (button1.Text == "X" && button2.Text == "X" && button3.Text == "" && turn == true || button6.Text == "X" && button6.Text == "X" && button3.Text == "" && turn == true)
                    {
                        button3.Text = "O";
                        rounds++;
                        turn = false;
                        checkWinner();
                    }

                    if (button1.Text == "X" && button3.Text == "X" && button2.Text == "" && turn == true || button5.Text == "X" && button8.Text == "X" && button2.Text == "" && turn == true)
                    {
                        button2.Text = "O";
                        rounds++;
                        turn = false;
                        checkWinner();
                    }

                    if (button2.Text == "X" && button3.Text == "X" && button1.Text == "" && turn == true || button4.Text == "X" && button7.Text == "X" && button1.Text == "" && turn == true)
                    {
                        button1.Text = "O";
                        rounds++;
                        turn = false;
                        checkWinner();
                    }
                    if (button4.Text == "X" && button5.Text == "X" && button6.Text == "" && turn == true || button3.Text == "X" && button9.Text == "X" && button6.Text == "" && turn == true)
                    {
                        button6.Text = "O";
                        rounds++;
                        turn = false;
                        checkWinner();
                    }
                    if (button5.Text == "X" && button6.Text == "X" && button4.Text == "" && turn == true || button1.Text == "X" && button7.Text == "X" && button4.Text == "" && turn == true)
                    {
                        button4.Text = "O";
                        rounds++;
                        turn = false;
                        checkWinner();
                    }
                    if (button4.Text == "X" && button6.Text == "X" && button5.Text == "" && turn == true || button2.Text == "X" && button8.Text == "X" && button5.Text == "" && turn == true)
                    {
                        button5.Text = "O";
                        rounds++;
                        turn = false;
                        checkWinner();
                    }
                    if (button7.Text == "X" && button8.Text == "X" && button9.Text == "" && turn == true || button3.Text == "X" && button6.Text == "X" && button9.Text == "" && turn == true)
                    {
                        button9.Text = "O";
                        rounds++;
                        turn = false;
                        checkWinner();
                    }

                    if (button8.Text == "X" && button9.Text == "X" && button7.Text == "" && turn == true || button1.Text == "X" && button4.Text == "X" && button7.Text == "" && turn == true)
                    {
                        button7.Text = "O";
                        rounds++;
                        turn = false;
                        checkWinner();
                    }
                    if (button7.Text == "X" && button9.Text == "X" && button8.Text == "" && turn == true || button2.Text == "X" && button5.Text == "X" && button8.Text == "" && turn == true)
                    {
                        button8.Text = "O";
                        rounds++;
                        turn = false;
                        checkWinner();
                    }
                    if (button2.Text == "X" && button4.Text == "X" && button8.Text == "" && turn == true)
                    {
                        button8.Text = "O";
                        rounds++;
                        turn = false;
                        checkWinner();
                    }
                    if (button4.Text == "X" && button8.Text == "X" && button2.Text == "" && turn == true)
                    {
                        button2.Text = "O";
                        rounds++;
                        turn = false;
                        checkWinner();
                    }
                    if (button1.Text == "X" && button5.Text == "X" && button9.Text == "" && turn == true)
                    {
                        button9.Text = "O";
                        rounds++;
                        turn = false;
                        checkWinner();
                    }
                    if (button3.Text == "X" && button5.Text == "X" && button7.Text == "" && turn == true)
                    {
                        button7.Text = "O";
                        rounds++;
                        turn = false;
                        checkWinner();
                    }
                    if (button5.Text == "X" && button9.Text == "X" && button1.Text == "" && turn == true)
                    {
                        button1.Text = "O";
                        rounds++;
                        turn = false;
                        checkWinner();
                    }
                    if (button7.Text == "X" && button5.Text == "X" && button3.Text == "" && turn == true)
                    {
                        button3.Text = "O";
                        rounds++;
                        turn = false;
                        checkWinner();
                    }
                    if (button1.Text == "X" && button9.Text == "X" && button5.Text == "" && turn == true || button3.Text == "X" && button7.Text == "X" && button5.Text == "" && turn == true)
                    {
                        button5.Text = "O";
                        rounds++;
                        turn = false;
                        checkWinner();
                    }
                }
            }
        }

        private void Random()
        {
            bool looping = false;

            if (turn == true)
            {
                looping = true;
            }

            while (looping != false)
            {
                Random rdn = new Random();
                int randomize = rdn.Next(1, 9);

                switch (randomize)
                {
                    case 1:
                        if (button1.Text == "" && turn == true)
                        {
                            button1.Text = "O";
                            rounds++;
                            turn = false;
                            looping = false;
                            checkWinner();
                        }
                        break;
                    case 2:
                        if (button2.Text == "" && turn == true)
                        {
                            button2.Text = "O";
                            rounds++;
                            turn = false;
                            looping = false;
                            checkWinner();
                        }
                        break;
                    case 3:
                        if (button3.Text == "" && turn == true)
                        {
                            button3.Text = "O";
                            rounds++;
                            turn = false;
                            looping = false;
                            checkWinner();
                        }
                        break;
                    case 4:
                        if (button4.Text == "" && turn == true)
                        {
                            button4.Text = "O";
                            rounds++;
                            turn = false;
                            looping = false;
                            checkWinner();
                        }
                        break;
                    case 5:
                        if (button5.Text == "" && turn == true)
                        {
                            button5.Text = "O";
                            rounds++;
                            turn = false;
                            looping = false;
                            checkWinner();
                        }
                        break;
                    case 6:
                        if (button6.Text == "" && turn == true)
                        {
                            button6.Text = "O";
                            rounds++;
                            turn = false;
                            looping = false;
                            checkWinner();
                        }
                        break;
                    case 7:
                        if (button7.Text == "" && turn == true)
                        {
                            button7.Text = "O";
                            rounds++;
                            turn = false;
                            looping = false;
                            checkWinner();
                        }
                        break;
                    case 8:
                        if (button8.Text == "" && turn == true)
                        {
                            button8.Text = "O";
                            rounds++;
                            turn = false;
                            looping = false;
                            checkWinner();
                        }
                        break;
                    case 9:
                        if (button9.Text == "" && turn == true)
                        {
                            button9.Text = "O";
                            rounds++;
                            turn = false;
                            looping = false;
                            checkWinner();
                        }
                        break;
                }
            }
        }

        // Shows the winner
        private void hasWinner()
        {
            if (winner == 1)
            {
                x_wins++;
                label6.Text = Convert.ToString(x_wins);
                MessageBox.Show("Player wins!");
                button_disable = true;
            }
            else if (winner == 2)
            {
                o_wins++;
                label5.Text = Convert.ToString(o_wins);
                MessageBox.Show("Computer wins!");
                button_disable = true;
            }
        }

        //  Checks who is the winner
        private void checkWinner()
        {
            //  Player
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                winner = 1;
                hasWinner();
            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                winner = 1;
                hasWinner();
            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                winner = 1;
                hasWinner();
            }
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                winner = 1;
                hasWinner();
            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                winner = 1;
                hasWinner();
            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                winner = 1;
                hasWinner();
            }
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                winner = 1;
                hasWinner();
            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                winner = 1;
                hasWinner();
            }

            // Computer
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {

                winner = 2;
                hasWinner();
            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                winner = 2;
                hasWinner();
            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                winner = 2;
                hasWinner();
            }
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                winner = 2;
                hasWinner();
            }
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                winner = 2;
                hasWinner();
            }
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                winner = 2;
                hasWinner();
            }
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                winner = 2;
                hasWinner();
            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                winner = 2;
                hasWinner();
            }
            if (rounds == 9 && winner == 0)
            {
                MessageBox.Show("Draw");
                draws++;
                label4.Text = Convert.ToString(draws);
                button_disable = true;
            }
            if (turn == true && winner == 0 && rounds != 9)
            {
                Offensive();
            }
        }

        //  Buttons
        private void button1_Click(object sender, EventArgs e)
        {
            if (turn == false && button_disable == false && button1.Text == "")
            {
                button1.Text = "X";
                button1.BackColor = Color.DarkSalmon;
                rounds++;
                turn = true;
                checkWinner();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (turn == false && button_disable == false && button2.Text == "")
            {
                button2.Text = "X";
                button2.BackColor = Color.DarkSalmon;
                rounds++;
                turn = true;
                checkWinner();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (turn == false && button_disable == false && button3.Text == "")
            {
                button3.Text = "X";
                button3.BackColor = Color.DarkSalmon;
                rounds++;
                turn = true;
                checkWinner();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (turn == false && button_disable == false && button4.Text == "")
            {
                button4.Text = "X";
                button4.BackColor = Color.DarkSalmon;
                rounds++;
                turn = true;
                checkWinner();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (turn == false && button_disable == false && button5.Text == "")
            {
                button5.Text = "X";
                button5.BackColor = Color.DarkSalmon;
                rounds++;
                turn = true;
                checkWinner();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (turn == false && button_disable == false && button6.Text == "")
            {
                button6.Text = "X";
                button6.BackColor = Color.DarkSalmon;
                rounds++;
                turn = true;
                checkWinner();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (turn == false && button_disable == false && button7.Text == "")
            {
                button7.Text = "X";
                button7.BackColor = Color.DarkSalmon;
                rounds++;
                turn = true;
                checkWinner();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (turn == false && button_disable == false && button8.Text == "")
            {
                button8.Text = "X";
                button8.BackColor = Color.DarkSalmon;
                rounds++;
                turn = true;
                checkWinner();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (turn == false && button_disable == false && button9.Text == "")
            {
                button9.Text = "X";
                button9.BackColor = Color.DarkSalmon;
                rounds++;
                turn = true;
                checkWinner();
            }
        }
    }
}
