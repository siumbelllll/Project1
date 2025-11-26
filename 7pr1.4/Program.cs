using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7pr1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            int[] numbers = { 1, 0, 2, 0, 3, 0, 4, 5 };
            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            int[] noZeroNumbers = numbers.Where(b => b != 0).ToArray();
            Console.WriteLine();
            Console.WriteLine("Новый массив без нулей:");
            foreach (int num in noZeroNumbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
