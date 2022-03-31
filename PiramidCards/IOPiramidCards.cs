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

        public static ref Card getRefCard(this PiramidCards piramidCards, int row, int colum)
        {
            return ref piramidCards.piramideCards[row][colum];
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

            for (int i = 0; i <= piramidCards.piramideCards.Length-1; i++) 
            {
                piramidCards.availableCard[i] = piramidCards.piramideCards[6][i];
            }
            

        }

        public static (int,int) GetAvailableCard(this PiramidCards piramidCards, int number) //to do
        {
            number--;

            for (int y = piramidCards.Length-1; y >=0 ; y--)
            {
                if ((piramidCards.getCard(y, number) == null) && piramidCards.piramideCards[y].Length == number+1) //(null | end)
                {
                    return (-1, -1);
                }
                else if ((piramidCards.getCard(y, number) ==null)&&( piramidCards.getCard(y, number+1) != null)) // (card | null)
                {
                    return (-1, -1);
                }
                else if (piramidCards.getCard(y, number) != null) // (card | card)
                {
                    return (y, number);
                }

            }
            return (-1, -1);
        }
    }
}
