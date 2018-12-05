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
        public List<string> playerHand = new List<string>();
        List<string> dealerHand = new List<string>();
        Deck newDeck = new Deck();
        bool hit;
        bool stand;
        bool doubleDown;
        public bool busted;    // Variable will be set when playerHand > 21, only UI class will reset this variable.

        //TODO: Initialize an array of objects to represent the player's hand (including the dealer)
        //Player players = new Player();
        List<Player> players = new List<Player>();

        /// <summary>
        /// 
        /// </summary>
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

            // Add their values
            playerHandValue += Card_Value(playerHand[0]);
            playerHandValue += Card_Value(playerHand[1]);
            dealerHandValue += Card_Value(dealerHand[0]);
            dealerHandValue += Card_Value(dealerHand[1]);

            // This logic is unnecessary as the Hit and Stand methods will be called from GamePage.xaml.cs
            // and do not need to be called in the constructor for this class (Brandon)
            //// ToDO: need to program buttons for the UI team to send a true when the user hits the button
            //if (hit == true)
            //{
            //    Hit();
            //}

            //if (stand == true)
            //{
            //    Stand();
            //}

            //if (doubleDown == true)
            //{
            //    DoubleDown();
            //}

        }

        /// <summary>
        /// Explicit value constructor for more than two players
        /// </summary>
        /// <param name="playerCount"></param>
        public Blackjack(int playerCount)
        {
            NumPlayers = playerCount;
            Player[] player = new Player[NumPlayers];
            for (int i = 0; i < NumPlayers; i++)
            {
                player[i] = new Player();
                players.Add(player[i]);
            }

            newDeck.Shuffle_Deck();

            // TODO create a loop which will deal hands to multiple players

        }

        public void Hit()
        {
            // Create string with card from the deck and add its value.
            string cardToAdd = newDeck.Deal_Card();
            playerHand.Add(cardToAdd);
            playerHandValue += Card_Value(cardToAdd);
            // Check for bust, but only set the flag so that the UI can update before hand is reset.
            if (playerHandValue > 21)
            {
                busted = true;
            }

        }

        public void Stand()
        {
            // skip the turn, hence returns nothing
            playerHand.Add(newDeck.Skip_Card());


            System.Diagnostics.Debug.WriteLine("Player Hand: ");
            foreach (string s in playerHand)
            {
                System.Diagnostics.Debug.WriteLine(s);
            }
            System.Diagnostics.Debug.WriteLine($"Player Hand Value = {playerHandValue}");

        }

        public int DoubleDown()
        {
            throw new NotImplementedException();
        }

        public int Split()
        {
            throw new NotImplementedException();
        }

        public int Surrender()
        {
            throw new NotImplementedException();
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
                    return 2;
                    
                case "Assets/3_C.png":
                case "Assets/3_D.png":
                case "Assets/3_H.png":
                case "Assets/3_S.png":
                    return 3;
                    
                case "Assets/4_C.png":
                case "Assets/4_D.png":
                case "Assets/4_H.png":
                case "Assets/4_S.png":
                    return 4;
                    
                case "Assets/5_C.png":
                case "Assets/5_D.png":
                case "Assets/5_H.png":
                case "Assets/5_S.png":
                    return 5;
                    
                case "Assets/6_C.png":
                case "Assets/6_D.png":
                case "Assets/6_H.png":
                case "Assets/6_S.png":
                    return 6;
                    
                case "Assets/7_C.png":
                case "Assets/7_D.png":
                case "Assets/7_H.png":
                case "Assets/7_S.png":
                    return 7;
                    
                case "Assets/8_C.png":
                case "Assets/8_D.png":
                case "Assets/8_H.png":
                case "Assets/8_S.png":
                    return 8;
                    
                case "Assets/9_C.png":
                case "Assets/9_D.png":
                case "Assets/9_H.png":
                case "Assets/9_S.png":
                    return 9;
                    
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
                    return 10;

                case "Assets/A_C.png":
                case "Assets/A_D.png":
                case "Assets/A_H.png":
                case "Assets/A_S.png":
                    if (playerHandValue > 10)
                        return 1;
                    else
                        return 11;

                default:
                    return 0;
            }
        }

        /// <summary>
        /// Copy of the contructor for creating a new game, although this method will not shuffle the deck
        /// until there no cards remaining
        /// </summary>
        public void NextRound()
        {
            if (newDeck.CardsInStack() < 10)
                newDeck.Shuffle_Deck();
            
            // Reset cards in hand and value of hands.
            playerHand.Clear();
            dealerHand.Clear();
            playerHandValue = 0;
            dealerHandValue = 0;

            // Deal the cards to the player and the dealer
            playerHand.Add(newDeck.Deal_Card());
            dealerHand.Add(newDeck.Deal_Card());
            playerHand.Add(newDeck.Deal_Card());
            dealerHand.Add(newDeck.Deal_Card());
            // Add their values
            playerHandValue += Card_Value(playerHand[0]);
            playerHandValue += Card_Value(playerHand[1]);
            dealerHandValue += Card_Value(dealerHand[0]);
            dealerHandValue += Card_Value(dealerHand[1]);

            busted = false;  // Reset busted flag.
        }

    }
}
