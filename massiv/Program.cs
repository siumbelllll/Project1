using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace massiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //объявляем массив
            int[] numbers = new int[10];
            //заполняем массив от 1 до 10
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1; //записываем значчения в ячейку
            }
            Console.WriteLine("Массив: ");
            //вывод массива
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            //сумма элементов массива
            int sum = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            //произведение элементов массива
            int proizv = 1;
            for(int i = 0; i < numbers.Length; i++)
            {
                proizv = proizv * numbers[i];
            }
            double average = sum / numbers.Length; //Вычисление среднего арифметического
            Console.WriteLine("Сумма: " + sum);
            Console.WriteLine("Произведение: " + proizv);
            Console.WriteLine("Среднее: " + average);
        }
    }
}
