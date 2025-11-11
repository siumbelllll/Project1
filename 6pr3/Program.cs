using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6pr3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer;
            do
            {
                Console.WriteLine("привет!");
                Console.WriteLine("Повторить? (y - да, n - нет)");
                answer = Convert.ToString(Console.ReadLine());
            }
            while (answer == "y");

        }
    }
}
