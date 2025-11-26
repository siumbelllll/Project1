using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] books =
            {
                "ВойнаИМир-Толстой-1869-4,8",
                "ПреступлениеИНаказание-Достоевский-1866-4,7",
                "1984-Оруэлл-1949-4,6",
                "МастерИМаргарита-Булгаков-1967-4,9",
                "ВластелинКолец-Толкин-1954-4,8",
                "ГарриПоттер-Роулинг-1997-4,5",
                "ВишневыйСад-Чехов-1904-4,3",
                "НоваяКнига-Автор-2020-4,2"
            };
            Console.WriteLine("===Анализ библиотеки===");
            //Вывод книг с рейтингом больше 4,5
            Console.WriteLine("Книги с рейтингом > 4,5");
            var hightRated = books.Where(b => Convert.ToDouble(b.Split('-')[3]) > 4.5);
            foreach (var hR in hightRated)
            {
                Console.WriteLine($"  - {hR.Split('-')[0]}");
            }
            Console.WriteLine("Книги, выпущенные после 2015");
            var year2015 = books.Where(b => Convert.ToDouble(b.Split('-')[2]) > 2015);
            foreach (var yr in year2015)
            {
                Console.WriteLine($"  - {yr.Split('-')[0]} {yr.Split('-')[2]}");
            }
            //вывод кииг после 2015
            Console.WriteLine("Топ три книги");
            var top3 = books.OrderByDescending(b => Convert.ToDouble(b.Split('-')[3])).Take(3);
            foreach (var y3 in top3)
            {
                Console.WriteLine($" -{y3.Split('-')[0]} {y3.Split('-')[3]}");
            }
            //начинается на В
            Console.WriteLine("Книги, начинающиеся на В");
            var startWithV = books.Where(b => b.StartsWith("В"));
            foreach (var book in startWithV)
            {
                Console.WriteLine(book);
            }
            //самая старая и самая новая книга
            var oldestBook = books.OrderBy(b => Convert.ToInt32(b.Split('-')[2])).First();
            var newestBook = books.OrderByDescending(b => Convert.ToInt32(b.Split('-')[2])).First();
            Console.WriteLine($"Самая старая книга: {oldestBook.Split('-')[0]} {oldestBook.Split('-')[2]} г.");
            Console.WriteLine($"Самая новая книга: {newestBook.Split('-')[0]} {newestBook.Split('-')[2]} г.");
            //средний рейтинг
            var average = books.Average(b => Convert.ToDouble(b.Split('-')[3]));
            Console.WriteLine($"Средний рейтинг книг: {average}");

         }
    }
}
