using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число m");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число n");
            int n = int.Parse(Console.ReadLine());

            if (m % n == 0)
            {
                Console.WriteLine(m / n);
            }
            else Console.WriteLine("m на n нацело не делится");

            Console.ReadKey();
        }
    }
}
