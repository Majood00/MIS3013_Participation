using System;
using System.Collections.Generic;

namespace Classes_ToyBox
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ToyBox> toyboxes = new List<ToyBox>();

            string answer;

            do
            {
                ToyBox toybox1 = new ToyBox();

                Console.WriteLine("Please enter the owner of the toybox");
                string owner = Console.ReadLine();
                toybox1.Owner = owner;

                Console.WriteLine();
                Console.WriteLine("Please enter the location of the toybox");
                string location = Console.ReadLine();
                toybox1.Location = location;

                toyboxes.Add(toybox1);

                Console.WriteLine();
                Console.WriteLine("Do you have another ToyBox to enter? yes or no >>");
                answer = Console.ReadLine().ToLower();
                Console.WriteLine();

            } while (answer == "yes");

            for (int i = 0; i < toyboxes.Count; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Time to fill {toyboxes[i].Owner}'s ToyBox!");
                Console.WriteLine();

                do
                {
                    Toy toy1 = new Toy();
                    Console.WriteLine("Please enter the name of the toy");
                    string name = Console.ReadLine();
                    toy1.Name = name;

                    Console.WriteLine();
                    Console.WriteLine("Please enter the price of the toy");
                    double price = Convert.ToDouble(Console.ReadLine());
                    toy1.Price = price;

                    Console.WriteLine();
                    Console.WriteLine("Please enter the manufacturer of the toy");
                    string manufacturer = Console.ReadLine();
                    toy1.Manufacturer = manufacturer;

                    Console.WriteLine();
                    Console.WriteLine("Please enter a note that comes with the toy");
                    string note = Console.ReadLine();
                    toy1.Note(note);
                                                          
                    toyboxes[i].Toys.Add(toy1);

                    Console.WriteLine();
                    Console.WriteLine($"Do you want to add another toy to {toyboxes[i].Owner}'s toybox? yes or no?");
                    answer = Console.ReadLine().ToLower();
                    Console.WriteLine();

                } while (answer == "yes");
            }

            foreach (ToyBox currentToyBox in toyboxes)
            {
                Console.WriteLine();
                Console.WriteLine($"{currentToyBox.Owner}'s ToyBox is located in {currentToyBox.Location}. The ToyBox has {currentToyBox.Toys.Count} toys inside of it:");

                foreach (Toy toyInCurrentBox in currentToyBox.Toys)
                {
                    Console.WriteLine();
                    Console.WriteLine(toyInCurrentBox);                    
                }

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Toy random = currentToyBox.GetRandomToy();
                Console.WriteLine(random);
                Console.ForegroundColor = ConsoleColor.White;
            }
                                   
        }
    }
}
