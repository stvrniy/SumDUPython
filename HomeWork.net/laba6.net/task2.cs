using System;

// Інтерфейс для вимірювальних фігур
interface IMeasurable
{
    double Area(); // Повертає площу фігури
    double Perimeter(); // Повертає периметр фігури
}

// Клас, який представляє квадрат
class Square : IMeasurable
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
}


class Program
{
    static void Main(string[] args)
    {
        // Створення об'єкта квадрата зі стороною 5
        Square square = new Square(5);

        // Виведення площі і периметра квадрата
        Console.WriteLine("Площа квадрата: " + square.Area());
        Console.WriteLine("Периметр квадрата: " + square.Perimeter());
    }
}
