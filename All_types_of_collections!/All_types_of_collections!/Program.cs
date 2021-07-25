using System;
using System.Collections.Generic;

namespace All_types_of_collections_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Parallel Arrays
            string[] subjects = new string[3];

            string[] courseNumbers = new string[3];

            Console.WriteLine("Please enter a subject");
            subjects[0] = Console.ReadLine().ToUpper();

            Console.WriteLine("Please enter another subject");
            subjects[1] = Console.ReadLine().ToUpper();

            Console.WriteLine("Please enter a third subject");
            subjects[2] = Console.ReadLine().ToUpper();

            Console.WriteLine("Please enter a course number");
            courseNumbers[0] = Console.ReadLine();

            Console.WriteLine("Please enter another course number");
            courseNumbers[1] = Console.ReadLine();

            Console.WriteLine("Please enter a third course number");
            courseNumbers[2] = Console.ReadLine();

            for (int i = 0; i < subjects.Length; i++)
            {
                string subject = subjects[i];
                string courseNumber = courseNumbers[i];
                Console.WriteLine($"{subject}{courseNumber}");
            }
            
            //List
            List<double> coursegrades = new List<double>();

            string input;

            do
            {
                Console.WriteLine("Please enter a grade");
                input = Console.ReadLine();
                double coursegrade;

                while (double.TryParse(input, out coursegrade) == false)
                {
                    Console.WriteLine($"{input} is not a valid grade. Please enter a valid grade");
                    input = Console.ReadLine();
                }

                coursegrades.Add(coursegrade);

                Console.WriteLine("Do you have another grade to input? yes or no?");
                input = Console.ReadLine();

            } while (input.ToLower()[0] == 'y');

            double average = 0, sum = 0;


            foreach (double value in coursegrades)
            {
                sum += value;
            }

            average = sum / coursegrades.Count;
            Console.WriteLine($"Your grade average is {average.ToString("N2")}");

            // Dictionary
        }
    }
}
