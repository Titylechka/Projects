using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._30
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 456;

            int first = number % 10;
            int second = ((number - first) / 10) % 10;
            int third = (number - (second * 10 + first)) / 100;

            Console.WriteLine($"{third}{first}{second}");

            Console.ReadKey();
        }
    }
}
