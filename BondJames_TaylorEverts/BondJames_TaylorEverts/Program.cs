using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BondJames_TaylorEverts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Dev.Build2.0 " +
                "first/last name swapper!\nPlease input a first" +
                " and last name separated by a space.");
            string name = Console.ReadLine();
            string[] names = name.Split(' ');
            Console.WriteLine(names[1] + " " + names[0]);
            Console.ReadKey();
        }
    }
}
