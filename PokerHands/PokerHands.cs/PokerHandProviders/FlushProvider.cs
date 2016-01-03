using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using PokerHands.cs.Entities;

namespace PokerHands.cs.PokerHandProviders
{
    public class FlushProvider : PokerHandProviderBase, IPokerHandProvider
    {
        public bool HasPokerHand(IEnumerable<Card> cards)
        {
            var countSuiteGroups = from card in cards
                group card by card.Suite
                into suiteGroup
                select suiteGroup.Count();
            return countSuiteGroups.Count() == 1;
        }
    }
}
