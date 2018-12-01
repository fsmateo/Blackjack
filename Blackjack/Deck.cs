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
         private int cardVal = 0;
         private Stack<string> deck = new Stack<string>();

         public Deck()
         {
             int count = 0;
             // T is 10, J is Jack, and so on.
             char[] faces = {'A', '2', '3', '4',  '5',
                               '6', '7', '8', '9', 'T',
                               'J', 'Q', 'K'};

             //suits: Clubs, Diamonds, Hearts, Spades
             char[] suits = { 'C', 'D', 'H', 'S' };

             for (int face = 0; face < num_Faces; face++)
             {
                 for (int suit = 0; suit < num_Suits; suit++, count++)
                 {
                    char[] temp = { faces[face], '_', suits[suit] };
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
        /// <summary>
        /// Checks the remaining number of cards in the deck.
        /// </summary>
        public void CardsInStack()
        {
            Console.WriteLine(deck.Count());
        }
        /// <summary>
        /// dealt_Card value is determined via case statements
        /// and the determined value is returned as type int.
        /// </summary>
        /// <param name="dealt_Card"></param>
        /// <returns></returns>
        public int Card_Value(string dealt_Card)
        {

            // TODO: Figure out how to add logic for Ace value
            switch (dealt_Card)
            {
                case "2_C":
                case "2_D":
                case "2_H":
                case "2_S":
                    cardVal = 2;
                    break;
                case "3_C":
                case "3_D":
                case "3_H":
                case "3_S":
                    cardVal = 3;
                    break;
                case "4_C":
                case "4_D":
                case "4_H":
                case "4_S":
                    cardVal = 4;
                    break;
                case "5_C":
                case "5_D":
                case "5_H":
                case "5_S":
                    cardVal = 5;
                    break;
                case "6_C":
                case "6_D":
                case "6_H":
                case "6_S":
                    cardVal = 6;
                    break;
                case "7_C":
                case "7_D":
                case "7_H":
                case "7_S":
                    cardVal = 7;
                    break;
                case "8_C":
                case "8_D":
                case "8_H":
                case "8_S":
                    cardVal = 8;
                    break;
                case "9_C":
                case "9_D":
                case "9_H":
                case "9_S":
                    cardVal = 9;
                    break;
                case "T_C":
                case "T_D":
                case "T_H":
                case "T_S":
                case "J_C":
                case "J_D":
                case "J_H":
                case "J_S":
                case "Q_C":
                case "Q_D":
                case "Q_H":
                case "Q_S":
                case "K_C":
                case "K_D":
                case "K_H":
                case "K_S":
                    cardVal = 10;
                    break;
            }
            return cardVal;
        }
    }
}
