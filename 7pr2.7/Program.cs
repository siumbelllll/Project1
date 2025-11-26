using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7pr2._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] tovars =
        {
         "Футболка-600-Одежда",
         "Кресло-43000-Мебель",
         "Карандаш-45-Канцелярия",
         "Джинсы-3500-Одежда",
         "Диван-55000-Мебель",
         "Ластик-25-Канцелярия"
        };
            Console.WriteLine("Анализ товаров");
            Console.WriteLine("Товары по определенной категории: Мебель");
            var wear = tovars.Where(b => b.Split('-')[2] == "Мебель");
            foreach (var wr in wear)
            {
                Console.WriteLine($" - {wr.Split('-')[0]}");
            }

            Console.WriteLine("Товары в определенном ценовом диапазоне");
            var price = tovars.Where(b => Convert.ToInt32(b.Split('-')[1]) > 0 && Convert.ToInt32(b.Split('-')[1]) < 1500);
            foreach (var pr in price)
            {
                Console.WriteLine($" -{pr.Split('-')[0]} {pr.Split('-')[1]}");
            }

            Console.WriteLine("Товары по возрастанию цены");
            var pric = tovars.OrderBy(b => Convert.ToDouble(b.Split('-')[1]));
            foreach (var pri in pric)
            {
                Console.WriteLine($" -{pri.Split('-')[0]} {pri.Split('-')[1]}");
            }
        }
    }
}
