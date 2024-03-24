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

        Console.WriteLine("Введіть значення a:");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введіть значення k:");
        double k = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("x\t\tf(x)");

        for (double x = xmin; x <= xmax; x += dx)
        {
            double y = 3 * Math.Cos(a * x) + (k * Math.Cos(a * x)) / Math.Log(x);
            Console.WriteLine($"{x}\t\t{y}");
        }
    }
}
