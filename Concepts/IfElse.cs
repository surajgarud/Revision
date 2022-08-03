using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepts
{
    internal class IfElse
    {
        public static void FindEvenOrOdd()
        {
            int number = 0;
            Console.WriteLine("Enter a number to check : ");
            number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine(" is an even number");
            }
            else
            {
                Console.WriteLine(" is an odd number");
            }
        }
    }
}
