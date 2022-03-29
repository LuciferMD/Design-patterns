using PiramidSolitaire.Cards;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiramidSolitaire.GameLogic
{
    //Extension class
    public static class IOSelectedCouple
    {
        /// <summary>
        /// Adds card for checking couple
        /// </summary>
        /// <param name="selectedCouple"></param>
        /// <param name="card"></param>
        public static void add(this SelectedCouple selectedCouple, Card card)
        {
            if (selectedCouple.FirstCard is null)
            {
                selectedCouple.FirstCard = card;
            }
            else if (selectedCouple.SecondCard is null)
            {
                selectedCouple.SecondCard = card;
            }
            else
                selectedCouple.check();
        }     
        
        public static bool check(this SelectedCouple selectedCouple)
        {
            if ((selectedCouple.FirstCard?.getValue() + selectedCouple.SecondCard?.getValue()) == 13)
            {
                return true;
            }
            else
                return false;
        }

       
    }
}
