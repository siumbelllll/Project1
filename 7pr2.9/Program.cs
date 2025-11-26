using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7pr2._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students =
            {
             "Гараева Сюмбель,5,4,5,4",
             "Гайнуллина Наргиза,4,5,4,5",
             "Хасанова Илюза,5,5,5,4",
             "Хакимзянова Ильзиля,5,5,5,5",
             "Гиззатуллин Ильгам,2,3,4,2",
             "Асхадуллин Ислам,4,2,3,4",
             "Хайретдинова Рахима,5,4,5,4",
            };

            string[] subjects = { "Математика", "Русский язык", "История", "Химия" };
            Console.WriteLine("Оценки студентов по предметам(математика, русский язык, история, химия):");
            foreach (string stud in students)
            {
                string[] parts = stud.Split(',');
                Console.WriteLine($"{parts[0]}, {parts[1]}, {parts[2]}, {parts[3]}, {parts[4]}");

            }
            //поиск студентов со средним баллом выше заданного
            Console.WriteLine("Введите средний балл для поиска студента: ");

            double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Студенты со средним баллом выше {number}:");
            foreach (string stud in students)
            {
                string[] parts = stud.Split(',');
                string name = parts[0];
                double sum = 0;
                for (int i = 1; i < parts.Length; i++)
                {
                    sum += Convert.ToInt32(parts[i]);
                }
                double average = sum / (parts.Length - 1);
                if (average > number)
                {
                    Console.WriteLine($"{name}, Средний балл: {average}");
                }

            }
            //определение предмета с наивысшим средним баллом
            Console.WriteLine("Предмет с наивысшим средним баллом: ");
            double thehighestAverage = 0;
            string sub = "";
            for (int i = 0; i < subjects.Length; i++)
            {
                double sum = 0;
                for (int j = 0; j < students.Length; j++)
                {
                    string[] parts = students[j].Split(',');
                    sum += Convert.ToInt32(parts[i + 1]);
                }
                double average = sum / students.Length;
                if (average > thehighestAverage)
                {
                    thehighestAverage = average;
                    sub = subjects[i];
                }
            }
            Console.WriteLine($"{sub}, Средний балл: {thehighestAverage:F1}");
            Console.WriteLine();

            //рейтинг студдентов по успеваемости
            Console.WriteLine("Рейтинг студентов по успеваемости: ");
            string[] rating = new string[students.Length];

            for (int i = 0; i < students.Length; i++)
            {
                string[] parts = students[i].Split(',');
                string name = parts[0];
                double sum = 0;
                for (int j = 1; j < parts.Length; j++)
                {
                    sum += Convert.ToInt32(parts[j]);
                }
                double average = sum / (parts.Length - 1);

                rating[i] = $"{name},{average:F2}";
            }

            for (int i = 0; i < rating.Length - 1; i++)
            {
                for (int j = i + 1; j < rating.Length; j++)
                {
                    string[] parts1 = rating[i].Split(',');
                    string[] parts2 = rating[j].Split(',');

                    double avg1 = Convert.ToInt32(parts1[1]);
                    double avg2 = Convert.ToInt32(parts2[1]);

                    if (avg1 < avg2)
                    {
                        string temp = rating[i];
                        rating[i] = rating[j];
                        rating[j] = temp;
                    }
                }
            }
            for (int i = 0; i < rating.Length; i++)
            {
                string[] parts = rating[i].Split(',');
                Console.WriteLine($"{i + 1} - {parts[0]}, {parts[1]}");
            }
            foreach (string student in students)
            {
                string[] parts = student.Split(',');
                string name = parts[0];
                double sum = 0;
                for (int i = 1; i < parts.Length; i++)
                {
                    sum += Convert.ToInt32(parts[i]);
                }
                double average = sum / (parts.Length - 1);
                if (average == 5)
                { Console.WriteLine($"{name} - Отличник"); }
                else if (average < 3) { Console.WriteLine($"{name} - Двоечник"); }
            }
        }
    }
}
