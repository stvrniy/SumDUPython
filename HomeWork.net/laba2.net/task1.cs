using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть кількість рядків матриці:");
        int rows = int.Parse(Console.ReadLine());

        Console.WriteLine("Введіть кількість стовпчиків матриці:");
        int columns = int.Parse(Console.ReadLine());

        // Ініціалізація матриці
        int[,] matrix = new int[rows, columns];

        // Заповнення матриці користувачем
        Console.WriteLine("Введіть елементи матриці:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"Елемент [{i},{j}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Введення вектора
        int[] vector = new int[columns];
        Console.WriteLine("Введіть елементи вектора:");
        for (int i = 0; i < columns; i++)
        {
            Console.Write($"Елемент [{i}]: ");
            vector[i] = int.Parse(Console.ReadLine());
        }

        // Помноження матриці на вектор
        int[] result = new int[rows];
        for (int i = 0; i < rows; i++)
        {
            int sum = 0;
            for (int j = 0; j < columns; j++)
            {
                sum += matrix[i, j] * vector[j];
            }
            result[i] = sum;
        }

        // Виведення результату
        Console.WriteLine("Результат множення матриці на вектор:");
        for (int i = 0; i < rows; i++)
        {
            Console.WriteLine(result[i]);
        }
    }
}
