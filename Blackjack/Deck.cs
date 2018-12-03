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
        /// <summary>
        /// Checks the remaining number of cards in the deck.
        /// </summary>
        public int CardsInStack()
        {
            return deck.Count();
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
                case "Assets/2_C.png":
                case "Assets/2_D.png":
                case "Assets/2_H.png":
                case "Assets/2_S.png":
                    cardVal = 2;
                    break;
                case "Assets/3_C.png":
                case "Assets/3_D.png":
                case "Assets/3_H.png":
                case "Assets/3_S.png":
                    cardVal = 3;
                    break;
                case "Assets/4_C.png":
                case "Assets/4_D.png":
                case "Assets/4_H.png":
                case "Assets/4_S.png":
                    cardVal = 4;
                    break;
                case "Assets/5_C.png":
                case "Assets/5_D.png":
                case "Assets/5_H.png":
                case "Assets/5_S.png":
                    cardVal = 5;
                    break;
                case "Assets/6_C.png":
                case "Assets/6_D.png":
                case "Assets/6_H.png":
                case "Assets/6_S.png":
                    cardVal = 6;
                    break;
                case "Assets/7_C.png":
                case "Assets/7_D.png":
                case "Assets/7_H.png":
                case "Assets/7_S.png":
                    cardVal = 7;
                    break;
                case "Assets/8_C.png":
                case "Assets/8_D.png":
                case "Assets/8_H.png":
                case "Assets/8_S.png":
                    cardVal = 8;
                    break;
                case "Assets/9_C.png":
                case "Assets/9_D.png":
                case "Assets/9_H.png":
                case "Assets/9_S.png":
                    cardVal = 9;
                    break;
                case "Assets/T_C.png":
                case "Assets/T_D.png":
                case "Assets/T_H.png":
                case "Assets/T_S.png":
                case "Assets/J_C.png":
                case "Assets/J_D.png":
                case "Assets/J_H.png":
                case "Assets/J_S.png":
                case "Assets/Q_C.png":
                case "Assets/Q_D.png":
                case "Assets/Q_H.png":
                case "Assets/Q_S.png":
                case "Assets/K_C.png":
                case "Assets/K_D.png":
                case "Assets/K_H.png":
                case "Assets/K_S.png":
                    cardVal = 10;
                    break;
                case "Assets/A_C.png":
                case "Assets/A_D.png":
                case "Assets/A_H.png":
                case "Assets/A_S.png":
                    cardVal = 11;
                    break;
            }
            return cardVal;
        }
    }
}
