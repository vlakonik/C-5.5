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

            //ReverseMethod(GetAndSplitText());

            Pause();
        }
        private static string GetAndSplitText()
        {
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();
            return text;
        }
        /// <summary>
        /// Метод через цикл for()
        /// </summary>
        /// <param name="text"></param>
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
        /// <summary>
        /// Это вариант с методом Array.Reverse(), а не через цикл for()
        /// </summary>
        /// <param name="text"></param>
        private static void ReverseMethod(string text)
        {
            string[] array = text.Split(' ');
            Array.Reverse(array);

            Console.WriteLine("\nВ столбик: ");
            foreach (string i in array)
            {
                Console.WriteLine($"\n{i}");
            }
        }



        private static void Pause()
        {
            Console.ReadKey();
        }
    }
}// благодарю за проверку работы, особенно на выходных