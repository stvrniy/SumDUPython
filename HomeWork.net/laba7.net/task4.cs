using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            string inputFilePath = "input.txt"; // шлях до вхідного файлу
            string outputFilePath = "output.txt"; // шлях до вихідного файлу

            // Створюємо стек для зберігання чисел
            Stack<int> numbersStack = new Stack<int>();

            // Зчитуємо числа з вхідного файлу та додаємо їх у стек
            using (StreamReader sr = new StreamReader(inputFilePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    int number = int.Parse(line);
                    numbersStack.Push(number);
                }
            }

            // Записуємо числа зі стеку у вихідний файл (зворотній порядок)
            using (StreamWriter sw = new StreamWriter(outputFilePath))
            {
                while (numbersStack.Count > 0)
                {
                    int number = numbersStack.Pop();
                    sw.WriteLine(number);
                }
            }

            Console.WriteLine("Числа успішно переписані у зворотньому порядку у файл " + outputFilePath);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Помилка: " + ex.Message);
        }
    }
}
