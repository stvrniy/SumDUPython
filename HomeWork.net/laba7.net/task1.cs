using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static bool IsBalanced(string expression)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char c in expression)
        {
            if (c == '(')
            {
                stack.Push(c);
            }
            else if (c == ')')
            {
                if (stack.Count == 0 || stack.Peek() != '(')
                {
                    return false;
                }
                stack.Pop();
            }
        }

        return stack.Count == 0;
    }

    static void Main(string[] args)
    {
        try
        {
            string filePath = "expression.txt"; // Шлях до файлу з виразом

            // Зчитуємо вміст файлу
            string expression;
            using (StreamReader sr = new StreamReader(filePath))
            {
                expression = sr.ReadToEnd();
            }

            // Перевіряємо баланс дужок
            bool isBalanced = IsBalanced(expression);

            if (isBalanced)
            {
                Console.WriteLine("Дужки у виразi збалансованi.");
            }
            else
            {
                Console.WriteLine("У виразi незбалансованi дужки.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Помилка: " + ex.Message);
        }
    }
}
