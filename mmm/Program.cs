using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mmm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создание массива на 15 чисел
            int[] numbers = new int[15];
            Random random = new Random();//Coздаем генератор случайных чисел
            //Заполнение массива ранодомными числами от -10 до 10
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(-10, 11);//Next(min, max) дает числа от мин до мах - 1
            }
            Console.WriteLine("Массив: ");
            //выводим массив
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i] + " ");
            }
            //Инициализируем счетчики и суммы
            int positiveCount = 0;
            int negativeCount = 0;
            int zeroCount = 0;
            int positiveSum = 0;
            int negativeSum = 0;
            //Анализ каждого элемента массива
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                {
                    positiveCount++;// увеличиваем счетчик положительных чисел
                    positiveSum = positiveSum + numbers[i];//
                }
                else if (numbers[i] < 0)
                {
                    negativeCount++;
                    negativeSum = negativeSum + numbers[i];
                }
                else
                {
                    zeroCount++;
                }

            }
            Console.WriteLine();
            Console.WriteLine($"Количество положительных чисел: {positiveCount}. Сумма положительных чисел: {positiveSum}. ");
            Console.WriteLine($"Количество отрицательных чисел: {negativeCount}. Сумма отрицатеьных чисел: {negativeSum}. ");
            Console.WriteLine("Количество нулей: " + zeroCount);

        }
    }
}
//[0,0,0,0,0,0,0,0,0,0,0,0,0,0,0]