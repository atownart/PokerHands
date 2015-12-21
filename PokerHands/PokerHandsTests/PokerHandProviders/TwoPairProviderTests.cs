using System.Collections.Generic;
using NUnit.Framework;
using PokerHands.cs.Entities;
using PokerHands.cs.PokerHandProviders;

namespace PokerHandsTests.PokerHandProviders
{
    [TestFixture]
    public class TwoPairProviderTests
    {
        [Test]
        public void HasPokerHand_CardsWithoutAnyPairs_DoesntHavePokerHand()
        {
            //Arrange
            var dummyCards = CardHelper.DummyCards();

            //Act 
            var hasHand = new TwoPairsProvider().HasPokerHand(dummyCards);

            //Assert
            Assert.IsFalse(hasHand, "Without two pairs it should return false");
        }


        [TestCase("4","A")]
        [TestCase("6", "K")]
        [TestCase("8", "2")]
        public void HasPokerHand_CardsWithTwoPairs_ShouldHavePokerHand(string pair1Value, string pair2Value)
        {
            //Arrange
            var cards = new List<Card>();
            cards.Add(CardHelper.DummyCard(pair1Value,"H"));
            cards.Add(CardHelper.DummyCard(pair1Value, "S"));
            cards.Add(CardHelper.DummyCard(pair2Value, "H"));
            cards.Add(CardHelper.DummyCard(pair2Value, "S"));
            cards.Add(CardHelper.DummyCard("5", "S"));
            
            //Act
            var hasHands = new TwoPairsProvider().HasPokerHand(cards);

            //Assert
            Assert.IsTrue(hasHands, "Two pair provider should recoginize the cards has two pairs");
        }

        [Test]
        public void HasPokerHand_CardWithOnePair_ShouldNotHavePokerHand()
        {
            //Arrange
            const string pairValue = "3";
            var cards = new List<Card>();
            cards.Add(CardHelper.DummyCard(pairValue, "H"));
            cards.Add(CardHelper.DummyCard(pairValue, "S"));
            cards.Add(CardHelper.DummyCard("5", "C"));
            cards.Add(CardHelper.DummyCard("6", "S"));
            cards.Add(CardHelper.DummyCard("7", "S"));

            //Act
            var hasHands = new TwoPairsProvider().HasPokerHand(cards);

            //Assert
            Assert.IsFalse(hasHands, "Two pair provider should recoginize the cards has one pair therefore should recognize a hand");
        }
    }
}
