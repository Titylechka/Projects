using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение x");
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение y");
            float y = float.Parse(Console.ReadLine());

            if (x > y)
                Console.WriteLine("Число X больше числа Y");
            else Console.WriteLine("Число Y больше числа X");

            Console.ReadKey();

        }
    }
}
