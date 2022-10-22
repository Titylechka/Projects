using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._71
{
    class Program
    {
        static void Main(string[] args)
        {
            double procent = 0;
            double result12month = 0;

            double bankir = 1000;
            string[] month = { "второй", "третий", "четвертый", "пятый",
                "шестой", "седьмой", "восьмой", "девятый", "десятый","одиннадцатый","двенадцатый" };

            for (int i = 0; i < 9; i++)
            {
                if (i < 11)
                    result12month += bankir;

                procent = bankir * 2 / 100;
                bankir += procent;

                Console.WriteLine($"Гражданин получил за {month[i]} - {bankir} рублей");
            }

            Console.WriteLine($"\nЛыжник получил за 12 месяцев - {result12month}");
            Console.ReadKey();
        }
    }
}
