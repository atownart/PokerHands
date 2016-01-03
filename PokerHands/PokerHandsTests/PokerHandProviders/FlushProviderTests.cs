using System.Collections.Generic;
using NUnit.Framework;
using PokerHands.cs.Entities;
using PokerHands.cs.PokerHandProviders;

namespace PokerHandsTests.PokerHandProviders
{
    [TestFixture]
    public class FlushProviderTests
    {
        [Test]
        public void HasPokerHand_WithAllSameSuit_HasPokerHand()
        {
            //Arrange 
            var cards = new List<Card>();
            const string suite = "S";
            for (var i = 3; i <= 7; i++)
            {
                cards.Add(new Card(i.ToString(), suite, 0));
            }
            var flushProvider = new FlushProvider();

            //Act
            var hasHand = flushProvider.HasPokerHand(cards);

            //Assert
            Assert.That(hasHand,Is.True);
        }

        [Test]
        public void HasPokerHand_CardsHaveDifferentSuites_DoesNotHavePokerHand()
        {
            //Arrange 
            var cards = new List<Card>();
            const string suite = "S";
            for (var i = 3; i <= 6; i++)
            {
                cards.Add(new Card(i.ToString(), suite, 0));
            }
            cards.Add(new Card(string.Empty,"C",0));
            var flushProvider = new FlushProvider();

            //Act
            var hasHand = flushProvider.HasPokerHand(cards);

            //Assert
            Assert.That(hasHand, Is.False);
        }
    }
}
