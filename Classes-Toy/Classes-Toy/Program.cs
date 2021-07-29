using System;
using System.Collections.Generic;

namespace Classes_Toy
{
    class Program
    {
        static void Main(string[] args)
        {
            Toy toy1 = new Toy();
            toy1.Name = "Train";
            toy1.Price = 7.50;
            toy1.Manufacturer = "Toyfinity";
            toy1.Note("Hope you will enjoy your time playing with this toy");

            Toy toy2 = new Toy();
            toy2.Name = "Jigsaw Puzzle";
            toy2.Price = 12.00;
            toy2.Manufacturer = "Artifact Puzzles";
            toy2.Note("Have fun and work hard");

            List<Toy> toys = new List<Toy>();
            toys.Add(toy1);
            toys.Add(toy2);

            Console.WriteLine(toy1);
            Console.WriteLine();
            Console.WriteLine(toy2);            
        }
    }
}
