using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Об’єднання рядків
        string str1 = "Hello";
        string str2 = "World";
        string combinedString = string.Concat(str1, " ", str2);
        Console.WriteLine("Об’єднання рядків: " + combinedString);

        // 2. Вставлення рядків
        string originalString = "The quick brown fox jumps over the lazy dog.";
        string insertedString = "red ";
        int insertIndex = 10;
        string modifiedString = originalString.Insert(insertIndex, insertedString);
        Console.WriteLine("Вставлення рядків: " + modifiedString);

        // 3. Заміна рядків
        string text = "C# is a programming language.";
        string replacedString = text.Replace("C#", "Java");
        Console.WriteLine("Заміна рядків: " + replacedString);

        // 4. Вилучення рядків
        string sourceString = "This is a sample text.";
        int startIndex = 5;
        int length = 2;
        string removedString = sourceString.Remove(startIndex, length);
        Console.WriteLine("Вилучення рядків: " + removedString);

        // 5. Порівняння двох рядків
        string string1 = "hello";
        string string2 = "HELLO";
        bool areEqual = string1.Equals(string2, StringComparison.OrdinalIgnoreCase);
        Console.WriteLine("Порівняння двох рядків: " + areEqual);

        // 6. Порівняння символів із двох рядків, які знаходяться на певних місцях
        char char1 = 'a';
        char char2 = 'b';
        bool areCharsEqual = string1[1] == char1 && string2[1] == char2;
        Console.WriteLine("Порівняння символів на певних позиціях: " + areCharsEqual);

        // 7. Визначення індексу першого входження заданого рядка в інший
        string searchString = "is";
        int index = text.IndexOf(searchString);
        Console.WriteLine("Індекс першого входження: " + index);
    }
}
