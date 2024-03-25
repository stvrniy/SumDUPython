using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Teacher : Persona
{
    private string position;
    private int experience;

    // Конструктор
    public Teacher(string lastName, DateTime dateOfBirth, string faculty, string position, int experience) : base(lastName, dateOfBirth, faculty)
    {
        this.position = position;
        this.experience = experience;
    }

    // Метод для виведення інформації про викладача
    public override void DisplayInfo()
    {
        Console.WriteLine($"Викладач: {lastName}, Дата народження: {dateOfBirth.ToShortDateString()}, Факультет: {faculty}, Посада: {position}, Стаж: {experience} років, Вік: {CalculateAge()}");
    }
}
