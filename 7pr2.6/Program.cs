using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7pr2._6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Температуры за месяц");
            int[] temperature = new int[30];
            Random random = new Random();
            for (int i = 0; i < temperature.Length; i++)
            {
                temperature[i] = random.Next(-10, 28);
            }
            for (int i = 1; i < temperature.Length; i++)
            {
                Console.Write(temperature[i] + " ");
                if (i % 7 == 0) Console.WriteLine();
            }
            Console.WriteLine();
            //1 самая теплая и холодная неделя
            double sum = 0;
            foreach (double temper in temperature)
            {
                sum += temper;
            }
            double average = sum / temperature.Length;
            Console.WriteLine($"Средняя температура за месяц: {average:F1}C");
            
            //2 дни,когда температура была выше средней
            Console.WriteLine("Дни, когда температура была выше средней:");
            int day = 1;
            foreach (double temp in temperature)
            {
                if (temp > average)
                {
                    Console.WriteLine($"  День {day}: {temp:F1}C");
                }
                day++;
            }
            //3 температуры по дипапазонам
            int frost = 0;
            int cold = 0;
            int warm = 0;
            int hot = 0;

            foreach (double temp in temperature)
            {
                if (temp < 0)
                    frost++;
                else if (temp < 15) 
                    cold++;
                else if (temp < 25) 
                    warm++;
                else 
                    hot++;
            }
            Console.WriteLine($"Температура по диапозонам:");
            Console.WriteLine($"  Мороз: {frost} дней");
            Console.WriteLine($"  Холодно: {cold} дней");
            Console.WriteLine($"  Тепло: {warm} дней");
            Console.WriteLine($"  Жарко: {hot} дней");
        }
    }
}
