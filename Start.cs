using PiramidSolitaire.Cards;
using PiramidSolitaire.DeckSpace;
using PiramidSolitaire.Piramid;
using PiramidSolitaire.GameLogic;
using System;
using System.Text;

namespace PiramidSolitaire
{
    class Start
    {
                   
        static void Main(string[] args)
        {
            Console.SetWindowSize(150,40);
            Console.OutputEncoding = Encoding.UTF8;


            Deck deck = new Deck();   // Create deck
            PiramidCards piramidCards = new PiramidCards();  //create piramide cards

            deck.ShuffleDeck(); //shuffle deck

            piramidCards.Fill(deck); // put first 28 cards into piramide

            SelectedCouple selectedCouple = new();

            int counter = 28;

           
            PrintGameConsole.PrintGame(piramidCards, deck.getCard(counter)); //print first screen

            Card card111 = new();
            ref Card reFirstC = ref card111;

         
            while (piramidCards.piramideCards[0][0]!=null)
            {
                byte button = MainController.ClickButton();

                switch (button)
                {
                    case 0://Add card from deck to sum with second card
                        selectedCouple.Add(deck.getCard(counter)) ;  // Add card to compare
                        if (selectedCouple.Check())  // if we added card and complete, delete this card from deck and piramid
                        {                      
                            deck.setCard(counter, null);
                            reFirstC = null;
                        }
                        else  // if no remembered ref on this card 
                        {
                            reFirstC =ref deck.getRefCard(counter);
                        }
           
                        break;
                    case 1:
                        (int row1, int colomn1) = piramidCards.GetAvailableCard(1);
                            if (row1 >= 0 && colomn1 >= 0)
                            {
                                selectedCouple.Add(piramidCards.getCard(row1, colomn1));
                                if (selectedCouple.Check())  // if we added card and complete, delete this card from deck and piramid
                                {
                                    piramidCards.setCard(null, row1, colomn1);
                                    reFirstC = null;

                                }
                                else  // if no remembered ref on this card 
                                {
                                    reFirstC =ref piramidCards.getRefCard(row1, colomn1);
                                }
                            }
                        break;
                    case 2:
                        (int row2, int colomn2) = piramidCards.GetAvailableCard(2);
                        if (row2 >= 0 && colomn2 >= 0)
                        {
                            selectedCouple.Add(piramidCards.getCard(row2, colomn2));
                            if (selectedCouple.Check())  // if we added card and complete, delete this card from deck and piramid
                            {
                                piramidCards.setCard(null, row2, colomn2);
                                reFirstC = null;

                            }
                            else  // if no remembered ref on this card 
                            {
                                reFirstC = ref piramidCards.getRefCard(row2, colomn2);
                            }
                        }
                        break;
                    case 3:
                        (int row3, int colomn3) = piramidCards.GetAvailableCard(3);
                        if (row3 >= 0 && colomn3 >= 0)
                        {
                            selectedCouple.Add(piramidCards.getCard(row3, colomn3));
                            if (selectedCouple.Check())  // if we added card and complete, delete this card from deck and piramid
                            {
                                piramidCards.setCard(null, row3, colomn3);
                                reFirstC = null;

                            }
                            else  // if no remembered ref on this card 
                            {
                                reFirstC = ref piramidCards.getRefCard(row3, colomn3);
                            }
                        }
                        break;
                    case 4:
                        (int row4, int colomn4) = piramidCards.GetAvailableCard(4);
                        if (row4 >= 0 && colomn4 >= 0)
                        {
                            selectedCouple.Add(piramidCards.getCard(row4, colomn4));
                            if (selectedCouple.Check())  // if we added card and complete, delete this card from deck and piramid
                            {
                                piramidCards.setCard(null, row4, colomn4);
                                reFirstC = null;

                            }
                            else  // if no remembered ref on this card 
                            {
                                reFirstC = ref piramidCards.getRefCard(row4, colomn4);
                            }
                        }
                        break;
                    case 5:
                        (int row5, int colomn5) = piramidCards.GetAvailableCard(5);
                        if (row5 >= 0 && colomn5 >= 0)
                        {
                            selectedCouple.Add(piramidCards.getCard(row5, colomn5));
                            if (selectedCouple.Check())  // if we added card and complete, delete this card from deck and piramid
                            {
                                piramidCards.setCard(null, row5, colomn5);
                                reFirstC = null;

                            }
                            else  // if no remembered ref on this card 
                            {
                                reFirstC = ref piramidCards.getRefCard(row5, colomn5);
                            }
                        }
                        break;
                    case 6:
                        (int row6, int colomn6) = piramidCards.GetAvailableCard(6);
                        if (row6 >= 0 && colomn6 >= 0)
                        {
                            selectedCouple.Add(piramidCards.getCard(row6, colomn6));
                            if (selectedCouple.Check())  // if we added card and complete, delete this card from deck and piramid
                            {
                                piramidCards.setCard(null, row6, colomn6);
                                reFirstC = null;

                            }
                            else  // if no remembered ref on this card 
                            {
                                reFirstC = ref piramidCards.getRefCard(row6, colomn6);
                            }
                        }
                        break;
                    case 7:
                        (int row7, int colomn7) = piramidCards.GetAvailableCard(7);
                        if (row7 >= 0 && colomn7 >= 0)
                        {
                            selectedCouple.Add(piramidCards.getCard(row7, colomn7));
                            if (selectedCouple.Check())  // if we added card and complete, delete this card from deck and piramid
                            {
                                piramidCards.setCard(null, row7, colomn7);
                                reFirstC = null;

                            }
                            else  // if no remembered ref on this card 
                            {
                                reFirstC = ref piramidCards.getRefCard(row7, colomn7);
                            }
                        }
                        break;
                    case 8: //another card
                        if (counter == 51) {counter = 28; }  //end deck              
                        else { counter++; }
                        while (deck.getCard(counter)==null)
                        {
                            if (counter == 51) { counter = 28; }
                            counter++;
                        }
                        break;
                    default:
                        break;
                }

                if (counter == 51) { counter = 28; }  //end deck              
                while (deck.getCard(counter) == null)
                {
                    if (counter == 51) { counter = 28; }
                    counter++;
                }
                Console.Clear();
                PrintGameConsole.PrintGame(piramidCards, deck.getCard(counter)); //print first screen
                    
            }


            Console.Clear();
            Console.WriteLine("ʕ ᵔᴥᵔ ʔ <You are win!!!");
        }
    }
}
