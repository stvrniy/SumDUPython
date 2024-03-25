using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Applicant : Persona
{
    // Конструктор
    public Applicant(string lastName, DateTime dateOfBirth, string faculty) : base(lastName, dateOfBirth, faculty)
    {
    }

    // Метод для виведення інформації про абітурієнта
    public override void DisplayInfo()
    {
        Console.WriteLine($"Абітурієнт: {lastName}, Дата народження: {dateOfBirth.ToShortDateString()}, Факультет: {faculty}, Вік: {CalculateAge()}");
    }
}
