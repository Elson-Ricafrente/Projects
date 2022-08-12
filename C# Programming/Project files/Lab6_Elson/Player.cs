﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Elson
{
    class Player
    {
        private string[] cards = new string[3];
        private int[] cardValue = new int[3];
        private bool isWinner = false;
        private int cardsTotal = 0;
        int x = 0;

        public void AddCard(string card, int cardval)
        {
            cards[x] = card;

            cardValue[x] = cardval;

            cardsTotal = cardsTotal + cardval;

            x++;
        }

        public bool IsWinner
        {
            get
            {
                return isWinner;
            }
            set
            {
                isWinner = value;
            }
        }
        public string GetCard(int row)
        {
            string card = cards[row];

            return card;
        }

        public int GetTotal()
        {
            return cardsTotal;
        }

        public void Reset()
        {
            cardsTotal = 0;
            x = 0;
            cards = new string[3];
            cardValue = new int[3];
            isWinner = false;
        }
    }
}
