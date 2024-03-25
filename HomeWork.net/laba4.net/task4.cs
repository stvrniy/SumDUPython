using System;
using System.Collections.Generic;
using System.Linq;

class Product
{
    public string Name { get; set; }
    public DateTime ArrivalDate { get; set; }
    public double Price { get; set; }
    public string Manufacturer { get; set; }
    public string Size { get; set; }

    public Product(string name, DateTime arrivalDate, double price, string manufacturer, string size)
    {
        Name = name;
        ArrivalDate = arrivalDate;
        Price = price;
        Manufacturer = manufacturer;
        Size = size;
    }

    public override string ToString()
    {
        return $"{Name} - {ArrivalDate.ToShortDateString()} - ${Price} - {Manufacturer} - {Size}";
    }
}

class Warehouse
{
    private List<Product> products;

    public Warehouse()
    {
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public void SearchByCriteria(DateTime startDate, double minPrice, string size)
    {
        var filteredProducts = products.Where(p => p.ArrivalDate >= startDate && p.Price >= minPrice && p.Size == size).ToList();
        DisplayProducts(filteredProducts, "Search results:");
    }

    public void SortByManufacturer()
    {
        var sortedProducts = products.OrderBy(p => p.Manufacturer).ToList();
        DisplayProducts(sortedProducts, "Products sorted by manufacturer:");
    }

    public void SortByPrice()
    {
        var sortedProducts = products.OrderBy(p => p.Price).ToList();
        DisplayProducts(sortedProducts, "Products sorted by price:");
    }

    public void SortByName()
    {
        var sortedProducts = products.OrderBy(p => p.Name).ToList();
        DisplayProducts(sortedProducts, "Products sorted by name:");
    }

    private void DisplayProducts(List<Product> products, string message)
    {
        Console.WriteLine(message);
        foreach (var product in products)
        {
            Console.WriteLine(product);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Warehouse warehouse = new Warehouse();

        // Додавання декількох продуктів на склад
        warehouse.AddProduct(new Product("Laptop", DateTime.Now.AddDays(-10), 1200, "Dell", "Medium"));
        warehouse.AddProduct(new Product("Smartphone", DateTime.Now.AddDays(-5), 800, "Samsung", "Small"));
        warehouse.AddProduct(new Product("Tablet", DateTime.Now.AddDays(-7), 500, "Apple", "Medium"));

        // Пошук продуктів за критеріями
        warehouse.SearchByCriteria(DateTime.Now.AddDays(-8), 700, "Medium");

        // Сортування продуктів за виробником
        warehouse.SortByManufacturer();

        // Сортування продуктів за ціною
        warehouse.SortByPrice();

        // Сортування продуктів за назвою
        warehouse.SortByName();
    }
}
