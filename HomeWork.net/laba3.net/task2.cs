using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть кількість співробітників:");
        int count = int.Parse(Console.ReadLine());

        // Визначення меж для генератора випадкових чисел
        int minHeight = 150;
        int maxHeight = 200;
        int minWeight = 50;
        int maxWeight = 100;

        // Ініціалізація генератора випадкових чисел
        Random random = new Random();

        // Створення та заповнення масивів зросту і ваги співробітників
        int[] heights = new int[count];
        int[] weights = new int[count];
        for (int i = 0; i < count; i++)
        {
            heights[i] = random.Next(minHeight, maxHeight + 1);
            weights[i] = random.Next(minWeight, maxWeight + 1);
        }

        // Сортування масиву зросту за зростанням
        Array.Sort(heights);

        // Виведення результатів на екран
        Console.WriteLine("Результати сортування за зростанням:");
        Console.WriteLine("Зріст (см)\tВага (кг)");
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"{heights[i]}\t\t{weights[i]}");
        }
    }
}
