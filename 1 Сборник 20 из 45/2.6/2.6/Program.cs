using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите секунды");
            int sec = int.Parse(Console.ReadLine());

            int min = 0;
            int hours = 0;

            if(sec >= 60)
            {
                min = sec / 60;
                sec = sec % 60;
            }
            if(min >= 60)
            {
                hours = min / 60;
                min = min % 60;
            }
            Console.WriteLine($"Часы - {hours}, минуты - {min}, секунды - {sec}");
            Console.ReadKey();
        }
    }
}
