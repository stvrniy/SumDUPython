using System;

public class Vector
{
    private double x, y;

    public Vector(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public static Vector operator +(Vector a, Vector b)
    {
        return new Vector(a.x + b.x, a.y + b.y);
    }

    public static Vector operator -(Vector a, Vector b)
    {
        return new Vector(a.x - b.x, a.y - b.y);
    }

    public override string ToString()
    {
        return $"Vector({x}, {y})";
    }
}

public class Point
{
    private int x, y;

    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public static bool operator ==(Point a, Point b)
    {
        return a.x == b.x && a.y == b.y;
    }

    public static bool operator !=(Point a, Point b)
    {
        return !(a == b);
    }
}

public class Time
{
    private int hour, minute;

    public Time(int hour, int minute)
    {
        this.hour = hour;
        this.minute = minute;
    }

    public static bool operator >(Time a, Time b)
    {
        return a.hour > b.hour || (a.hour == b.hour && a.minute > b.minute);
    }

    public static bool operator <(Time a, Time b)
    {
        return !(a > b) && a != b;
    }
}

public class Counter
{
    private int count;

    public Counter(int count)
    {
        this.count = count;
    }

    public static Counter operator ++(Counter c)
    {
        c.count++;
        return c;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Vector v1 = new Vector(1, 2);
        Vector v2 = new Vector(3, 4);

        Vector sum = v1 + v2;
        Vector diff = v1 - v2;

        Console.WriteLine("Сума векторів: " + sum);
        Console.WriteLine("Різниця векторів: " + diff);

        Point p1 = new Point(1, 2);
        Point p2 = new Point(1, 2);
        Console.WriteLine("Чи рівні точки? " + (p1 == p2));

        Time t1 = new Time(10, 30);
        Time t2 = new Time(12, 45);
        Console.WriteLine("Час t1 більший за час t2? " + (t1 > t2));

        Counter counter = new Counter(5);
        counter++;
        Console.WriteLine("Після інкрементування: " + counter);
    }
}
