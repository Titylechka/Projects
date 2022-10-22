using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._43
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число b");
            int b = int.Parse(Console.ReadLine());

            if (a % b == 0 || b % a == 0)
                Console.WriteLine("Да, одно из чиселявляется делителем другого");
            else Console.WriteLine("Нет, ни одно из чисел не является делителем другого");

            Console.ReadKey();
        }
    }
}
