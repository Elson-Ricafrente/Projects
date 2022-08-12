using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Elson
{
    class Deck
    {
        protected string[] deckCards = new string[52] {
            "Hearts-1",  "Hearts-2", "Hearts-3", "Hearts-4", "Hearts-5",  "Hearts-6", "Hearts-7",
             "Hearts-8","Hearts-9", "Hearts-10", "Hearts-11", "Hearts-12", "Hearts-13",
            "Spades-1", "Spades-2", "Spades-3", "Spades-4","Spades-5",  "Spades-6", "Spades-7",
              "Spades-8", "Spades-9",  "Spades-10", "Spades-11", "Spades-12", "Spades-13",
            "Diamonds-1", "Diamonds-2", "Diamonds-3", "Diamonds-4", "Diamonds-5", "Diamonds-6",
             "Diamonds-7", "Diamonds-8","Diamonds-9",  "Diamonds-10", "Diamonds-11",
             "Diamonds-12", "Diamonds-13",
            "Clubs-1",  "Clubs-2", "Clubs-3", "Clubs-4", "Clubs-5",  "Clubs-6", "Clubs-7", "Clubs-8",
              "Clubs-9",  "Clubs-10", "Clubs-11", "Clubs-12", "Clubs-13" };

        private string[] discarded = new string[52];
        private int discardCtr = 0;
        private Random rand = new Random();
        private int cardValue = 0;

        public string DrawCard()
        {

            int row = rand.Next(0, 52);
            string card = deckCards[row];
            bool flag = false;

            do
            {
                if (!discarded.Contains(card))
                {
                    discarded[discardCtr] = card;
                    flag = true;
                    discardCtr++;
                }
                else
                {
                    row = rand.Next(0, 52);
                    card = deckCards[row];
                }
            } while (!flag);

            SetCardValue(card);
            return card;
        }

        public int GetCardValue()
        {
            return cardValue;
        }

        private void SetCardValue(string card)
        {
            int num = Array.IndexOf(deckCards, card);
            num += 1;

            if (num >= 1 && num <= 13) //suit of hearts
            {
                cardValue = num;
            }
            else if (num >= 14 && num <= 26) //suit of spades
            {
                cardValue = num - 13;
            }
            else if (num >= 27 && num <= 39) //suit of diamonds
            {
                cardValue = num - 26;
            }
            else if (num >= 40 && num <= 52)//suit of clubs
            {
                cardValue = num - 39;
            }
        }
    }
}
