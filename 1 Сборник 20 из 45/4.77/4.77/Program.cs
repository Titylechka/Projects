using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._77
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение a");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение b");
            float b = float.Parse(Console.ReadLine());

            if (Math.Sqrt(b) < Math.Sqrt(a))
            {
                Console.WriteLine(b * 5);
            }
            else Console.WriteLine("B больше A");
            Console.ReadKey();
        }
    }
}
