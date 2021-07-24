using System;
using System.Collections.Generic;
using System.Linq;

namespace Collections_Min_Max_Avg
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            List<double> grades = new List<double>();

            double grade;

            do
            {
                Console.WriteLine("Please enter your exam grade.");
                input = Console.ReadLine();

                while (double.TryParse(input, out grade) == false)
                {
                    Console.WriteLine($"{input} is not a valid grade. Please enter a valid grade");
                    input = Console.ReadLine();
                }

                grades.Add(grade);

                Console.WriteLine("Do you want to enter another number? yes or no?");
                input = Console.ReadLine();

            } while (input.ToLower()[0] == 'y');

            double min = grades[0];

            foreach (double value in grades)
            {
                if (value < min)
                {
                    min = value;
                }
            }

            double max = grades[0];
            foreach (double value in grades)
            {
                if (value > max)
                {
                    max = value;
                }
            }

            double sum = 0;
            double ave = 0;

            for (int i = 0; i < grades.Count; i++)
            {
                sum += grades[i];
            }
            ave = sum / grades.Count;

            Console.WriteLine($"Your minimum exam score is {min.ToString("N2")}");
            Console.WriteLine($"Your maximum exam score is {max.ToString("N2")}");
            Console.WriteLine($"Your average exam score is {ave.ToString("N2")}");

            Dictionary<double, int> repetitions = new Dictionary<double, int>();
            foreach (var val in grades)
            {
                if (repetitions.ContainsKey(val))
                {
                    repetitions[val]++;
                } 
                else
                {
                    repetitions.Add(val, 1);
                }        
            }

            var mode = repetitions.OrderByDescending(x => x.Value).First();

            Console.WriteLine("The mode for your grades is {0}.", mode.Key);

        }
    }
}
