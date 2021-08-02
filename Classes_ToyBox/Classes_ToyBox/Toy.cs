using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_ToyBox
{
    class Toy
    {
        public string Manufacturer { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        private string Notes;

        public Toy()
        {
            Manufacturer = string.Empty;

            Name = string.Empty; ;

            Price = 0;

            Notes = string.Empty;
        }

        public void Note(string comment)
        {
            Notes = comment;
        }

        public string GetAisle()
        {
            Random rand = new Random();
            int number = rand.Next(1, 25);

            string aisle = $"{Manufacturer.ToUpper()[0]}{number}";
            return aisle;
        }

        public override string ToString()
        {
            string aisle = GetAisle();
            string output = $"{Name} is manufactured by {Manufacturer} and costs {Price.ToString("C")}. It can be found in aisle {aisle}. \nThis toy comes with a nice note: \n{Notes}.";

            return output;
        }
    }
}
