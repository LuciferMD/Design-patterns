using PiramidSolitaire.Cards;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiramidSolitaire.Piramid
{
    public class PiramidCards
    {
        public Card[][] piramideCards = new Card[7][];

        public Card[] availableCard = new Card[7]; // Available to choice
        public int Length { get;}
        public PiramidCards()
        {
            piramideCards[0] = new Card[1];
            piramideCards[1] = new Card[2];
            piramideCards[2] = new Card[3];
            piramideCards[3] = new Card[4];
            piramideCards[4] = new Card[5];
            piramideCards[5] = new Card[6];
            piramideCards[6] = new Card[7];

            Length = 7;
        }
    }
}
