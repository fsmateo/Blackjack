using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    /// <summary>
    /// This class will handle setting up the deck and managing the hands as well as the AI players
    /// </summary>
    class Blackjack
    {
        // TODO: Add methods and member variables needed to organize the card game aspect of the program
        // TODO: Integrate Hand, Deck, and AI classes into this class 
        public int numPlayers { get; set; }
        
        public Blackjack()
        {
            numPlayers = 2; // Dealer and human player
            // create new deck object first
            Deck newDeck = new Deck();
            newDeck.Shuffle_Deck();
            List<string> playerHand = new List<string>();
            List<string> dealerHand = new List<string>();

            playerHand.Add("Didnt work");

            foreach (string s in playerHand)
                System.Diagnostics.Debug.WriteLine(s);
        }

    }
}
