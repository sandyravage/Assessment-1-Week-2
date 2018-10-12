using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idliketobuyavowel_TaylorEverts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Dev.Build(2.0) vowel counter!\n" +
                "Please enter a word or phrase:");
            string words = Console.ReadLine();

            int count = 0;

            foreach(char vowel in words)
            {
                if(vowel == 'a' || vowel == 'e' || vowel == 'i' || vowel == 'o' || vowel == 'u')
                {
                    count++;
                }
            }

            Console.WriteLine("There are {0} vowels in the string \"{1}\".", count, words);
            Console.ReadKey();
        }
    }
}
