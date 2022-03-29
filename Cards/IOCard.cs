using System;
using System.Collections.Generic;
using System.Text;

namespace PiramidSolitaire.Cards
{
    //Extension class
    public static class IOCard
    {
        /// <summary>
        /// Extension method for set card
        /// </summary>
        /// <param name="card"></param>
        /// <param name="value"></param>
        /// <param name="suit"></param>
        public static Card set(this Card card, int value, suitVar suit)
        {
            if (value >= 1 && value <= 13)
            {
                card.Value = value;
                card.Suit = suit;
            }
            else
            {
                throw new Exception("Unreal card");
            }

            return card;

        }

        public static int getValue(this Card card)
        {
            return card.Value;
        }

        


    }
}
