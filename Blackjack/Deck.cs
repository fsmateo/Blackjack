using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Deck
    {
         private string[] deck_Of_Cards;
         private const int num_Faces = 13;
         private const int num_Suits = 4;
         private const int num_Cards = 52;
         private int cardVal = 0;
         private Stack<string> stack_Deck = new Stack<string>();

         public Deck()
         {
             string[] the_Deck = new string[num_Cards];
             deck_Of_Cards = the_Deck;
             int count = 0;
             string[] faces = {"Ace", "2", "3", "4",  "5",
                               "6", "7", "8", "9", "10",
                               "Jack", "Queen", "King"};

             //suits: Clubs, Diamonds, Hearts, Spades
             string[] suits = { "C", "D", "H", "S" };

             for (int face = 0; face < num_Faces; face++)
             {
                 for (int suit = 0; suit < num_Suits; suit++, count++)
                 {
                     the_Deck[count] = faces[face] + "_" + suits[suit];
                 }
             }
         }

         //Reference: https://bit.ly/2OVo1G9
         public static void Shuffle<T>(T[] deck_Of_Cards)
         {
             Random rand = new Random();
              //For each spot in the array, pick
              //a random item to swap into that spot.
             for (int i = 0; i < deck_Of_Cards.Length - 1; i++)
             {
                 int j = rand.Next(i, deck_Of_Cards.Length);
                 T temp = deck_Of_Cards[i];
                 deck_Of_Cards[i] = deck_Of_Cards[j];
                 deck_Of_Cards[j] = temp;
             }
         }

         public void Shuffle_Deck()
         {
             Shuffle(deck_Of_Cards);
            Stack_Deck();
         }
        /// <summary>
        /// Stacks the deck of cards.
        /// </summary>
        public void Stack_Deck()
        {
            for (int i = 0; i < num_Cards; i++)
            {
                stack_Deck.Push(deck_Of_Cards[i]);
            }
        }
        /// <summary>
        /// Deals a card from the top of the Stack.
        /// </summary>
        /// <returns></returns>
        public string Deal_Card()
        {
            string top_Card = "";
            top_Card = stack_Deck.Pop();
            return top_Card;
        }
        /// <summary>
        /// Checks the remaining number of cards in the deck.
        /// </summary>
        public void CardsInStack()
        {
            Console.WriteLine(stack_Deck.Count());
        }
        /// <summary>
        /// dealt_Card value is determined via case statements
        /// and the determined value is returned as type int.
        /// </summary>
        /// <param name="dealt_Card"></param>
        /// <returns></returns>
        public int Card_Value(string dealt_Card)
        {
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
                case "10_C":
                case "10_D":
                case "10_H":
                case "10_S":
                case "Jack_C":
                case "Jack_D":
                case "Jack_H":
                case "Jack_S":
                case "Queen_C":
                case "Queen_D":
                case "Queen_H":
                case "Queen_S":
                case "King_C":
                case "King_D":
                case "King_H":
                case "King_S":
                    cardVal = 10;
                    break;
            }
            return cardVal;
        }
    }
}
