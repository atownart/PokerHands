using System.Collections.Generic;
using NUnit.Framework;
using PokerHands.cs.Entities;
using PokerHands.cs.PokerHandProviders;

namespace PokerHandsTests.PokerHandProviders
{
    [TestFixture]
    public class ThreeOfAKindProviderTests
    {
        [Test]
        public void HasPokerHand_CardsNotContaining3WithSameValue_ShouldNotBePokerHand()
        {
            //arrange
            var cards = CardHelper.DummyCards();
            
            //act
            var hasHands = new ThreeOfAKindProvider().HasPokerHand(cards);

            //assert
            Assert.IsFalse(hasHands, "Cards do not have 3 of a kind therefore it should not have the hand");
        }

        [TestCase("3")]
        [TestCase("A")]
        [TestCase("K")]
        public void HasPokerHand_CardsContain3OfAKind_HasPokerHand(string value)
        {
            //arrange
            var cards = new List<Card>();
            cards.Add(CardHelper.DummyCard(value, "H"));
            cards.Add(CardHelper.DummyCard(value, "S"));
            cards.Add(CardHelper.DummyCard(value, "D"));
            cards.Add(CardHelper.DummyCard("8", "S"));
            cards.Add(CardHelper.DummyCard("9", "S"));

            //act
            var hasHand = new ThreeOfAKindProvider().HasPokerHand(cards);

            //assert
            Assert.IsTrue(hasHand);
        }
    }
}
