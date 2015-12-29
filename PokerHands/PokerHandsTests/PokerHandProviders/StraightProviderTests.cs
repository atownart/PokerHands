using System.Collections.Generic;
using NUnit.Framework;
using PokerHands.cs.Entities;
using PokerHands.cs.PokerHandProviders;

namespace PokerHandsTests.PokerHandProviders
{
    [TestFixture]
    public class StraightProviderTests
    {
        [Test]
        public void HasPokerHand_5CardsNotConsecutive_DoesNotHaveHand()
        {
            //arrange
            var cards = new List<Card>();
            for (var i = 1; i < 5; i++)
            {
                cards.Add(new Card(string.Empty, string.Empty, i));
            }
            cards.Add(new Card(string.Empty, string.Empty, 10));
            var straightProvider = new StraightProvider();

            //act
            var hasHand = straightProvider.HasPokerHand(cards);

            //Assert
            Assert.IsFalse(hasHand,"It should not have a straight hand as the cards are not consecutive");
        }

        [Test]
        public void HasPokerHand_CardsAreConsecutive_HasHand()
        {
            //arrange
            var cards = new List<Card>();
            for (var i = 1; i < 6; i++)
            {
                cards.Add(new Card(string.Empty, string.Empty, i));
            }
            var straightProvider = new StraightProvider();

            //act
            var hasHand = straightProvider.HasPokerHand(cards);

            //Assert
            Assert.IsTrue(hasHand, "It should have a straight hand as the cards are consecutive");
        }

        [Test]
        public void HasPokerHand_CardsAreConsecutiveButInRandomOrder_HasHand()
        {
            //arrange
            var cards = new List<Card>();
            cards.Add(new Card(string.Empty, string.Empty, 2));
            cards.Add(new Card(string.Empty, string.Empty, 1));
            cards.Add(new Card(string.Empty, string.Empty, 4));
            cards.Add(new Card(string.Empty, string.Empty, 3));
            cards.Add(new Card(string.Empty, string.Empty, 5));
            var straightProvider = new StraightProvider();

            //act
            var hasHand = straightProvider.HasPokerHand(cards);

            //Assert
            Assert.IsTrue(hasHand, "It should have a straight hand as the cards are consecutive");
        }

    }
}
