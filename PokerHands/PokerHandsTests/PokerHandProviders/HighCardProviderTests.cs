using System.Collections.Generic;
using NUnit.Framework;
using PokerHands.cs.Entities;
using PokerHands.cs.PokerHandProviders;

namespace PokerHandsTests.PokerHandProviders
{
    [TestFixture]
    public class HighCardProviderTests
    {
        [Test]
        public void HasPokerHand_WithCards_ReturnsTrue()
        {
            var cards = new List<Card>();
            var highCardProvider = new HighCardProvider();

            var hasHand = highCardProvider.HasPokerHand(cards);

            Assert.IsTrue(hasHand);
        }
    }
}
