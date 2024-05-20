using System;
using System.IO;
using System.Text.RegularExpressions;

namespace FileProcessing
{
    public static class FileProcessor
    {
        public static void ReadFile(string filePath, Action<string> action)
        {
            // Перевіряємо, чи існує файл за вказаним шляхом
            if (!File.Exists(filePath))
            {
                Console.WriteLine($"Файл {filePath} не існує.");
                return;
            }

            try
            {
                // Читаємо вміст файлу
                string fileContent = File.ReadAllText(filePath);

                // Виводимо вміст файлу на екран
                Console.WriteLine("Вміст файлу:");
                Console.WriteLine(fileContent);

                // Виконуємо задану дію над вмістом файлу
                action(fileContent);

                // Виводимо змінений вміст файлу на екран
                Console.WriteLine("Змінений вміст файлу:");
                Console.WriteLine(fileContent);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
        }

        // Дія для виведення на екран всіх чисел у тексті
        public static void PrintNumbers(string text)
        {
            Console.WriteLine("Числа у тексті:");
            foreach (Match match in Regex.Matches(text, @"\b\d+\b"))
            {
                Console.WriteLine(match.Value);
            }
        }

        // Дія для заміни символів у файлі
        public static void ReplaceSymbols(string text)
        {
            text = Regex.Replace(text, @"[.,*()]", " ");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "sample.txt";

            // Виклик методу ReadFile з дією виведення чисел та заміни символів
            FileProcessor.ReadFile(filePath, FileProcessor.PrintNumbers);
            FileProcessor.ReadFile(filePath, FileProcessor.ReplaceSymbols);
        }
    }
}
