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
        public int playerHandValue { get; set; }
        private int dealerHandValue { get; set; }
        List<string> playerHand = new List<string>();
        List<string> dealerHand = new List<string>();
        Deck newDeck = new Deck();
        

        public Blackjack()
        {
            NumPlayers = 2; // Dealer and human player
            // create new deck object first            
            // Shuffle the deck and generate the stack
            newDeck.Shuffle_Deck();

            // Deal the cards to the player and the dealer
            playerHand.Add(newDeck.Deal_Card());
            dealerHand.Add(newDeck.Deal_Card());
            playerHand.Add(newDeck.Deal_Card());
            dealerHand.Add(newDeck.Deal_Card());

            // Print the Hands out

            System.Diagnostics.Debug.WriteLine("Player Hand: ");
            foreach (string s in playerHand)
            {
                System.Diagnostics.Debug.WriteLine(s);
                playerHandValue += newDeck.Card_Value(s);
            }
            System.Diagnostics.Debug.WriteLine($"Player Hand Value =  {playerHandValue}");

            System.Diagnostics.Debug.WriteLine("Dealer Hand: ");
            foreach (string s in dealerHand)
            {
                System.Diagnostics.Debug.WriteLine(s);
                dealerHandValue += newDeck.Card_Value(s);
            }
            System.Diagnostics.Debug.WriteLine($"Dealer Hand Value =  {dealerHandValue}");

        }

        /// <summary>
        /// Explicit value constructor for more than two players
        /// </summary>
        /// <param name="playerCount"></param>
        public Blackjack(int playerCount)
        {
            NumPlayers = playerCount;
            newDeck.Shuffle_Deck();

            // TODO create a loop which will deal hands to multiple players
        }

        public void Hit()
        {
            playerHandValue = 0;
            playerHand.Add(newDeck.Deal_Card());

            // Print the Hands out
            System.Diagnostics.Debug.WriteLine("Player Hand: ");
            foreach (string s in playerHand)
            {
                System.Diagnostics.Debug.WriteLine(s);
                playerHandValue += newDeck.Card_Value(s);
            }
            System.Diagnostics.Debug.WriteLine($"Player Hand Value =  {playerHandValue}");
        }

        public int Stand()
        {

            throw new NotImplementedException();

        }

    }
}
