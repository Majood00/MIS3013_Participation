using System;
using System.Collections.Generic;
using System.IO;

namespace Classes_Cereal__read_in_a_File_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("Cereal_Data.txt");

            List<Cereal> cereals = new List<Cereal>();

            for (int i = 1; i < lines.Length; i++)
            {
                Cereal cereal = new Cereal();

                string line = lines[i];
                string[] pieces = line.Split('|');
                cereal.Name = Convert.ToString(pieces[0]);
                cereal.Manufacturer = Convert.ToString(pieces[1]);
                cereal.Calories = Convert.ToDouble(pieces[2]);
                cereal.Cups = Convert.ToDouble(pieces[3]);

                cereals.Add(cereal);
            }

            OutputAllCerealWithServingSize1CupOrMore(cereals);
            Console.WriteLine();
            OutputAllCerealWith100CaloriesOrLessPerServing(cereals);
        }

        private static void OutputAllCerealWithServingSize1CupOrMore(List<Cereal> cereals)
        {
            string title = "".PadLeft(10, '*') + "Cereal with a serving size of 1 cup or more" + "".PadRight(10, '*');
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(title);
            Console.ForegroundColor = ConsoleColor.White;
            int count = 0;
            foreach (Cereal cereal in cereals)
            {
                if (cereal.Cups >= 1)
                {
                    Console.Write($"{cereal}".PadRight(50,' ') + "\t");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write(cereal.Cups);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    count++;
                }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\nThere were {count} types of cereals with a serving size of 1 cup or more.");
            Console.WriteLine("".PadLeft(title.Length, '*'));
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void OutputAllCerealWith100CaloriesOrLessPerServing(List<Cereal> cereals)
        {
            string title = "".PadLeft(10, '*') + "Cereal with 100 calories or less per serving" + "".PadRight(10, '*');
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(title);
            Console.ForegroundColor = ConsoleColor.White;
            int count = 0;
            foreach (Cereal cereal in cereals)
            {
                if (cereal.Calories <= 100)
                {
                    Console.Write($"{cereal}".PadRight(50,' ') + "\t");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(cereal.Cups);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    count++;
                }
            }
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"\nThere were {count} types of cereals that have 100 calories or less per serving.");
            Console.WriteLine("".PadLeft(title.Length, '*'));
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
