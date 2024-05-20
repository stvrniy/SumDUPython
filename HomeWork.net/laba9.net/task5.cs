using System;

delegate int UseOperation(int a, int b);
delegate void GetGreeting();

class Program
{
    static void Main(string[] args)
    {
        // Визначаємо поточний час
        int currentHour = DateTime.Now.Hour;

        // Створюємо делегат GetGreeting
        GetGreeting greetingDelegate;

        // Вибираємо відповідний метод в залежності від часу
        if (currentHour >= 6 && currentHour < 12)
            greetingDelegate = GoodMorning;
        else if (currentHour >= 12 && currentHour < 18)
            greetingDelegate = GoodDay;
        else if (currentHour >= 18 && currentHour < 22)
            greetingDelegate = GoodEvening;
        else
            greetingDelegate = GoodNight;

        // Викликаємо делегат для виведення привітання
        greetingDelegate();

        // Запитуємо в користувача два числа та операцію
        Console.WriteLine("Введіть перше число:");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введіть друге число:");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введіть операцію (+, -, *, /):");
        char operation = char.Parse(Console.ReadLine());

        // Створюємо делегат UseOperation та викликаємо його
        UseOperation operationDelegate = null;
        switch (operation)
        {
            case '+':
                operationDelegate = Add;
                break;
            case '-':
                operationDelegate = Subtract;
                break;
            case '*':
                operationDelegate = Multiply;
                break;
            case '/':
                operationDelegate = Divide;
                break;
            default:
                Console.WriteLine("Неправильна операція!");
                return;
        }

        // Виводимо результат обчислення
        Console.WriteLine($"Результат: {operationDelegate(num1, num2)}");
    }

    // Методи для виведення привітань
    static void GoodMorning()
    {
        Console.WriteLine("Доброго ранку!");
    }

    static void GoodDay()
    {
        Console.WriteLine("Добрий день!");
    }

    static void GoodEvening()
    {
        Console.WriteLine("Добрий вечір!");
    }

    static void GoodNight()
    {
        Console.WriteLine("Доброї ночі!");
    }

    // Методи для обчислень
    static int Add(int a, int b)
    {
        return a + b;
    }

    static int Subtract(int a, int b)
    {
        return a - b;
    }

    static int Multiply(int a, int b)
    {
        return a * b;
    }

    static int Divide(int a, int b)
    {
        if (b == 0)
        {
            Console.WriteLine("Ділення на нуль неможливе!");
            return 0;
        }
        return a / b;
    }
}
