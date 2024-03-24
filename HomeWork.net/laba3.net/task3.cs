using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        // Шлях до текстового файлу
        string filePath = "text.txt";

        // Зчитуємо текст з файлу
        string text = File.ReadAllText(filePath);

        // Виконуємо завдання і виводимо результати на екран
        Test1(text);
        Test2(text);
        Test3(text);
        Test4(text);
        Test5(text);
        Test6(text);
        Test7(text);
    }

    // Завдання 1
    static void Test1(string text)
    {
        MatchCollection matches = Regex.Matches(text, @"\b([a-zA-Z]+)\b");
        if (matches.Count < 2)
        {
            Console.WriteLine("Недостатньо груп букв для виконання завдання 1.");
            return;
        }

        string firstGroup = matches[0].Value;
        char lastChar = firstGroup[firstGroup.Length - 1];

        int count = matches.Cast<Match>().Count(match => match.Value.Last() == lastChar);

        Console.WriteLine($"Завдання 1: {count} груп букв закінчуються на '{lastChar}'.");
    }

    // Завдання 2
    static void Test2(string text)
    {
        if (text.Contains("*"))
        {
            text = Regex.Replace(text, @"\*(\S*)", m => new string('0', m.Groups[1].Length));
            Console.WriteLine($"Завдання 2: {text}");
        }
    }

    // Завдання 3
    static void Test3(string text)
    {
        MatchCollection matches = Regex.Matches(text, @"\b([a-zA-Z]+)\b");
        if (matches.Count == 0)
        {
            Console.WriteLine("Текст не містить жодного слова.");
            return;
        }

        string lastWord = matches[matches.Count - 1].Value;
        string result = string.Join(" ", matches.Cast<Match>().Where(match => match.Value != lastWord).Select(match => match.Value));
        Console.WriteLine($"Завдання 3: {result}");
    }

    // Завдання 4
    static void Test4(string text)
    {
        if (text.Contains("+"))
        {
            text = Regex.Replace(text, @"\d", "*");
            Console.WriteLine($"Завдання 4: {text}");
        }
    }
    // Завдання 5
    static void Test5(string text)
    {
        MatchCollection matches = Regex.Matches(text, @"\b([a-zA-Z]+)\b");
        string result = new string(matches.Cast<Match>().Select(match => match.Value.Last()).ToArray());
        Console.WriteLine($"Завдання 5: {result}");
    }

    // Завдання 6
    static void Test6(string text)
    {
        if (Regex.IsMatch(text, @"\bone\b"))
        {
            Console.WriteLine("Завдання 6: Група букв 'one' зустрічається у тексті.");
        }
        else
        {
            Console.WriteLine("Завдання 6: Група букв 'one' не зустрічається у тексті.");
        }
    }

    // Завдання 7
    static void Test7(string text)
    {
        MatchCollection matches = Regex.Matches(text, @"\b([a-zA-Z]+)\b");
        string result = new string(matches.Cast<Match>().Select(match => match.Value.First()).ToArray());
        Console.WriteLine($"Завдання 7: {result}");
    }

}