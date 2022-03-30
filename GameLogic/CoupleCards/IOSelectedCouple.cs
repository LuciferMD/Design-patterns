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
        
        public static void Add(this SelectedCouple selectedCouple, Card card)
        {
            if (selectedCouple.FirstCard is null)
            {
                selectedCouple.FirstCard = card;
            }
            else if (selectedCouple.SecondCard is null)
            {
                selectedCouple.SecondCard = card;
            }
            else     //IF two cards already choosen. We clean this couple cards AND choose new card
            {
                selectedCouple.FirstCard = card;   
                selectedCouple.SecondCard = null;
            }
        }     

        public static void Clear(this SelectedCouple selectedCouple)
        {
            selectedCouple.FirstCard = null;
            selectedCouple.SecondCard = null;
        }
        
        public static bool Check(this SelectedCouple selectedCouple)
        {
            int firstValue = selectedCouple?.FirstCard?.getValue() ?? 0;  // if there isn't card, value =0
            int secondValue = selectedCouple?.SecondCard?.getValue() ?? 0;

            if ((firstValue + secondValue) == 13) //if we match card, we delete them
            {
                selectedCouple.Clear();
                return true;
            }
            else if (firstValue != 0 && secondValue != 0)//if we don't match card but thew two, we delete them
            {
                selectedCouple.Clear();
                return false;
            }
            else return false;
        }

       
    }
}
