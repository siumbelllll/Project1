using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1p
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 1 до 7:");
            string week = Console.ReadLine();
            switch (week)
            {
                case "1":
                    Console.WriteLine("Понедельник");
                    break;
                case "2":
                    Console.WriteLine("Вторник");
                    break;
                case "3":
                    Console.WriteLine("Среда");
                    break;
                case "4":
                    Console.WriteLine("Четверг");
                    break;
                case "5":
                    Console.WriteLine("Пятница");
                    break;
                case "6":
                    Console.WriteLine("Суббота");
                    break;
                case "7":
                    Console.WriteLine("Воскресенье");
                    break;
                default:
                    Console.WriteLine("Неправильно ввели число");
                    break;
            }
        }
    }
}
