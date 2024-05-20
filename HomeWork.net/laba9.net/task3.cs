using System;

namespace Geometry
{
    // Оголошення типу делегату
    delegate double CircleOperation(double radius);

    // Клас, який містить методи для обчислення параметрів кола
    class CircleCalculator
    {
        // Метод для обчислення довжини кола
        public double CalculateCircumference(double radius)
        {
            return 2 * Math.PI * radius;
        }

        // Метод для обчислення площі кола
        public double CalculateArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        // Метод для обчислення об'єму кулі
        public double CalculateVolume(double radius)
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Створення екземпляра класу з методами для обчислення параметрів кола
            CircleCalculator calculator = new CircleCalculator();

            // Створення делегата і його ініціалізація вказівниками на методи класу CircleCalculator
            CircleOperation circleOperation = calculator.CalculateCircumference;
            circleOperation += calculator.CalculateArea;
            circleOperation += calculator.CalculateVolume;

            // Виклик методів через делегат з передачею одного і того ж аргументу (радіус кола)
            double radius = 5.0; // Приклад значення радіуса кола
            foreach (CircleOperation operation in circleOperation.GetInvocationList())
            {
                double result = operation(radius);
                Console.WriteLine($"Результат: {result}");
            }
        }
    }
}
