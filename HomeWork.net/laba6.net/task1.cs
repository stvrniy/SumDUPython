using System;

namespace ConsoleApp6
{
    // визначення інтерфейсу
    interface IDemo
    {
        void Show(); // оголошення методу
        double Dlina(); // оголошення методу
        int X { get; } // оголошення властивості, доступного тільки для читання
        int Y { get; } // оголошення властивості Y, доступного тільки для читання
        int this[int i] { get; set; } // оголошення індексатора, доступного для читання запису
    }

    // клас DemoPoint успадковує інтерфейс IDemo
    class DemoPoint : IDemo
    {
        protected int x;
        protected int y;

        public DemoPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Show() // реалізація методу, оголошеного в інтерфейсі  
        {
            Console.WriteLine("точка на площинi: ({0}, {1})", x, y);
        }

        public double Dlina() // реалізація методу, оголошеного в інтерфейсі  
        {
            return Math.Sqrt(x * x + y * y);
        }

        public int X // реалізація властивості, оголошеної в інтерфейсі  
        {
            get
            {
                return x;
            }
        }

        public int Y // реалізація властивості Y, оголошеної в інтерфейсі  
        {
            get
            {
                return y;
            }
        }

        public int this[int i] // реалізація індексатора, оголошеного в інтерфейсі  
        {
            get
            {
                if (i == 0) return x;
                else if (i == 1) return y;
                else throw new Exception("неприпустиме значення індексу");
            }
            set
            {
                if (i == 0) x = value;
                else if (i == 1) y = value;
                else throw new Exception("неприпустиме значення індексу");
            }
        }
    }

    // клас DemoShape успадковує клас DemoPoint і інтерфейс IDemo  
    class DemoShape : DemoPoint, IDemo
    {
        protected int z;

        public DemoShape(int x, int y, int z) : base(x, y)
        {
            this.z = z;
        }

        // реалізація методу, оголошеного в інтерфейсі, з приховуванням однойменного методу з базового класу 
        public new void Show()
        {
            Console.WriteLine("точка в просторi: ({0}, {1}, {2})", x, y, z);
        }

        // реалізація методу, оголошеного в інтерфейсі, з приховуванням однойменного методу з базового класу 
        public new double Dlina()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }

        // реалізація індексатора, оголошеного в інтерфейсі, з приховуванням  
        // однойменного індексатора з базового класу 
        public new int this[int i]
        {
            get
            {
                if (i == 0) return x;
                else if (i == 1) return y;
                else if (i == 2) return z;
                else throw new Exception("неприпустиме значення індексу");
            }
            set
            {
                if (i == 0) x = value;
                else if (i == 1) y = value;
                else if (i == 2) z = value;
                else throw new Exception("неприпустиме значення індексу");
            }
        }
    }
}
namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Створення об'єкта DemoPoint
            DemoPoint point2D = new DemoPoint(3, 4);
            Console.WriteLine("DemoPoint:");
            point2D.Show(); // виклик методу Show() для відображення точки
            Console.WriteLine("Dlina: " + point2D.Dlina()); // виклик методу Dlina() для відображення довжини
            Console.WriteLine("X: " + point2D.X); // виведення значення X
            Console.WriteLine("Y: " + point2D.Y); // виведення значення Y
            Console.WriteLine();

            // Створення об'єкта DemoShape
            DemoShape point3D = new DemoShape(1, 2, 3);
            Console.WriteLine("DemoShape:");
            point3D.Show(); // виклик методу Show() для відображення точки
            Console.WriteLine("Dlina: " + point3D.Dlina()); // виклик методу Dlina() для відображення довжини
            Console.WriteLine("X: " + point3D.X); // виведення значення X
            Console.WriteLine("Y: " + point3D.Y); // виведення значення Y
            Console.WriteLine("Z: " + point3D[2]); // виведення значення Z через індексатор
        }
    }
}
