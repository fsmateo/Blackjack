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
        public int NumPlayers { get; set; }

        List<string> playerHand = new List<string>();
        List<string> dealerHand = new List<string>();
        Deck newDeck = new Deck();

        public Blackjack()
        {
            NumPlayers = 2; // Dealer and human player
            // create new deck object first
            
            newDeck.Shuffle_Deck();

            playerHand.Add(newDeck.Deal_Card());
            dealerHand.Add(newDeck.Deal_Card());
            playerHand.Add(newDeck.Deal_Card());
            dealerHand.Add(newDeck.Deal_Card());

            foreach (string s in playerHand)
                System.Diagnostics.Debug.WriteLine(s);
            foreach (string s in dealerHand)
                System.Diagnostics.Debug.WriteLine(s);
        }

    }
}
