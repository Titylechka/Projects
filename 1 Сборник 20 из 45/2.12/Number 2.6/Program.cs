using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трехзначное число");
            int number = int.Parse(Console.ReadLine());

            int first = number % 10;
            int second = ((number - first) / 10) % 10;
            int third = (number - (second * 10 + first)) / 100;

            Console.WriteLine($"Кол-во единиц {first}");
            Console.WriteLine($"Кол-во десятков {second}");

            Console.WriteLine($"Сумма всех цифр\n{first + second + third}");

            Console.WriteLine($"Произведение всех цифр\n{first * second * third}");

            Console.ReadKey();
        }
    }
}
