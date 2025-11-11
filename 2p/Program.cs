using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2p
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое чило:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите знак операции ( +, -, *, / ):");
            string operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    Console.WriteLine(a + b);
                    break;
                case "-":
                    Console.WriteLine(a - b);
                    break;
                case "*":
                    Console.WriteLine(a * b);
                    break;
                case "/":
                    Console.WriteLine(a / b);
                    break;
                default:
                    Console.WriteLine("Нет такого действия");
                    break;
            }


        }
    }
}
