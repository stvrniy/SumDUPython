using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Student : Persona
{
    private int course;

    // Конструктор
    public Student(string lastName, DateTime dateOfBirth, string faculty, int course) : base(lastName, dateOfBirth, faculty)
    {
        this.course = course;
    }

    // Метод для виведення інформації про студента
    public override void DisplayInfo()
    {
        Console.WriteLine($"Студент: {lastName}, Дата народження: {dateOfBirth.ToShortDateString()}, Факультет: {faculty}, Курс: {course}, Вік: {CalculateAge()}");
    }
}
