using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение x :");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение y :");
            int y = int.Parse(Console.ReadLine());

            if(x > 2 && y > 3)
                Console.WriteLine("х > 2 и у > 3 - Истина");
            else Console.WriteLine("х > 2 и у > 3 - Ложь");

            Console.WriteLine("Введите значение x1 :");
            int x1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение y1 :");
            int y1 = int.Parse(Console.ReadLine());

            if (x1 > 1 && y1 > -2)
                Console.WriteLine("х1 > 1 и у1 > -2 - Истина");
            else Console.WriteLine("х1 > 1 и у1 > -2 - Ложь");


            Console.WriteLine("Введите значение x2 :");
            int x2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение y2 :");
            int y2 = int.Parse(Console.ReadLine());

            if (x2 >= 0  && y2 < 5)
                Console.WriteLine("x2 >= 0  && y2 < 5 - Истина");
            else Console.WriteLine("x2 >= 0  && y2 < 5 - Ложь");


            Console.WriteLine("Введите значение x3 :");
            int x3 = int.Parse(Console.ReadLine());

            if (x3 > 3 || x3 < -1)
                Console.WriteLine("x3 > 3 или x3 < -1 - истина");
            else Console.WriteLine("x3 > 3 или x3 < -1 - ложь");


            Console.WriteLine("Введите значение x4 :");
            int x4 = int.Parse(Console.ReadLine());

            if (x4 > 3 && x4 < 10)
                Console.WriteLine("x4 > 3 или x4 < 10 - истина");
            else Console.WriteLine("x4 > 3 или x4 < 10 - ложь");


            Console.WriteLine("Введите значение x5 :");
            int x5 = int.Parse(Console.ReadLine());

            if (x5 > 2)
                Console.WriteLine("Верно, что х5 > 2");
            else Console.WriteLine("Неверно, что х5 > 2");


            Console.WriteLine("Введите значение x6 :");
            int x6 = int.Parse(Console.ReadLine());

            if (x6 > 0 && x6 < 5)
                Console.WriteLine("Верно,что x6 > 0 и x6 < 5");
            else Console.WriteLine("Неверно,что x6 > 0 и x6 < 5");


            Console.WriteLine("Введите значение x7 :");
            int x7 = int.Parse(Console.ReadLine());

            if (10 < x7 && x7 <= 20)
                Console.WriteLine("10 < x7 и x7 <= 20 - истина ");
            else Console.WriteLine("10 < x7 и x7 <= 20 - ложь ");


            Console.WriteLine("Введите значение x8 :");
            int x8 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение y8 :");
            int y8 = int.Parse(Console.ReadLine());


            if (0 < y8 && y8 <= 4 && x8 < 5)
                Console.WriteLine("0 < y8 && y8 <= 4 && x8 < 5 - истина");
            else Console.WriteLine("0 < y8 && y8 <= 4 && x8 < 5 - ложь");

            Console.ReadKey();
        }
    }
}
