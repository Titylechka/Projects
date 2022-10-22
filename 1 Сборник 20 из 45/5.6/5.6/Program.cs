using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double b = 20.4;
            double i = 20;

           for(b = 20.4;b < 35;b++)
            {
                i = i + 1;
                Console.WriteLine($"{i},{b}");
            }
            Console.ReadKey();


        }
    }
}
