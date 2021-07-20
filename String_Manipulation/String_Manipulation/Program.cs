using System;

namespace String_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.";

            Console.WriteLine(sentence);

            Console.WriteLine("\nWhich word do you want to look for in the above sentence?");
            string word = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("What word do you want to change it to?");
            string newWord = Console.ReadLine();
            Console.WriteLine();

            if (!sentence.Contains(word))
            {
                Console.WriteLine($"Sorry, I could not find your word {word}.");
                
                string reversestring = "";
                int length;

                length = word.Length - 1;

                while (length >= 0)
                {
                    reversestring = reversestring + word[length];
                    length--;
                }

                Console.WriteLine(reversestring);
            }
            else
            {
                Console.WriteLine(sentence.Replace(word, newWord));
            }
        }
    }
}
