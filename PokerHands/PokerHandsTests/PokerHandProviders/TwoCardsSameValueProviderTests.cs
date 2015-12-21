using System.Collections.Generic;
using NUnit.Framework;
using PokerHands.cs.Entities;
using PokerHands.cs.PokerHandProviders;

namespace PokerHandsTests.PokerHandProviders
{
    [TestFixture]
    public class TwoCardsSameValueProviderTests
    {
        [Test]
        public void HasPokerHand_WithNoMatchingValues_DoesntHaveHand()
        {
            //Arrange
            var cards = new List<Card>() {CardHelper.DummyCard("5", "D"), CardHelper.DummyCard("K", "H")};
            var twoCardsProvider = new TwoCardsSameValueProvider();

            //Act
            var hasHand = twoCardsProvider.HasPokerHand(cards);

            //Assert
            Assert.IsFalse(hasHand, "the cards do not have more than one of the same value so it should be false");
        }

        [TestCase("D")]
        [TestCase("S")]
        [TestCase("H")]
        [TestCase("C")]
        public void HasPokerHand_WithMatchingValues_HasHand(string sameValue)
        {
            //Arrange
            var cards = new List<Card>() { CardHelper.DummyCard("5", sameValue), CardHelper.DummyCard("K", "H"), CardHelper.DummyCard("5",sameValue) };
            var twoCardsProvider = new TwoCardsSameValueProvider();

            //Act
            var hasHand = twoCardsProvider.HasPokerHand(cards);

            //Assert
            Assert.IsTrue(hasHand, "the cards have more than one of the same value so it should be true");
        }
    }
}
