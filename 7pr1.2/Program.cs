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
            string[] words = new string[] { "паоалпр", "прао", "ппо", "ааплаа", "р" };
            Console.WriteLine("Массив: ");
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i] + " ");
            }
            int longLine = 0;
            for (int i = 1; i < words.Length; i++)
            {
                if (words[i].Length > longLine)
                {
                    longLine = words[i].Length;
                } 
             }
           Console.WriteLine(longLine);


           
           
        }
    }
}
