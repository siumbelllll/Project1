using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7pr1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            Random random = new Random();
           
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(0, 101);
            }
            Console.WriteLine("Массив: ");
            
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

            int sum = 0;
            int average = 0;
            
            for (int i = 0; i < numbers.Length; i++)
            {
                sum = sum + numbers[i];
                average = sum / 10;
            }
            Console.WriteLine($"Сумма: {sum}. ");
            Console.WriteLine($"Средняя арифметическая: {average}. ");

            int evenNumber = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenNumber++;
                }
            }
            Console.WriteLine($"Количество четных чисел: {evenNumber}");





        }
    }
}
