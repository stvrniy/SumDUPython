using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть елементи масиву, розділені пробілом:");
        int[] A = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        // Знаходження мінімального елемента масиву A та його індексу
        int minIndex = 0;
        int min = A[0];
        for (int i = 1; i < A.Length; i++)
        {
            if (A[i] < min)
            {
                min = A[i];
                minIndex = i;
            }
        }

        // Створення масиву B, що містить елементи після мінімального
        int[] B = new int[A.Length - minIndex - 1];
        Array.Copy(A, minIndex + 1, B, 0, A.Length - minIndex - 1);

        // Сортування масиву B за спаданням
        Array.Sort(B);
        Array.Reverse(B);

        // Виведення відсортованого масиву B на екран
        Console.WriteLine("Масив B, відсортований за спаданням:");
        foreach (int element in B)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}
