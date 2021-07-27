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
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            students.Add("MIS3013", new List<double>());
            students["MIS3013"].Add(0.95);
            students["MIS3013"].Add(0.5);
            students["MIS3013"].Add(0.7);

            students.Add("MTHR1113", new List<double>());
            students["MTHR1113"].Add(.6);
            students["MTHR1113"].Add(0.4);
            students["MTHR1113"].Add(1.0);

            students.Add("BME3333", new List<double>());
            students["BME3333"].Add(0.75);
            students["BME3333"].Add(0.85);
            students["BME3333"].Add(0.95);

            //Extra portion
            do
            {
                Console.WriteLine("Please enter the course code");
                string coursecode = Console.ReadLine().ToUpper();

                if (students.ContainsKey(coursecode) == false)
                {
                    students.Add(coursecode, new List<double>());
                }

                do
                {
                    Console.WriteLine($"Enter the students grade for {coursecode}");
                    double grade = Convert.ToDouble(Console.ReadLine());
                    students[coursecode].Add(grade);

                    Console.WriteLine("Do you have another grade to enter? yes or no");

                } while (Console.ReadLine().ToLower() == "yes");

                Console.WriteLine("Do you have another course to enter grades for? yes or no");

            } while (Console.ReadLine().ToLower() == "yes");
            
            foreach (string course in students.Keys)
            {
                double total = 0;

                foreach (double grade in students[course])
                {
                   total += grade;
                }

                double aver = total / students[course].Count;
                Console.WriteLine($"Your grade average for {course} is {aver.ToString("P")}");
            }

        }
    }
}
