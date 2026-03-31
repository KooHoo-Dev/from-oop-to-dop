using UnityEngine;

namespace Study.OOP.Study_Factory
{
    public partial class Card
    {
        protected string[] Names { get; set; }
        protected int MinValue { get; set; }
        protected int MaxValue { get; set; }

        public bool InRange(int value)
            => (MinValue <= value && value < MaxValue);

        public Card CreateBaseCard()
        {
            string cardName = Names[Random.Range(0, Names.Length)];
            int value = Random.Range(MinValue, MaxValue);
            return new Card(cardName, value);
        }
    }
}
