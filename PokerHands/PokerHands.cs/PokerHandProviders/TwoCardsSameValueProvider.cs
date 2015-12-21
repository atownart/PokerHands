using System.Collections.Generic;
using System.Linq;
using PokerHands.cs.Entities;

namespace PokerHands.cs.PokerHandProviders
{
    public class TwoCardsSameValueProvider : PokerHandProviderBase, IPokerHandProvider
    {
        public bool HasPokerHand(IEnumerable<Card> cards)
        {
            return CardsHaveContainsACertainAmountOfTheSameValue(cards,2);
        }
    }
}
