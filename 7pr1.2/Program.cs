using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7pr1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = new string[] { "книга", "карандаш", "ручка", "стол", "ластик" };
            Console.WriteLine("Массив: ");
            for (int i = 0; i < words.Length; i++)
            {
                Console.Write(words[i] + " ");
            }
            //1
            string longword = words[0];
            for (int i = 1; i < words.Length; i++)
            {
                if (words[i].Length > longword.Length)
                {
                    longword = words[i];
                } 
             }
            Console.WriteLine($"Самое длинное слово: {longword}.");
            //2
            Console.Write("Введите подстроку для поиска: ");
            string a = Console.ReadLine();
            Console.WriteLine("Все строки, содержащие заданную подстроку: ");
            bool answer = false;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains(a))
                {
                    Console.WriteLine(words[i]);
                    answer = true;
                }
            }
            if (answer == false)
            {
                Console.WriteLine("Строки с такой подстрокой не найдены");
            }
            //3
            Console.Write("Введите слово для поиска индекса: ");
            string index = Console.ReadLine();

            int num = -1;
            for (int i = 0; i < words.Length; i++)
            {

                if (words[i].Length == index.Length)
                {
                    bool answ = true;
                    for (int n = 0; n < words[i].Length; n++)
                    {
                        if (words[i][n] != index[n])
                        {
                            answ = false;
                            break;
                        }
                    }

                    if (answ)
                    {
                        num = i;
                        break;
                    }
                }
            }

            if (num >= 0)
            {
                Console.WriteLine("Индекс этого слова: " + num);
            }
            else
            {
                Console.WriteLine("Строка не найдена");
            }

        }
    }
}
