using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть кількість рядків матриці:");
        int rows = int.Parse(Console.ReadLine());

        Console.WriteLine("Введіть кількість стовпчиків матриці:");
        int columns = int.Parse(Console.ReadLine());

        // Ініціалізація та заповнення матриці
        double[,] matrix = new double[rows, columns];
        Console.WriteLine("Введіть елементи матриці:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"Елемент [{i},{j}]: ");
                matrix[i, j] = double.Parse(Console.ReadLine());
            }
        }

        // Знаходження середнього арифметичного для кожного рядка
        double[] rowAverages = new double[rows];
        for (int i = 0; i < rows; i++)
        {
            double sum = 0;
            for (int j = 0; j < columns; j++)
            {
                sum += matrix[i, j];
            }
            rowAverages[i] = sum / columns;
        }

        // Віднімання середнього арифметичного від кожного елементу рядка
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                matrix[i, j] -= rowAverages[i];
            }
        }

        // Виведення нової матриці на екран
        Console.WriteLine("Нова матриця після віднімання середнього арифметичного від кожного рядка:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
