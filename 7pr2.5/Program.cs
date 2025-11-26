using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7pr2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] staff =
            {
            "Гараева Сюмбель Маратовна-Специалист по информационным системам",
            "Гараева Сирина Маратовна-Фармацевт",
            "Гайнуллина Наргиза Азатовна-Медсестра",
            "Хайретдинова Рахима Фаязовна-Педагог",
            "Фасихова Резеда Раифовна-Педагог",
            "Аглуллина Адиля Рамилевна-Юрист",
            };
            Console.WriteLine("Анализ сотрудников:"); 
            for (int i = 0; i < staff.Length; i++)
            {
                Console.WriteLine($"{staff[i]}");
            }
            Console.WriteLine();

            Console.Write("Введите должность сотрудника для поиска: ");
            string search = Console.ReadLine();
            var sear = staff.Where(b => Convert.ToString(b.Split('-')[1]) == search);
            foreach (var sr in sear)
            {
                Console.WriteLine($"  - {sr.Split('-')[0]} {sr.Split('-')[1]}");
            }
            Console.WriteLine("Введите букву для поиска фамилии сотрудника: ");
            string a = Console.ReadLine();
            Console.WriteLine("Сотрудники, фамилии которых начинаются нa " + a + ": ");
            var surname = staff.Where(b => b.Split('-')[0].StartsWith(a));
            foreach (var surn in surname)
            {
                Console.WriteLine($" - {surn.Split('-')[0]} ({surn.Split('-')[1]})");
            }

            Console.WriteLine("Результаты по алфавиту: ");
            var alphabet = staff.OrderBy(b => b.Split('-')[0]);
            foreach (var alph in alphabet)
            {
                Console.WriteLine($" - {alph.Split('-')[0]} - {alph.Split('-')[1]}");
            }

         }
    }
}
