using System;

// Інтерфейс для вимірювальних фігур
interface IMeasurable
{
    double Area(); // Повертає площу фігури
    double Perimeter(); // Повертає периметр фігури
}

class Square : IMeasurable, IComparable<Square>
{
    private double sideLength; // Довжина сторони квадрата

    // Конструктор класу Square
    public Square(double sideLength)
    {
        this.sideLength = sideLength;
    }

    // Реалізація методу Area() інтерфейсу IMeasurable
    public double Area()
    {
        return sideLength * sideLength; // Формула площі квадрата: сторона * сторона
    }

    // Реалізація методу Perimeter() інтерфейсу IMeasurable
    public double Perimeter()
    {
        return 4 * sideLength; // Формула периметра квадрата: 4 * сторона
    }

    // Реалізація методу CompareTo інтерфейсу IComparable<Square>
    public int CompareTo(Square other)
    {
        if (other == null)
            return 1;

        // Порівнюємо квадрати за величиною периметра
        double perimeterDifference = this.Perimeter() - other.Perimeter();
        if (perimeterDifference < 0)
            return -1;
        else if (perimeterDifference > 0)
            return 1;
        else
            return 0; // Якщо периметри рівні
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Створення кількох об'єктів Square для порівняння
        Square square1 = new Square(5);
        Square square2 = new Square(7);
        Square square3 = new Square(3);

        // Виведення площі і периметра кожного квадрата
        Console.WriteLine("Square 1:");
        Console.WriteLine("Площа: " + square1.Area());
        Console.WriteLine("Периметр: " + square1.Perimeter());

        Console.WriteLine("Square 2:");
        Console.WriteLine("Площа: " + square2.Area());
        Console.WriteLine("Периметр: " + square2.Perimeter());

        Console.WriteLine("Square 3:");
        Console.WriteLine("Площа: " + square3.Area());
        Console.WriteLine("Периметр: " + square3.Perimeter());

        // Порівняння квадратів за периметром
        Console.WriteLine("\nПорівняння квадратів за периметром:");

        if (square1.CompareTo(square2) < 0)
            Console.WriteLine("Square 1 має менший периметр, ніж Square 2");
        else if (square1.CompareTo(square2) > 0)
            Console.WriteLine("Square 1 має більший периметр, ніж Square 2");
        else
            Console.WriteLine("Периметри квадратів Square 1 та Square 2 рівні");

        if (square1.CompareTo(square3) < 0)
            Console.WriteLine("Square 1 має менший периметр, ніж Square 3");
        else if (square1.CompareTo(square3) > 0)
            Console.WriteLine("Square 1 має більший периметр, ніж Square 3");
        else
            Console.WriteLine("Периметри квадратів Square 1 та Square 3 рівні");
    }
}
