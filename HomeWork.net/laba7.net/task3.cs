using System;
using System.Collections;
using System.IO;

class Person : IComparable
{
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public int Age { get; set; }
    public double Weight { get; set; }

    public int CompareTo(object obj)
    {
        if (obj == null) return 1;

        Person otherPerson = obj as Person;
        if (otherPerson != null)
            return this.Age.CompareTo(otherPerson.Age);
        else
            throw new ArgumentException("Object is not a Person");
    }

    public override string ToString()
    {
        return $"{LastName} {FirstName} {MiddleName}, {Age} років, {Weight} кг";
    }
}

class Program
{
    static void Main(string[] args)
    {
        ArrayList people = new ArrayList();

        try
        {
            string filePath = "people.txt"; // шлях до файлу з інформацією про людей

            // Зчитуємо вміст файлу та додаємо дані в ArrayList
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(' ');
                    Person person = new Person
                    {
                        LastName = parts[0],
                        FirstName = parts[1],
                        MiddleName = parts[2],
                        Age = int.Parse(parts[3]),
                        Weight = double.Parse(parts[4])
                    };

                    people.Add(person);
                }
            }

            // Сортуємо ArrayList за віком
            people.Sort();

            // Виводимо відсортовані дані на екран
            Console.WriteLine("Дані про людей, відсортовані за віком:");
            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Помилка: " + ex.Message);
        }
    }
}
