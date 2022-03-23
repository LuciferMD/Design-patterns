using PiramidSolitaire.Cards;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiramidSolitaire.Deck
{
    class Deck
    {
        Card[] cards = new Card[52];

        public Deck()
        {
            int[] deckValue = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            int i = 0;
            Card card = new Card();

            foreach (int s in deckValue)
            {
                cards[i] = card.set(s,suitVar.Clubs);
                i++;

            }
            foreach (int s in deckValue)
            {
                cards[i] = card.set(s, suitVar.Diamonds);
                i++;

            }
            foreach (int s in deckValue)
            {
                cards[i] = card.set(s, suitVar.Hearts);
                i++;

            }
            foreach (int s in deckValue)
            {
                cards[i] = card.set(s, suitVar.Spades);
                i++;

            }
        }
    }
}
