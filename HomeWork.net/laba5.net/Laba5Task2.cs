using System;

class Book
{
    // Поля (властивості) класу
    private string authorFullName;
    private string bookTitle;
    private string code;
    private int yearOfPublication;
    private int numberOfPages;
    private string genre;

    // Властивості для доступу до полів класу
    public string AuthorFullName { get { return authorFullName; } }
    public string BookTitle { get { return bookTitle; } }
    public string Code { get { return code; } }
    public int YearOfPublication { get { return yearOfPublication; } }
    public int NumberOfPages { get { return numberOfPages; } }
    public string Genre { get { return genre; } }

    // Конструктори класу
    public Book()
    {
        // Конструктор без параметрів
    }

    public Book(string author, string title, string code, int year, int pages, string genre)
    {
        authorFullName = author;
        bookTitle = title;
        this.code = code;
        yearOfPublication = year;
        numberOfPages = pages;
        this.genre = genre;
    }

    // Перевантажений метод ToString()
    public override string ToString()
    {
        return $"Автор: {authorFullName}, Назва: {bookTitle}, Код: {code}, Рік видання: {yearOfPublication}, " +
               $"Кількість сторінок: {numberOfPages}, Жанр: {genre}";
    }

    // Метод порівняння двох книг за вказаним параметром
    public bool CompareByParameter(string parameter, Book otherBook)
    {
        switch (parameter)
        {
            case "author":
                return this.authorFullName.Equals(otherBook.authorFullName);
            case "title":
                return this.bookTitle.Equals(otherBook.bookTitle);
            case "code":
                return this.code.Equals(otherBook.code);
            case "year":
                return this.yearOfPublication == otherBook.yearOfPublication;
            case "pages":
                return this.numberOfPages == otherBook.numberOfPages;
            case "genre":
                return this.genre.Equals(otherBook.genre);
            default:
                throw new ArgumentException("Непідтримуваний параметр для порівняння.");
        }
    }

    // Метод пошуку книги за кодом
    public static Book SearchByCode(string code, Book[] books)
    {
        foreach (var book in books)
        {
            if (book.code.Equals(code))
            {
                return book;
            }
        }
        return null; // Книга з таким кодом не знайдена
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Створення екземплярів книг
        Book book1 = new Book("Іванов Іван Іванович", "Програмування на C#", "123456", 2020, 500, "Навчальний посібник");
        Book book2 = new Book("Петров Петро Петрович", "Основи алгоритмів", "789012", 2018, 400, "Наукова література");
        Book book3 = new Book("Сидоров Сидір Сидорович", "Історія світу", "345678", 2019, 600, "Енциклопедія");

        // Виведення інформації про книги
        Console.WriteLine("Інформація про книги:");
        Console.WriteLine(book1);
        Console.WriteLine(book2);
        Console.WriteLine(book3);

        // Пошук книги за кодом
        string кодДляПошуку = "789012";
        Book знайденаКнига = Book.SearchByCode(кодДляПошуку, new Book[] { book1, book2, book3 });
        if (знайденаКнига != null)
        {
            Console.WriteLine($"\nЗнайдена книга з кодом {кодДляПошуку}:");
            Console.WriteLine(знайденаКнига);
        }
        else
        {
            Console.WriteLine($"\nКнига з кодом {кодДляПошуку} не знайдена.");
        }
    }
}