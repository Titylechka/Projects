using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("5 10\n7 см\n");

            Console.WriteLine("Введите значение t");
            string t = Console.ReadLine();
            Console.WriteLine("Введите значение v");
            string v = Console.ReadLine();
            Console.WriteLine($"100 {t}\n1949 {v}\n");

            Console.WriteLine("Введите значение x");
            string x = Console.ReadLine();
            Console.WriteLine("Введите значение y");
            string y = Console.ReadLine();
            Console.WriteLine($"{x} {y}\n5 {y}");

            Console.ReadKey();
        }
    }
}
