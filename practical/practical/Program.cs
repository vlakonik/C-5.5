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


        private static string[] GetText()
        {
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();
            string[] array = text.Split(' ');

            Console.WriteLine($"\nПервоначальный текст: {text}");
            return array;
        }// 1.0) Мой первоначальный метод получения текста.
        private static void SplitText(string [] array)
        {
            Console.WriteLine("\nРазделенный текст: ");
            foreach (string i in array)
            {
                Console.WriteLine($"\n{i}");
            }
        }// 1.1) Мой первоначальный метод разделения текста.


        private static string GettingText()// 2.0) метод получения текста вроде как по заданию
        {
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();
            return text;
        }
        private static string[] SplittingText(string text) // 2.1) метод разделения текста вроде как по заданию
        {
            Console.WriteLine("\nРазделенный текст: ");
            string[] array = text.Split(' ');
            return array;
        }

        private static void GetAndSplitText() // 3.0) решение одним методом, сделал ради интереса
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

        private static void Pause()
        {
            Console.ReadKey();
        }// пауза
    }
}