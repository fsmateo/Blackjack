using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    /// <summary>
    /// This class will hold cards as they are dealt out in sequence from the Deck.
    /// 
    /// </summary>
    class Hand : Deck
    {
        private int HandValue { get; set; }

        /// <summary>
        /// Default constructor will deal two cards 
        /// </summary>
        public Hand()
        {

        }
        /// <summary>
        /// This is a helper method which will recur everytime a card is dealt to check for a 
        /// busted state, then it will trigger an event to signal this event
        /// </summary>
        private void CheckBusted()
        {
            if (HandValue > 21) { }
            //TODO: trigger event on GamePage to signify a busted hand
        }
    }
}
