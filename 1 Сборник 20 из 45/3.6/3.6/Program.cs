using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = -10;
            int Y = -10;
            int Z = 10;
            double result;

            result = (X + Y) * (-Z);
            Console.WriteLine($"{result}");

            double result1;
            result1 = (-X) * (-Y);
            Console.WriteLine($"{result1}");

            double result2;
            result2 = (-X * -Z) + Y;
            Console.WriteLine($"{result2}");

            double result3;
            result3 = X * (-Y) + Z;
            Console.WriteLine($"{result3}");

            double result4;
            result4 = X * (-Y + Z);
            Console.WriteLine($"{result4}");

            double result5;
            result5 = X + (-(Y + Z));
            Console.WriteLine($"{result5}");
            Console.ReadKey();
        }
    }
}
