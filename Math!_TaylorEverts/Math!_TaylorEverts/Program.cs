using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math__TaylorEverts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Dev.Build(2.0) multiplication table generator.\n" +
                "Please enter a number from 1 to 12");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("====++====");

            for (int i = 0; i <= number; i++)
            {
                Console.WriteLine(number + " X " + i + " = " + number * i);
            }

            Console.WriteLine("====++====");
            Console.ReadKey();
        }
    }
}
