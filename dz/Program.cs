using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создание массива на 20 чисел
            int[] numbers = new int[20];
            Random random = new Random();//Coздаем генератор случайных чисел
            //Заполнение массива ранодомными числами от 1 до 100
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 101);//Next(min, max) дает числа от мин до мах - 1
            }
            Console.WriteLine("Массив: ");
            //выводим массив
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            //Инициализируем счетчики
            int min = numbers[0];
            int max = numbers[0];
            int minIndex = 0;
            int maxIndex = 0;
            int duplicates = 0;
            int second = 0;
            //1 Поиск минимального и максимального элемента и 2 Поиск индексов минимального и максимального элемента
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                    minIndex = i;
                }
                if (numbers[i] > max)
                {
                    max = numbers[i];
                    maxIndex = i;
                }
            }
           
            //3 Проверка наличия дубликатов в массиве
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int a = i + 1; a < numbers.Length; a++)
                {
                    if (numbers[i] == numbers[a])
                    {
                        duplicates++;
                    }
                }
            }
            //4 Поиск второго по величине элемента
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > second && numbers[i] < max)
                {
                    second = numbers[i];
                }
            }
            //Вывод результатов
            Console.WriteLine();
            Console.WriteLine($"Минимальный элемент: {min}. Максимальный элемент: {max}. ");
            Console.WriteLine($"Индекс минимального элемента: {minIndex}. Индекс максимального элемента: {maxIndex}. ");
            Console.WriteLine($"Наличие дубликатов: " + (duplicates>0? "Да" : "Нет"));
            Console.WriteLine($"Второй по величине элемент: {second}. ");
        }
    }
}
