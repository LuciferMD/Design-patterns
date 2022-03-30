//using System;
using PiramidSolitaire.Cards;
using System.Collections.Generic;
using System.Text;

namespace PiramidSolitaire.DeckSpace
{
    //Extension class
    public static class IODeck
    {
        public static Card getCard(this Deck deck, int number)
        {
            return deck.cards[number];
        }
        public static void setCard(this Deck deck, int number, Card card)
        {
            deck.cards[number] = card;
        }

        public static ref Card getRefCard(this Deck deck, int number)
        {
            return ref deck.cards[number];
        }
    }
}
