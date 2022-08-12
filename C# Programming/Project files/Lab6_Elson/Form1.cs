using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_Elson
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        Player[] player = new Player[4];
        Deck deck = new Deck();
        int winner = 0;
        int highest = 0;
        int yourbet = 0;
        bool isDraw = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetInterface();

            deck = new Deck();

            for (int i = 0; i < 4; i++)
            {
                player[i] = new Player();

                for (int j = 1; j <= 5; j++)
                {
                    listView1.Items[i].SubItems.Add("");
                }
            }
        }

        private void MC_button1_Click(object sender, EventArgs e)
        {
            player[0].AddCard(deck.DrawCard(), deck.GetCardValue());
            MC_button1.Enabled = false;
        }

        private void MC_button2_Click(object sender, EventArgs e)
        {
            player[1].AddCard(deck.DrawCard(), deck.GetCardValue());
            MC_button2.Enabled = false;
        }

        private void MC_button3_Click(object sender, EventArgs e)
        {
            player[2].AddCard(deck.DrawCard(), deck.GetCardValue());
            MC_button3.Enabled = false;
        }

        private void MC_button4_Click(object sender, EventArgs e)
        {
            player[3].AddCard(deck.DrawCard(), deck.GetCardValue());
            MC_button4.Enabled = false;
        }

        private void Bet_button1_Click(object sender, EventArgs e)
        {
            YourBet(1);
            Bet_button2.Enabled = false;
            Bet_button3.Enabled = false;
            Bet_button4.Enabled = false;
        }

        private void Bet_button2_Click(object sender, EventArgs e)
        {
            YourBet(2);
            Bet_button1.Enabled = false;
            Bet_button3.Enabled = false;
            Bet_button4.Enabled = false;
        }

        private void Bet_button3_Click(object sender, EventArgs e)
        {
            YourBet(3);
            Bet_button1.Enabled = false;
            Bet_button2.Enabled = false;
            Bet_button4.Enabled = false;
        }

        private void Bet_button4_Click(object sender, EventArgs e)
        {
            YourBet(4);
            Bet_button1.Enabled = false;
            Bet_button2.Enabled = false;
            Bet_button3.Enabled = false;
        }

        private void Reset_button_Click(object sender, EventArgs e)
        {
            Deal_button.Enabled = true;
            Results_label.Text = "Results";
            Status_label.Text = "Place your bet by clicking the bet button under each player";
            ResetInterface();

            highest = 0;
            winner = 0;
            deck = new Deck();
            for (int i = 0; i < 4; i++)
            {
                player[i].Reset();

                for (int j = 1; j <= 5; j++)
                {
                    listView1.Items[i].SubItems[j].Text = "";
                }
            }
        }

        private void Deal_button_Click(object sender, EventArgs e)
        {
            DealCards();
            Deal_button.Enabled = false;
            EnabledInterface();
        }

        private void Final_button_Click(object sender, EventArgs e)
        {
            int score = 0;
            int[] scores = new int[4];
            bool flag = true;
            int row = 0;

            highest = 0;
            isDraw = false;

            scores[0] = player[0].GetTotal();
            scores[1] = player[1].GetTotal();
            scores[2] = player[2].GetTotal();
            scores[3] = player[3].GetTotal();

            //test if two or more players have the same total or score
            for (int l = 0; l < scores.Length; l++)
            {
                score = player[l].GetTotal();
                var x = scores.Count(n => n == score);
                if (x > 1)
                {
                    //If yes then its a draw, no one wins
                    isDraw = true;
                    break;
                }
            }

            if (!isDraw)
            {
                do
                {
                    highest = scores.Max();
                    if (highest > 21)
                    {

                        int j = Array.IndexOf(scores, scores.Max());
                        scores[j] = 0;
                    }
                    else
                    {
                        //Get the element or index of the highest score --> (the player) 
                        row = Array.IndexOf(scores, scores.Max());
                        flag = false;
                    }
                } while (flag);

                //Set the winning player
                player[row].IsWinner = true;
                winner = row + 1; //array is base 0. need to add 1 to align with the player's bet

                //test is the player's bet is correct
                if ((winner) == yourbet)
                {
                    Status_label.Text = $"Player  {winner} won you are right";
                }
                else
                {
                    Status_label.Text = $"Player  {winner} won you are wrong";
                }
            }
            else
            {
                Status_label.Text = "Its a draw. No one wins.";
            }

            //Display the cards, total, and status on the list view
            for (int i = 0; i < 4; i++)
            {
                listView1.Items[i].SubItems[1].Text = player[i].GetCard(0);
                listView1.Items[i].SubItems[2].Text = player[i].GetCard(1);
                listView1.Items[i].SubItems[3].Text = player[i].GetCard(2);
                listView1.Items[i].SubItems[4].Text = player[i].GetTotal().ToString();

                if (!isDraw)
                {

                    if (player[i].IsWinner)
                    {
                        listView1.Items[i].SubItems[5].Text = "Winner";
                    }
                    else
                    {
                        listView1.Items[i].SubItems[5].Text = "lose";
                    }
                }

            }

            ResetInterface();
            Reset_button.Enabled = true;
        }

        public void DealCards()
        {
            string card = "";
            int cardval = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j <= 2; j++)
                {
                    card = deck.DrawCard();
                    cardval = deck.GetCardValue();
                    player[i].AddCard(card, cardval);                    
                }
            }
        }

        private void YourBet(int i)
        {
            yourbet = i;
            FormattableString msg = $"You bet on Player {i}";
            Results_label.Text = msg.ToString();
            MessageBox.Show(msg.ToString());

        }

        private void ResetInterface()
        {
            MC_button1.Enabled = false;
            MC_button2.Enabled = false;
            MC_button3.Enabled = false;
            MC_button4.Enabled = false;

            Bet_button1.Enabled = false;
            Bet_button2.Enabled = false;
            Bet_button3.Enabled = false;
            Bet_button4.Enabled = false;

            Reset_button.Enabled = false;
            Final_button.Enabled = false;

        }

        private void EnabledInterface()
        {
            MC_button1.Enabled = true;
            MC_button2.Enabled = true;
            MC_button3.Enabled = true;
            MC_button4.Enabled = true;

            Bet_button1.Enabled = true;
            Bet_button2.Enabled = true;
            Bet_button3.Enabled = true;
            Bet_button4.Enabled = true;

            Reset_button.Enabled = true;
            Final_button.Enabled = true;
        }

        private void Results_label_Click(object sender, EventArgs e)
        {

        }
    }
}
