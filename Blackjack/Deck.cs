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
         }
         public string ReturnCard(int card)
         {
             return deck_Of_Cards[card];
         }
    }
}
