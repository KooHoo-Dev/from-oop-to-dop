using UnityEngine;

namespace Study.OOP.Study_Factory
{
    public partial class Card
    {
        public string Name;
        public int Value;
        public Color Color;//등급 역할

        private Card(string name, int value)
        {
            Name = name;
            Value = value;
        }
    }
}