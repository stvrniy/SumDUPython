using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        // Створюємо набір ArrayList
        ArrayList list = new ArrayList();

        // Додаємо випадкові значення в діапазоні від 200 до 700
        Random random = new Random();
        for (int i = 0; i < 1850; i++)
        {
            int randomNumber = random.Next(200, 701);
            list.Add(randomNumber);
        }

        // Відсортовуємо набір в порядку зростання
        list.Sort();

        // Виводимо всі елементи набору
        Console.WriteLine("Елементи набору:");
        foreach (int number in list)
        {
            Console.WriteLine(number);
        }

        // Заносимо номер варіанту (1850) на позицію, що дорівнює номеру варіанту
        list.Insert(2, 1850);

        // Згенеруємо нове значення в межах від 0 до 2850 і перевіримо, чи існує таке значення в наборі
        int randomValue = random.Next(0, 2851);
        int index = list.IndexOf(randomValue);
        if (index != -1)
        {
            Console.WriteLine($"Значення {randomValue} знаходиться на позиції з індексом {index}");
        }
        else
        {
            Console.WriteLine($"Значення {randomValue} не знайдено у наборі");
        }

        // Видаляємо елемент набору, рівний випадковому значенню
        int randomIndex = random.Next(0, list.Count);
        int removedValue = (int)list[randomIndex];
        list.RemoveAt(randomIndex);
        Console.WriteLine($"Видалено значення {removedValue} з набору");

        // Видаляємо всі елементи набору
        list.Clear();
        Console.WriteLine("Всі елементи набору були видалені");

        Console.ReadLine();
    }
}
