using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6pr1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numb;
            do
            {
                Console.WriteLine("Введите пароль: ");
                numb = Convert.ToInt32(Console.ReadLine());
            }
            while (numb != 1234);
            Console.WriteLine("Вы ввели правильное число");

            

        }
    }
}
