using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class Persona
{
    protected string lastName;
    protected DateTime dateOfBirth;
    protected string faculty;

    // Конструктор
    public Persona(string lastName, DateTime dateOfBirth, string faculty)
    {
        this.lastName = lastName;
        this.dateOfBirth = dateOfBirth;
        this.faculty = faculty;
    }

    // Абстрактний метод для виведення інформації про персону
    public abstract void DisplayInfo();

    // Метод для визначення віку персони
    public int CalculateAge()
    {
        DateTime currentDate = DateTime.Now;
        int age = currentDate.Year - dateOfBirth.Year;
        if (currentDate < dateOfBirth.AddYears(age)) age--;
        return age;
    }
}
