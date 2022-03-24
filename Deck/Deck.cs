using PiramidSolitaire.Cards;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiramidSolitaire.DeckSpace
{
    public class Deck
    {
        internal Card[] cards = new Card[52];
        internal int Length = 52;
        public Deck()
        {
            int[] deckValue = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            int i = 0;
            

            foreach (int s in deckValue)
            {
                Card card = new Card();
                card.set(s, suitVar.Clubs);
                cards[i] = card;
                i++;
                
            }
            foreach (int s in deckValue)
            {

                Card card = new Card();
                card.set(s, suitVar.Diamonds);
                cards[i] = card;
                i++;
            }
            foreach (int s in deckValue)
            {
                Card card = new Card();
                card.set(s, suitVar.Hearts);
                cards[i] = card;
                i++;

            }
            foreach (int s in deckValue)
            {
                Card card = new Card();
                card.set(s, suitVar.Spades);
                cards[i] = card;
                i++;

            }
        }
    }
}
