using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical
{
    internal class Program
    {
        static void Main(string[] args) // Задание 1. Метод разделения строки на слова
        {
            SplitText(GetText());


            //foreach (string i in SplittingText(GettingText())) // выриант с выводом через foreach
            //{
            //    Console.WriteLine($"\n{i}");
            //}

            //GetAndSplitText();// вариант решения одним методом

            Pause();
        }

        /// <summary>
        /// 1.0) Мой первоначальный метод получения текста.
        /// </summary>
        /// <returns></returns>
        private static string[] GetText()
        {
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();
            string[] array = text.Split(' ');

            Console.WriteLine($"\nПервоначальный текст: {text}");
            return array;
        }
        /// <summary>
        /// 1.1) Мой первоначальный метод разделения текста.
        /// </summary>
        /// <param name="array"></param>
        private static void SplitText(string [] array)
        {
            Console.WriteLine("\nРазделенный текст: ");
            foreach (string i in array)
            {
                Console.WriteLine($"\n{i}");
            }
        }
        /// <summary>
        /// 2.0) метод получения текста вроде как по заданию
        /// </summary>
        /// <returns></returns>
        private static string GettingText()
        {
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();
            return text;
        }
        /// <summary>
        /// 2.1) метод разделения текста вроде как по заданию
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private static string[] SplittingText(string text)
        {
            Console.WriteLine("\nРазделенный текст: ");
            string[] array = text.Split(' ');
            return array;
        }
        /// <summary>
        /// 3.0) решение одним методом, сделал ради интереса
        /// </summary>
        private static void GetAndSplitText() 
        {
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();
            string[] array = text.Split(' '); //кстати это интересно в интернете искать информацию и пытаться писать код

            Console.WriteLine($"\nПервоначальный текст: {text}");
            Console.WriteLine("\nРазделенный текст: ");

            foreach (string i in array)
            {
                Console.WriteLine($"\n{i}");
            }
        }
        /// <summary>
        /// пауза
        /// </summary>
        private static void Pause()
        {
            Console.ReadKey();
        }
    }
}