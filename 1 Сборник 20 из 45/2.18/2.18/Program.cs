using System;

namespace _2._18
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите трехзначное число: ");
            int z = Convert.ToInt32(Console.ReadLine());


            int a = z % 10;
            int b = ((z - a) / 10) % 10;
            int c = (z - (b * 10 + a)) / 100;

            Console.WriteLine("{3} = {2} {1} {0}:", a, b, c, z);
            Console.WriteLine("1: {2}{1}{0}", a, b, c);
            Console.WriteLine("2: {2}{0}{1}", a, b, c);
            Console.WriteLine("3: {1}{2}{0}", a, b, c);
            Console.WriteLine("4: {2}{1}{0}", a, b, c);
            Console.WriteLine("5: {0}{1}{2}", a, b, c);
            Console.WriteLine("6: {0}{2}{1}", a, b, c);


            Console.ReadKey();
        }
    }
}
