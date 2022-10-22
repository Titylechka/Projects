using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._28
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 8;
            for (int i = 9; i <= 15; i++)
            {
                c *= i;
            }
            Console.WriteLine(c);

            int p = 1;
            Console.WriteLine("Введите значение a");
            int a = int.Parse(Console.ReadLine());
            for (int i = a; i <= 20; i++)
            {
                p *= i;
            }
            Console.WriteLine(p);


            int l = 1;
            Console.WriteLine("Введите значение b");
            int b = int.Parse(Console.ReadLine());
            for (int i = 1; i <= b; i++)
            {
                l *= i;
            }
            Console.WriteLine(l);
            

            int k = 1;
            Console.WriteLine("Введите значение a ");
            int a1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение b ");
            int b1 = int.Parse(Console.ReadLine());
            for (int i = a1; i <= b1; i++)
            {
                k *= i;
            }
            Console.WriteLine(k);
            Console.ReadKey();
        }
    }
}
