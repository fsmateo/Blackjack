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
        private int handValue { get; set; }


        /// <summary>
        /// This is a hellper method which will recur everytime a card is dealt to check for a 
        /// busted state, then it will trigger an event to signal this event
        /// </summary>
        private void checkBusted()
        {
            if (handValue > 21) { }
            //TODO: trigger event on GamePage to signify a busted hand
        }
    }
}
