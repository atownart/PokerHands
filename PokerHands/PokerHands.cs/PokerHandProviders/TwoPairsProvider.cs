using System.Collections.Generic;
using System.Linq;
using PokerHands.cs.Entities;

namespace PokerHands.cs.PokerHandProviders
{
    public class TwoPairsProvider: PokerHandProviderBase, IPokerHandProvider
    {
        public bool HasPokerHand(IEnumerable<Card> cards)
        {
            var pairCount = 0;
            cards.GroupBy(c => c.Value).ToList().ForEach(c =>
            {
                if (cards.Count(card => card.Value == c.Key) == 2)
                {
                    pairCount += 1;
                }
            });
            return pairCount == 2;
        }
    }
}
