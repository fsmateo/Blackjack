using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Player
    {
        private int playerHandValue = 0;
        private List<string> playerHand = new List<string>();

        //Explicit public constructor
        public Player() { }

        public void PlayerHandValue(int value)
        {
            playerHandValue += value;
        }

        public void PlayerHand(string card)
        {
            playerHand.Add(card);
        }

        public void Cards()
        {
            foreach (string s in playerHand)
            {
                Console.WriteLine(s);
            }
        }

        public void Total_Value()
        {
            Console.WriteLine($"Total value of cards: {playerHandValue}");
        }
    }
}
