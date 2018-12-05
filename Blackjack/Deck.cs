using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Deck
    {
         private const int num_Faces = 13; 
         private const int num_Suits = 4;
         private const int num_Cards = 52;
         private Stack<string> deck = new Stack<string>();

         public Deck()
         {
             int count = 0;
             // T is 10, J is Jack, and so on.
             char[] faces = { 'A', '2', '3', '4',  '5',
                              '6', '7', '8', '9', 'T',
                              'J', 'Q', 'K' };

             //suits: Clubs, Diamonds, Hearts, Spades
             char[] suits = { 'C', 'D', 'H', 'S' };

             for (int face = 0; face < num_Faces; face++)
             {
                 for (int suit = 0; suit < num_Suits; suit++, count++)
                 {
                    char[] temp = {'A', 's', 's', 'e', 't', 's', '/', faces[face], '_', suits[suit], '.', 'p', 'n', 'g' };
                    string card = new string(temp);
                    deck.Push(card);
                 }
             }
         }

         //Reference: https://bit.ly/2OVo1G9
         public static void Shuffle<T>(Stack<T> deck_Of_Cards)
         {
            var tempArray = deck_Of_Cards.ToArray();
            deck_Of_Cards.Clear();
            Random rand = new Random();
            //For each spot in the array, 
            //a random item to swap into that spot
            int i;
            for (i = 0; i < 52; i++)
            {
                int j = rand.Next(i, 52);
                T temp = tempArray[i];
                tempArray[i] = tempArray[j];
                tempArray[j] = temp;
            }
            for (i = 0; i < 52; ++i)
            {
                deck_Of_Cards.Push(tempArray[i]);
            }
         }

         public void Shuffle_Deck()
         {
             Shuffle(deck);
         }

        /// <summary>
        /// Deals a card from the top of the Stack.
        /// </summary>
        /// <returns></returns>
        public string Deal_Card()
        {
            string top_Card = "";
            top_Card = deck.Pop();
            return top_Card;
        }

        public string Skip_Card()
        {
            return "0";
        }

        /// <summary>
        /// Checks the remaining number of cards in the deck.
        /// </summary>
        public int CardsInStack()
        {
            return deck.Count();
        }
        
    }
}
