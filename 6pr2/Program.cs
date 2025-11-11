using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6pr2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int numb;
            do
            {
                Console.WriteLine("Введите число ( для завершения введите 0 ): ");
                numb = Convert.ToInt32(Console.ReadLine());
                if (numb != 0)
                {
                    sum += numb;
                }
            }
            while (numb != 0);
            Console.WriteLine($"Сумма всех чисел равна: {sum} ");
            
        }
    }
}
