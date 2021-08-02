using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_ToyBox
{
    class ToyBox
    {
        public List<Toy> Toys { get; set; }

        public string Owner { get; set; }

        public string Location { get; set; }

        public ToyBox()
        {
            Toys = new List<Toy>();

            Owner = string.Empty;

            Location = string.Empty;
        }

        public Toy GetRandomToy()
        {
            Random rand = new Random();
            int number = rand.Next(1, Toys.Count + 1);

            return Toys[number];
        }

        public override string ToString()
        {
            string output;

            output = $"This toybox is owned by {Owner} who lives in {Location}. The toys are: ";

            foreach (Toy toy in Toys)
            {
               output += $"\n{toy}";
            }
            
            return output;
        }
    }
}
