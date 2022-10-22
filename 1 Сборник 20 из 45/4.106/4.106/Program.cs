using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._106
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Введите число от 1 до 12");
                int number = int.Parse(Console.ReadLine());

                switch (number)
                {
                    case 1:
                        Console.WriteLine("Январь\n");
                        break;
                    case 2:
                        Console.WriteLine("Февраль\n");
                        break;
                    case 3:
                        Console.WriteLine("Март\n");
                        break;
                    case 4:
                        Console.WriteLine("Апрель\n");
                        break;
                    case 5:
                        Console.WriteLine("Май\n");
                        break;
                    case 6:
                        Console.WriteLine("Июнь\n");
                        break;
                    case 7:
                        Console.WriteLine("Июль\n");
                        break;
                    case 8:
                        Console.WriteLine("Август\n");
                        break;
                    case 9:
                        Console.WriteLine("Сентябрь\n");
                        break;
                    case 10:
                        Console.WriteLine("Октябрь\n");
                        break;
                    case 11:
                        Console.WriteLine("Ноябрь\n");
                        break;
                    case 12:
                        Console.WriteLine("Декабрь\n");
                        break;


                    default:
                        Console.WriteLine("Вы вышли за пределы 1-12\n");
                        break;
                }
            }
        }
    }
}
