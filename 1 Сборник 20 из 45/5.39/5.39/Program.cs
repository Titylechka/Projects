using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._39
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            for(int i = 0; i < 10; i++)
            {
                int number = int.Parse(Console.ReadLine());
                result += number;
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
