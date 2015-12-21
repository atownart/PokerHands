using System.Collections.Generic;
using PokerHands.cs.Entities;

namespace PokerHands.cs.PokerHandProviders
{
    public interface IPokerHandProvider
    { 
        bool HasPokerHand(IEnumerable<Card> cards);

    }
}
