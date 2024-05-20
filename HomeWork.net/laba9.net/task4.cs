using System;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        // Оголошення делегата для виконання операцій
        delegate int Operation(int a, int b);

        static void Main(string[] args)
        {
            // Створення словника для зберігання рядків (ключів) та відповідних методів/делегатів (значень)
            Dictionary<string, Operation> op = new Dictionary<string, Operation>();

            // Додавання методів/делегатів до словника
            op["add"] = (a, b) => a + b;
            op["mult"] = (a, b) => a * b;

            // Виклик методів зі словника та виведення результатів
            Console.WriteLine(op["add"](5, 3)); // Виведе 8
            Console.WriteLine(op["mult"](6, 7)); // Виведе 42

            Console.ReadLine();
        }
    }
}
