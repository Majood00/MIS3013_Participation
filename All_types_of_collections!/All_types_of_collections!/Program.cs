using System;

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
        }
    }
}
