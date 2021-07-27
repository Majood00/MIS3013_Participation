using System;
using System.Collections.Generic;
using System.Linq;

namespace Collections_Min_Max_Avg
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> grades = new List<double>();

            Dictionary<double, int> repetitions = new Dictionary<double, int>();


            do
            {
                Console.WriteLine("Please enter your exam grade.");
                double input = Convert.ToDouble(Console.ReadLine());

                grades.Add(input);

                if (repetitions.ContainsKey(input) == false)
                {
                    repetitions.Add(input, 1);
                }
                else
                {
                    repetitions[input]++;
                }

                Console.WriteLine("Do you want to enter another number? yes or no?");

            } while (Console.ReadLine() == "yes");

            double min = grades[0];

            foreach (double value in grades)
            {
                if (value < min)
                {
                    min = value;
                }
            }

            int mode = 1;

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


            foreach(double grade in repetitions.Keys)
            {
                sum = sum + repetitions[grade] * grade;
                if (mode < repetitions[grade])
                {
                    mode = repetitions[grade];
                }
            }

            foreach (double grade in repetitions.Keys) //Output any keys(grades) that have a value of the mode
            {
                sum = sum + repetitions[grade] * grade;
                if (mode == repetitions[grade])
                {
                    Console.WriteLine($"Your mode: \n[{grade}]: " + mode);
                }
            }

        }
    }
}
