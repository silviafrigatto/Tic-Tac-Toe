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
                        rounds++;
                        turn = false;
                        checkWinner();
                    }
                }
            }
        }

        private void Defensive()
        {
        }

        private void Random()
        {
        }

        private void checkWinner()
        {
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
