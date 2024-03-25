using System;
using System.Collections.Generic;
using System.IO;

class Person
{
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public int Age { get; set; }
    public double Weight { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Queue<Person> peopleYoungerThan40 = new Queue<Person>();
        Queue<Person> peopleOlderThan40 = new Queue<Person>();

        try
        {
            string filePath = "people.txt"; // Шлях до файлу з інформацією про людей

            // Зчитуємо вміст файлу та додаємо дані в чергу
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

                    if (person.Age < 40)
                    {
                        peopleYoungerThan40.Enqueue(person);
                    }
                    else
                    {
                        peopleOlderThan40.Enqueue(person);
                    }
                }
            }

            // Виводимо інформацію про людей молодше 40 років
            Console.WriteLine("Дані про людей молодше 40 років:");
            while (peopleYoungerThan40.Count > 0)
            {
                PrintPersonData(peopleYoungerThan40.Dequeue());
            }

            // Виводимо інформацію про інших людей
            Console.WriteLine("\nДані про інших людей:");
            while (peopleOlderThan40.Count > 0)
            {
                PrintPersonData(peopleOlderThan40.Dequeue());
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Помилка: " + ex.Message);
        }
    }

    static void PrintPersonData(Person person)
    {
        Console.WriteLine($"{person.LastName} {person.FirstName} {person.MiddleName}, {person.Age} років, {person.Weight} кг");
    }
}
