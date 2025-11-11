using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6pr4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int sum = 0;
            Console.WriteLine("Введите числа:");
            do
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (n > 0)
                {
                    sum += n;
                }
            }
            while (n >= 0);
                Console.WriteLine(sum);
        }
    }
}
