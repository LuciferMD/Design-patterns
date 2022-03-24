using PiramidSolitaire.Cards;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiramidSolitaire.DeckSpace
{
    //Extension class
    public static class FisherYatesShuffle
    {   
        public static void ShuffleDeck(this Deck deck)
        {
            Random random = new Random();

            for (int n = deck.Length-1 ; n > 0; --n)
            {
                int k = random.Next(n + 1);
                Card temp = deck.getCard(n);
                deck.setCard(n,deck.getCard(k));
                deck.setCard(k,temp);
            }
        }
    }
}
