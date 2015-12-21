using System.Collections.Generic;
using PokerHands.cs.Entities;

namespace PokerHands.cs.PokerHandProviders
{
    public class HighCardProvider : PokerHandProviderBase, IPokerHandProvider
    {
        public bool HasPokerHand(IEnumerable<Card> hand)
        {
            return true;
        }
    }
}
