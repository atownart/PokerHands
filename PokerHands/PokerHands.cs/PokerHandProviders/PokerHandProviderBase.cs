using System.Collections.Generic;
using System.Linq;
using PokerHands.cs.Entities;

namespace PokerHands.cs.PokerHandProviders
{
    public abstract class PokerHandProviderBase
    {
        public bool CardsHaveContainsACertainAmountOfTheSameValue(IEnumerable<Card> cards, int amount)
        {
            var hasHand = false;
            cards.ToList().ForEach(card =>
            {
                var count = cards.Count(c => c.Value.Equals(card.Value));
                if (count == amount)
                {
                    hasHand = true;
                }
            });
            return hasHand;
        }
    }
}
