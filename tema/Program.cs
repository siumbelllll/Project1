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

        }
    }
}
