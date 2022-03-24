using PiramidSolitaire.Cards;
using PiramidSolitaire.DeckSpace;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiramidSolitaire.Piramid
{
    //Extension class
    public static class IOPiramidCards
    {

        public static void setCard(this PiramidCards piramidCards, Card card, int row, int colum)
        {
            piramidCards.piramideCards[row][colum] = card;
        }

        public static Card getCard(this PiramidCards piramidCards, int row, int colum)
        {
            return piramidCards.piramideCards[row][colum];
        }

        /// <summary>
        /// Push first 28 cards from deck to piramid. This card in deck became equal null
        /// </summary>
        /// <param name="piramidCards"></param>
        /// <param name="deck"></param>
        public static void Fill(this PiramidCards piramidCards, Deck deck)
        {
            int counter = 0;
            for (int y = 0; y <= piramidCards.piramideCards.Length-1; y++)
            {
                for (int x = 0; x <= y; x++)
                {
                    Card card = new Card();
                    card = deck.getCard(counter);
                    deck.setCard(counter, null);

                    piramidCards.setCard(card, y, x);
                    counter++;
                }

            }

        }
    }
}
