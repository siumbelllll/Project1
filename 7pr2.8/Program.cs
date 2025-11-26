using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7pr2._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[10];
            Random random = new Random();

            for (int i = 0; i < number.Length; i++)
            {
                number[i] = random.Next(0, 101);
            }
            Console.WriteLine("Результаты тестирования: ");
            for (int i = 0; i < number.Length; i++)
            {
                Console.Write(number[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Отсортированные результаты: ");
            Array.Sort(number);

            for (int i = 0; i < number.Length; i++)
            {
                Console.Write(number[i] + " ");
            }
            Console.WriteLine();
            if (number.Length % 2 == 0)
            {
                double mediana = (number[(number.Length / 2) - 1] + number[number.Length / 2]) / 2.0;
                Console.WriteLine($"Медиана: {mediana}");
            }
            else
            {
                double median = number[number.Length / 2];
                Console.WriteLine($"Медиана: {median}");
            }
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                sum += number[i];
            }
            sum = sum / 15;
            double sumSquare = 0;
            for (int i = 0; i < number.Length; i++)
            {
                double difference = number[i] - sum;
                sumSquare += difference * difference;
            }
            double variance = sumSquare / number.Length;
            double a = Math.Sqrt(variance);
            Console.WriteLine($"Стандартное отклонение: {a}");
            int count = (int)Math.Ceiling(number.Length * 0.1);
            Console.WriteLine("Топ 10% лучших результатов: ");
            for (int i = number.Length - count; i < number.Length; i++)
            {
                Console.Write(number[i] + " ");
            }
            int awful = 0;
            int bad = 0;
            int good = 0;
            int excellent = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] < 50) { awful++; }
                else if (number[i] < 70) { bad++; }
                else if (number[i] < 85) { good++; }
                else { excellent++; }
            }
            Console.WriteLine();
            Console.WriteLine($"85-100 баллов: {excellent} студентов");
            Console.WriteLine($"70-85 баллов: {good} студентов");
            Console.WriteLine($"50-70 баллов: {bad} студентов");
            Console.WriteLine($"0-50 баллов: {awful} студентов");
        }
    }
}
