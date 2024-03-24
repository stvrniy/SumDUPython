using System;

class Program
{
    static void Main(string[] args) 
    {
        Console.WriteLine("Введіть значення x_min:");
        double xmin = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введіть значення x_max:");
        double xmax = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введіть значення кроку dx:");
        double dx = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введіть значення c:");
        double c = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("x\t\tf(x)");

        double pi = Math.PI;

        for (double x = xmin; x <= xmax; x += dx)
        {
            double y = 3 * Math.Pow(c, 2) * Math.Pow(x, 2) + (Math.Log(Math.Pow(x, 2) + 1) / (2 * pi));
            Console.WriteLine($"{x}\t\t{y}");
        }
    }
}
