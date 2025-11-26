using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7pr1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[15]; 
            Random random = new Random();
            Console.WriteLine("Массив: ");
            for (int i = 0; i < numbers.Length; i++) 
            {
                numbers[i] = Math.Round(random.NextDouble() * 100, 2); //числа от 0 до 100
                Console.WriteLine(numbers[i] + " ");
            }

            //1. Находим минимальный и максимальный элементы
            double min = numbers[0];
            double max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min) min = numbers[i];
                if (numbers[i] > max) max = numbers[i];
            }
            Console.WriteLine($"Минимальный элемент: {min}");
            Console.WriteLine($"Максимальный элемент: {max}");
            
            //2. Разность минимального и максимального элемента
            Console.WriteLine($"Разность: {max - min}");

            //3.Элементы, которые больше среднего арифметического 
            double sum = 0;
            foreach (double num in numbers)
            {
                sum += num;
            }
            double average = sum / numbers.Length;
            Console.WriteLine($"Среднее арифметическое: {average}");
            Console.WriteLine($"Элементы больше {average}: ");
            foreach (double num in numbers)
            {
                if (num > average)
                {
                    Console.WriteLine($"{num}");
                }
            }
            

        }
    }
}
