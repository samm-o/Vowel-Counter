using System;

namespace Vowel_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type in an English word: ");
            var input = Console.ReadLine();
            var frequency = 0;
            foreach (char c in input)
            {
                if (c == 'a')
                {
                    frequency++;
                }
                if (c == 'e')
                {
                    frequency++;
                }
                if (c == 'i')
                {
                    frequency++;
                }
                if (c == 'o')
                {
                    frequency++;
                }
                if (c == 'u')
                {
                    frequency++;
                }
            }
            Console.WriteLine(frequency);
        }
    }
}
