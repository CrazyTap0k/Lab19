using System;
using System.Text;

namespace Lab19
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine("Лабораторна робота №19");
            Console.WriteLine("Варіант 7");
            Console.WriteLine("Завдання: витерти з заданого рядка всі пробіли.");
            Console.WriteLine();

            Console.Write("Введіть рядок: ");
            string text = Console.ReadLine() ?? "";

            string result = RemoveSpaces(text);

            Console.WriteLine();
            Console.WriteLine("Початковий рядок:");
            Console.WriteLine(text);
            Console.WriteLine();
            Console.WriteLine("Рядок без пробілів:");
            Console.WriteLine(result);

            Console.WriteLine();
            Console.WriteLine("Натисніть будь-яку клавішу для завершення...");
            Console.ReadKey();
        }

        static string RemoveSpaces(string text)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ')
                {
                    result.Append(text[i]);
                }
            }

            return result.ToString();
        }
    }
}
