using System;


var products = new List<Product>
{
    new Product(1, "Icecream", 50, 3, Category.Food),
    new Product(2, "Book", 250, 20, Category.Other),
    new Product(3, "Linux", 2000, 55, Category.Electronics),
    new Product(4, "Cap", 150, 5, Category.Clothing),
    new Product(5, "Bag", 650, 55, Category.Other),
};
products[0].Sell(3);
try
{
    products[1].Sell(1000); // не хватает
}
catch (InvalidOperationException ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}
products[2].Restock(50);
foreach (var p in products)
{
  Console.WriteLine(p.GetInfo());
}

public enum Category { Electronics, Food, Clothing, Other }
public class Product
{
  private int _id;
  private string _name;
  private double _price;
  private int _quantity;
  private Category _category;
  public Product(int id, string name, double price, int quantity, Category category)
  {
    if (string.IsNullOrWhiteSpace(name))
    {
      throw new ArgumentException("Имя не должно быть пустым", nameof(name));
    }
    if (price<=0)
    {
      throw new ArgumentException("Цена должна быть больше 0", nameof(price));
    }
    if (quantity<0)
    {
      throw new ArgumentException("Количевство не может быть отрицательным", nameof(quantity));
    }
    _id = id;
    _name = name;
    _price = price;
    _quantity = quantity;
    _category = category;
    
  }
  public int Id => _id;
  public string Name => _name;
  public double Price => _price;
  public int Quantity => _quantity;
  public Category Category => _category;
  public double TotalValue => _price * _quantity;
  public void Sell(int amount)
  {
    if (amount<0)
    {
      throw new ArgumentException("Количевство не может быть отрицательным", nameof(amount));
    }
    if (amount>_quantity)
    {
      throw new InvalidOperationException("Недостаточно товара");
    }
    _quantity-=amount;
  }
  public void Restock(int amount)
  {
    if (amount<=0)
    {
      throw new ArgumentException("Количевство не может быть отрицательным", nameof(amount));
    }
    _quantity += amount;
  }
  public string GetInfo()
  {
    var mgs = _category switch
    {
      Category.Electronics => "Элеткроника",
      Category.Food => "Еда",
      Category.Clothing => "Одежда",
      Category.Other => "Другое",
      _ => "Неизвестно"
    };
    return $"#{Id} {Name} — {Price:F2} × {Quantity} = {TotalValue:F2} [{mgs}]";
  }
}