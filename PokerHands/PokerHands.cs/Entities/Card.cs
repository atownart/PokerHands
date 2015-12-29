namespace PokerHands.cs.Entities
{
    public class Card
    {
        public Card(string value, string suite, int rank)
        {
            Value = value;
            Suite = suite;
            Rank = rank;
        }

        public string Value { get; }

        public string Suite { get; set; } 

        public int Rank { get; set; }
    }
}
