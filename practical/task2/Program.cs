using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args) // Задание 2. Перестановка слов в предложении
        {
            Reverse(GetAndSplitText());
            Pause();
        }
        private static string GetAndSplitText()
        {
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();
            return text;
        }
        private static void Reverse(string text)
        {
            string[] array = text.Split(' ');
            int maxValue = array.Length;

            Console.WriteLine("\nВ столбик: ");
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"\n{array[i]}");
            }

            Console.Write("\n\nВ строку: ");
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write($"{array[i]} ");
            }
        }
        private static void Pause()
        {
            Console.ReadKey();
        }
    }
}// благодарю за проверку работы, особенно на выходных