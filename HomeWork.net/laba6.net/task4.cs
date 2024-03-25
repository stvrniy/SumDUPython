using System;
using System.Collections;

// Інтерфейс для кімнат
interface IRoom : IComparable<IRoom>
{
    double Area { get; } // Площа кімнати
    int WindowCount { get; } // Кількість вікон
}


// Клас, який представляє класну кімнату
class ClassRoom : IRoom
{
    public double Area { get; private set; } // Площа кімнати

    public int WindowCount { get; private set; } // Кількість вікон

    public ClassRoom(double area, int windowCount)
    {
        Area = area;
        WindowCount = windowCount;
    }

    // Реалізація методу CompareTo інтерфейсу IComparable
    public int CompareTo(IRoom other)
    {
        return this.Area.CompareTo(other.Area);
    }
}

// Клас, який представляє мою кімнату
class MyRoom : IRoom
{
    public double Area { get; private set; } // Площа кімнати

    public int WindowCount { get; private set; } // Кількість вікон

    public MyRoom(double area, int windowCount)
    {
        Area = area;
        WindowCount = windowCount;
    }

    // Реалізація методу CompareTo інтерфейсу IComparable
    public int CompareTo(IRoom other)
    {
        return this.Area.CompareTo(other.Area);
    }
}

// Клас для порівняння кімнат за кількістю вікон
class WindowCountComparer : IComparer
{
    public int Compare(object x, object y)
    {
        IRoom room1 = x as IRoom;
        IRoom room2 = y as IRoom;

        if (room1 != null && room2 != null)
        {
            return room1.WindowCount.CompareTo(room2.WindowCount);
        }
        else
        {
            throw new ArgumentException("Неможливо порівняти об'єкти");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Створення об'єктів класних кімнат
        ClassRoom classRoom1 = new ClassRoom(50, 4);
        ClassRoom classRoom2 = new ClassRoom(40, 3);
        ClassRoom classRoom3 = new ClassRoom(60, 5);

        // Створення об'єктів моєї кімнати
        MyRoom myRoom1 = new MyRoom(30, 2);
        MyRoom myRoom2 = new MyRoom(35, 1);

        // Порівняння класних кімнат за площею
        Console.WriteLine("Порівняння класних кімнат за площею:");
        Console.WriteLine(classRoom1.CompareTo(classRoom2)); // Виведе 1, classRoom1 більше за площею
        Console.WriteLine(classRoom2.CompareTo(classRoom3)); // Виведе -1, classRoom2 менше за площею

        // Порівняння моїх кімнат за площею
        Console.WriteLine("\nПорівняння моїх кімнат за площею:");
        Console.WriteLine(myRoom1.CompareTo(myRoom2)); // Виведе -1, myRoom1 менше за площею

        // Створення масиву кімнат для порівняння за кількістю вікон
        IRoom[] rooms = { classRoom1, classRoom2, classRoom3, myRoom1, myRoom2 };

        // Сортування кімнат за кількістю вікон
        Array.Sort(rooms, new WindowCountComparer());

        // Виведення відсортованого масиву
        Console.WriteLine("\nСортування кімнат за кількістю вікон:");
        foreach (IRoom room in rooms)
        {
            Console.WriteLine("Площа: " + room.Area + ", Кількість вікон: " + ((IRoom)room).WindowCount);
        }
    }
}
