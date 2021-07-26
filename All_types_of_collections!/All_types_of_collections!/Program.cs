using System;
using System.Collections.Generic;

namespace All_types_of_collections_
{
    class Program
    {
        static void Main(string[] args)
        {
            /*// Parallel Arrays
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

            */ // Dictionary
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            List<double> list1 = new List<double>();
            list1.Add(0.95);
            list1.Add(0.80);
            list1.Add(0.75);

            List<double> list2 = new List<double>();
            list2.Add(0.85);
            list2.Add(0.70);
            list2.Add(0.85);

            List<double> list3 = new List<double>();
            list3.Add(1.00);
            list3.Add(0.90);
            list3.Add(0.95);

            students.Add("BME 3333", list1);
            students.Add("MIS 3013", list2);
            students.Add("MTHR 1113", list3);

            List<List<double>> studentGrades = new List<List<double>>();
            studentGrades.Add(list1);
            studentGrades.Add(list2);
            studentGrades.Add(list3);

            double total = 0;
            
            foreach (string course in students.Keys)
            {
                foreach (var grade in students.Values)
                {
                    for (int i = 0; i < studentGrades.Count; i++)
                    {

                        total += studentGrades;
                    }
                    
                }
            }

            double aver = total / students.Values.Count;
            Console.WriteLine($"Your grade average for {students.Keys}is {aver.ToString("N2")}");


        }
    }
}
