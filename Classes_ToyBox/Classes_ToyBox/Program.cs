using System;
using System.Collections.Generic;

namespace Classes_ToyBox
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;

            ToyBox toybox1 = new ToyBox();

            Console.WriteLine("Please enter the owner of the toybox");
            string owner = Console.ReadLine();
            toybox1.Owner = owner;

            Console.WriteLine("Please enter the location of the toybox");
            string location = Console.ReadLine();
            toybox1.Location = location;

            Toy toy1 = new Toy();
            Console.WriteLine("Please enter the name of the toy");
            string name = Console.ReadLine();
            toy1.Name = name;

            Console.WriteLine("Please enter the price of the toy");
            double price = Convert.ToDouble(Console.ReadLine());
            toy1.Price = price;

            Console.WriteLine("Please enter the manufacturer of the toy");
            string manufacturer = Console.ReadLine();
            toy1.Manufacturer = manufacturer;

            Console.WriteLine("Please enter a note that comes with the toy");
            string note = Console.ReadLine();
            toy1.Note(note);

            toybox1.Toys.Add(toy1);

            Console.WriteLine("Do you want to add another toy to the toybox? yes or no?");
            answer = Console.ReadLine().ToLower();

            while (true)
            {
                if (answer == "yes")
                {
                    Toy toy2 = new Toy();
                    Console.WriteLine("Please enter the name of the toy");
                    name = Console.ReadLine();
                    toy2.Name = name;

                    Console.WriteLine("Please enter the price of the toy");
                    price = Convert.ToDouble(Console.ReadLine());
                    toy2.Price = price;

                    Console.WriteLine("Please enter the manufacturer of the toy");
                    manufacturer = Console.ReadLine();
                    toy2.Manufacturer = manufacturer;

                    Console.WriteLine("Please enter a note that comes with the toy");
                    note = Console.ReadLine();
                    toy2.Note(note);

                    toybox1.Toys.Add(toy2);

                    Console.WriteLine("Do you want to add another toy to the toybox? yes or no?");
                    answer = Console.ReadLine().ToLower();

                    if (answer == "yes")
                    {
                        Toy toy3 = new Toy();
                        Console.WriteLine("Please enter the name of the toy");
                        name = Console.ReadLine();
                        toy3.Name = name;

                        Console.WriteLine("Please enter the price of the toy");
                        price = Convert.ToDouble(Console.ReadLine());
                        toy3.Price = price;

                        Console.WriteLine("Please enter the manufacturer of the toy");
                        manufacturer = Console.ReadLine();
                        toy3.Manufacturer = manufacturer;

                        Console.WriteLine("Please enter a note that comes with the toy");
                        note = Console.ReadLine();
                        toy3.Note(note);

                        toybox1.Toys.Add(toy3);

                        Console.WriteLine("Do you want to add another toy to the toybox? yes or no?");
                        answer = Console.ReadLine().ToLower();

                        if (answer == "yes")
                        {
                            Toy toy4 = new Toy();
                            Console.WriteLine("Please enter the name of the toy");
                            name = Console.ReadLine();
                            toy4.Name = name;

                            Console.WriteLine("Please enter the price of the toy");
                            price = Convert.ToDouble(Console.ReadLine());
                            toy4.Price = price;

                            Console.WriteLine("Please enter the manufacturer of the toy");
                            manufacturer = Console.ReadLine();
                            toy4.Manufacturer = manufacturer;

                            Console.WriteLine("Please enter a note that comes with the toy");
                            note = Console.ReadLine();
                            toy4.Note(note);

                            toybox1.Toys.Add(toy4);

                            Console.WriteLine("Do you want to add another toy to the toybox? yes or no?");
                            answer = Console.ReadLine().ToLower();

                            if (answer == "yes")
                            {
                                Toy toy5 = new Toy();
                                Console.WriteLine("Please enter the name of the toy");
                                name = Console.ReadLine();
                                toy5.Name = name;

                                Console.WriteLine("Please enter the price of the toy");
                                price = Convert.ToDouble(Console.ReadLine());
                                toy5.Price = price;

                                Console.WriteLine("Please enter the manufacturer of the toy");
                                manufacturer = Console.ReadLine();
                                toy5.Manufacturer = manufacturer;

                                Console.WriteLine("Please enter a note that comes with the toy");
                                note = Console.ReadLine();
                                toy5.Note(note);

                                toybox1.Toys.Add(toy5);
                            }                            
                        }                        
                    }                    
                }
                else
                {
                    Console.WriteLine("Do you want to create another toybox? yes or no?");
                    answer = Console.ReadLine().ToLower();
                    ToyBox toybox2 = new ToyBox();

                    if (answer == "yes")
                    {                        
                        Console.WriteLine("Please enter the owner of the toybox");
                        owner = Console.ReadLine();
                        toybox2.Owner = owner;

                        Console.WriteLine("Please enter the location of the toybox");
                        location = Console.ReadLine();
                        toybox2.Location = location;

                        toy1 = new Toy();
                        Console.WriteLine("Please enter the name of the toy");
                        name = Console.ReadLine();
                        toy1.Name = name;

                        Console.WriteLine("Please enter the price of the toy");
                        price = Convert.ToDouble(Console.ReadLine());
                        toy1.Price = price;

                        Console.WriteLine("Please enter the manufacturer of the toy");
                        manufacturer = Console.ReadLine();
                        toy1.Manufacturer = manufacturer;

                        Console.WriteLine("Please enter a note that comes with the toy");
                        note = Console.ReadLine();
                        toy1.Note(note);

                        toybox2.Toys.Add(toy1);

                        Console.WriteLine("Do you want to add another toy to the toybox? yes or no?");
                        answer = Console.ReadLine().ToLower();

                        if (answer == "yes")
                        {
                            Toy toy2 = new Toy();
                            Console.WriteLine("Please enter the name of the toy");
                            name = Console.ReadLine();
                            toy2.Name = name;

                            Console.WriteLine("Please enter the price of the toy");
                            price = Convert.ToDouble(Console.ReadLine());
                            toy2.Price = price;

                            Console.WriteLine("Please enter the manufacturer of the toy");
                            manufacturer = Console.ReadLine();
                            toy2.Manufacturer = manufacturer;

                            Console.WriteLine("Please enter a note that comes with the toy");
                            note = Console.ReadLine();
                            toy2.Note(note);

                            toybox2.Toys.Add(toy2);

                            Console.WriteLine("Do you want to add another toy to the toybox? yes or no?");
                            answer = Console.ReadLine().ToLower();

                            if (answer == "yes")
                            {
                                Toy toy3 = new Toy();
                                Console.WriteLine("Please enter the name of the toy");
                                name = Console.ReadLine();
                                toy3.Name = name;

                                Console.WriteLine("Please enter the price of the toy");
                                price = Convert.ToDouble(Console.ReadLine());
                                toy3.Price = price;

                                Console.WriteLine("Please enter the manufacturer of the toy");
                                manufacturer = Console.ReadLine();
                                toy3.Manufacturer = manufacturer;

                                Console.WriteLine("Please enter a note that comes with the toy");
                                note = Console.ReadLine();
                                toy3.Note(note);

                                toybox2.Toys.Add(toy3);

                                Console.WriteLine("Do you want to add another toy to the toybox? yes or no?");
                                answer = Console.ReadLine().ToLower();

                                if (answer == "yes")
                                {
                                    Toy toy4 = new Toy();
                                    Console.WriteLine("Please enter the name of the toy");
                                    name = Console.ReadLine();
                                    toy4.Name = name;

                                    Console.WriteLine("Please enter the price of the toy");
                                    price = Convert.ToDouble(Console.ReadLine());
                                    toy4.Price = price;

                                    Console.WriteLine("Please enter the manufacturer of the toy");
                                    manufacturer = Console.ReadLine();
                                    toy4.Manufacturer = manufacturer;

                                    Console.WriteLine("Please enter a note that comes with the toy");
                                    note = Console.ReadLine();
                                    toy4.Note(note);

                                    toybox2.Toys.Add(toy4);

                                    Console.WriteLine("Do you want to add another toy to the toybox? yes or no?");
                                    answer = Console.ReadLine().ToLower();

                                    if (answer == "yes")
                                    {
                                        Toy toy5 = new Toy();
                                        Console.WriteLine("Please enter the name of the toy");
                                        name = Console.ReadLine();
                                        toy5.Name = name;

                                        Console.WriteLine("Please enter the price of the toy");
                                        price = Convert.ToDouble(Console.ReadLine());
                                        toy5.Price = price;

                                        Console.WriteLine("Please enter the manufacturer of the toy");
                                        manufacturer = Console.ReadLine();
                                        toy5.Manufacturer = manufacturer;

                                        Console.WriteLine("Please enter a note that comes with the toy");
                                        note = Console.ReadLine();
                                        toy5.Note(note);

                                        toybox2.Toys.Add(toy5);
                                    }
                                }
                            }                           
                        }
                    }
                    else
                    {
                        Console.WriteLine();
                        Toy randomToy = toybox1.GetRandomToy();
                        Console.WriteLine(randomToy);

                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(toybox1);
                        Console.ForegroundColor = ConsoleColor.White;

                        Console.WriteLine();
                        Toy randomToy1 = toybox2.GetRandomToy();
                        Console.WriteLine(randomToy1);

                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(toybox2);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }
        }
    }
}
