using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<Persona> persons = new List<Persona>();

        if (File.Exists("persons.txt"))
        {
            using (StreamReader sr = new StreamReader("persons.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');

                    if (parts.Length >= 4)
                    {
                        string lastName = parts[0];

                        // Перевірка коректності дати
                        DateTime dateOfBirth;
                        if (DateTime.TryParseExact(parts[1], "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out dateOfBirth))
                        {
                            string faculty = parts[2];
                            string type = parts[3];

                            if (type == "Applicant" && parts.Length >= 4)
                            {
                                persons.Add(new Applicant(lastName, dateOfBirth, faculty));
                            }
                            else if (type == "Student" && parts.Length >= 5)
                            {
                                int course;
                                if (int.TryParse(parts[4], out course))
                                {
                                    persons.Add(new Student(lastName, dateOfBirth, faculty, course));
                                }
                            }
                            else if (type == "Teacher" && parts.Length >= 6)
                            {
                                string position = parts[4];
                                int experience;
                                if (int.TryParse(parts[5], out experience))
                                {
                                    persons.Add(new Teacher(lastName, dateOfBirth, faculty, position, experience));
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Неправильний формат дати: " + parts[1]);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Недостатньо даних у рядку: " + line);
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("Файл persons.txt не знайдено.");
        }

        foreach (var person in persons)
        {
            person.DisplayInfo();
        }
    }
}
