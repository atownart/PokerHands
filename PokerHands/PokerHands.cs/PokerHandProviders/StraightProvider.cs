using System.Collections.Generic;
using System.Linq;
using PokerHands.cs.Entities;

namespace PokerHands.cs.PokerHandProviders
{
    public class StraightProvider: PokerHandProviderBase , IPokerHandProvider
    {
        public bool HasPokerHand(IEnumerable<Card> cards)
        {
            var consecutive = true;
            var nextRank = 0;
            foreach (var c in cards.OrderBy(c => c.Rank))
            {
                if (nextRank == 0) nextRank = c.Rank;
                if (c.Rank != nextRank)
                {
                    consecutive = false;
                    break;
                }
                nextRank += 1;
            }
            return consecutive;
        }
    }
}
