using System;
using PokerHands.cs.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;

namespace PokerHandsTests
{
    public static class CardHelper
    {
        public static Card DummyCard(string value, string suite)
        {
            return new Card() {Value = value, Suite = suite};
        }

        public static string[] Suites()
        {
            return new string[] {"H", "C", "S", "D"};
        }

        public static string RandomSuite()
        {
            var rand = new Random();
            var index = rand.Next(Suites().Length);
            return Suites().ElementAt(index);
        }

        public static IEnumerable<Card> DummyCards()
        {
            var suite = RandomSuite();
            var dummyCards = new List<Card>();
            for (var i = 2; i < 8; i++)
            {
                dummyCards.Add(CardHelper.DummyCard(i.ToString(),suite));
            }
            return dummyCards;
        }
    }
}
