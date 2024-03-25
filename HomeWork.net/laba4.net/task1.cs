using System;

class A
{
    private int a;
    private int b;

    // Конструктор за замовчуванням
    public A()
    {
        a = 5; // Приклад значення для поля a
        b = 3; // Приклад значення для поля b
    }

    // Властивість С, яка повертає результат операції над полями a і b
    public int C
    {
        get { return a + b; } // Приклад операції (додавання значень полів a і b)
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Створюємо об'єкт класу A
        A objA = new A();

        // Виводимо на екран значення властивості C об'єкта objA
        Console.WriteLine("Значення властивості C: " + objA.C);
    }
}
