using PiramidSolitaire.Cards;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiramidSolitaire.Cards
{
    public enum suitVar
    {
        Hearts,
        Diamonds,
        Clubs,
        Spades,
    }

    public class Card 
    {

        public suitVar Suit { get; set; }   
        public int Value { get; set; }

    }
}
