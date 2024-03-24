using System;
	class Program
	{
	    static void Main(string[] args)
	    {
	        Console.WriteLine("Введіть значення x:");
	        double x = Convert.ToDouble(Console.ReadLine());
	
	        Console.WriteLine("Введіть значення c:");
	        double c = Convert.ToDouble(Console.ReadLine());
	
	        Console.WriteLine("Введіть значення a:");
	        double a = Convert.ToDouble(Console.ReadLine());
	
	        double y = 3 * c * x - a + (Math.Log(x) / (2 * Math.Sin(Math.PI / 3 + x)));
	
	        Console.WriteLine($"Результат: y = {y}");
	    }
	
	    
	}
