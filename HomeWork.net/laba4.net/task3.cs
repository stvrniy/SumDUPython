using System;

// Базовий клас Ship
class Ship
{
    // Поля
    protected string name;
    protected string purpose;
    protected double displacement; // водотоннажність
    protected double enginePower;
    protected string fuelType;

    // Конструктор
    public Ship(string name, string purpose, double displacement, double enginePower, string fuelType)
    {
        this.name = name;
        this.purpose = purpose;
        this.displacement = displacement;
        this.enginePower = enginePower;
        this.fuelType = fuelType;
    }

    // Метод виведення інформації про корабель на екран
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Назва: {name}");
        Console.WriteLine($"Призначення: {purpose}");
        Console.WriteLine($"Водотоннажність: {displacement} тон");
        Console.WriteLine($"Потужність двигуна: {enginePower} кВт");
        Console.WriteLine($"Тип палива: {fuelType}");
    }
}

// Похідний клас AircraftCarrier (авіаносець)
class AircraftCarrier : Ship
{
    // Додаткові поля
    private string[] aircraftTypes; // типи літаків
    private int[] aircraftCounts; // кількість літаків

    // Конструктор
    public AircraftCarrier(string name, string purpose, double displacement, double enginePower, string fuelType,
                           string[] aircraftTypes, int[] aircraftCounts)
                           : base(name, purpose, displacement, enginePower, fuelType)
    {
        this.aircraftTypes = aircraftTypes;
        this.aircraftCounts = aircraftCounts;
    }

    // Перевизначений метод виведення інформації про корабель на екран
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Літаки на борту:");
        for (int i = 0; i < aircraftTypes.Length; i++)
        {
            Console.WriteLine($"{aircraftTypes[i]}: {aircraftCounts[i]}");
        }
    }
}

// Похідний клас MissileCarrier (ракетоносець)
class MissileCarrier : Ship
{
    // Додаткові поля
    private string missileType; // тип ракет
    private int missileCount; // кількість ракет

    // Конструктор
    public MissileCarrier(string name, string purpose, double displacement, double enginePower, string fuelType,
                           string missileType, int missileCount)
                           : base(name, purpose, displacement, enginePower, fuelType)
    {
        this.missileType = missileType;
        this.missileCount = missileCount;
    }

    // Перевизначений метод виведення інформації про корабель на екран
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Тип ракет: {missileType}");
        Console.WriteLine($"Кількість ракет: {missileCount}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Створюємо об'єкт AircraftCarrier
        string[] aircraftTypes = { "Fighter", "Bomber", "Transport" };
        int[] aircraftCounts = { 30, 20, 10 };
        AircraftCarrier aircraftCarrier = new AircraftCarrier("USS Enterprise", "Aircraft Carrier", 80000, 200000, "Nuclear",
                                                              aircraftTypes, aircraftCounts);

        // Виводимо інформацію про авіаносець на екран
        Console.WriteLine("Інформація про авіаносець:");
        aircraftCarrier.DisplayInfo();
        Console.WriteLine();

        // Створюємо об'єкт MissileCarrier
        MissileCarrier missileCarrier = new MissileCarrier("Kirov", "Missile Cruiser", 30000, 150000, "Diesel",
                                                           "Cruise Missile", 100);

        // Виводимо інформацію про ракетоносець на екран
        Console.WriteLine("Інформація про ракетоносець:");
        missileCarrier.DisplayInfo();
    }
}
