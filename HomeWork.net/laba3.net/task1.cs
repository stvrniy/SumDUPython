using System;
class Program
{
    static void Main(string[] args)
    {
        // Визначення кількості елементів у масивах
        int length = 10; // Можна змінювати кількість елементів

        // Визначення меж для генератора випадкових чисел
        int minValue = 0;
        int maxValue = 100; // Можна змінювати верхню межу

        // Ініціалізація генератора випадкових чисел
        Random random = new Random();

        // Створення та заповнення першого масиву
        int[] array1 = new int[length];
        for (int i = 0; i < length; i++)
        {
            array1[i] = random.Next(minValue, maxValue);
        }

        // Створення копії першого масиву для другого масиву
        int[] array2 = new int[length];
        Array.Copy(array1, array2, length);

        // Сортування першого масиву за зростанням
        Array.Sort(array1);
        // Виведення відсортованого масиву та копії на екран
        Console.WriteLine("Перший масив (відсортований за зростанням):");
        PrintArray(array1);

        Console.WriteLine("\nДругий масив (копія першого масиву):");
        PrintArray(array2);
    }
    // Метод для виведення масиву на екран
    static void PrintArray(int[] array)
    {
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
    }
}
