using System;

namespace MatrixOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Розмірність матриці
            int rows = 4;
            int columns = 4;

            // Створення і заповнення матриці випадковими числами
            double[,] matrix = new double[rows, columns];
            Random random = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = random.Next(-10, 11); // Генеруємо випадкові числа в діапазоні від -10 до 10
                }
            }

            // Вивід початкової матриці
            Console.WriteLine("Початкова матриця:");
            PrintMatrix(matrix);

            // Вивід позитивних елементів головної діагоналі
            Console.WriteLine("\nПозитивні елементи головної діагоналі:");
            PrintMainDiagonalPositiveElements(matrix);

            // Зміна матриці згідно вказаних умов
            ChangeMatrix(matrix, (i, j, value) =>
            {
                if (i > j && value > 0)
                {
                    return value * 3; // Збільшення втричі позитивних елементів під головною діагоналлю
                }
                return value;
            });

            // Вивід зміненої матриці
            Console.WriteLine("\nЗмінена матриця:");
            PrintMatrix(matrix);
        }

        // Метод для виведення матриці на екран
        static void PrintMatrix(double[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{matrix[i, j],5} ");
                }
                Console.WriteLine();
            }
        }

        // Метод для виведення позитивних елементів головної діагоналі
        static void PrintMainDiagonalPositiveElements(double[,] matrix)
        {
            int size = Math.Min(matrix.GetLength(0), matrix.GetLength(1));
            for (int i = 0; i < size; i++)
            {
                if (matrix[i, i] > 0)
                {
                    Console.Write($"{matrix[i, i],5} ");
                }
            }
            Console.WriteLine();
        }

        // Метод для зміни матриці на основі заданого делегата
        static void ChangeMatrix(double[,] matrix, Func<int, int, double, double> changeFunction)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = changeFunction(i, j, matrix[i, j]);
                }
            }
        }
    }
}
