using System;
using System.Data.Common;


public enum OrderStatus { New, Paid, Shipped, Delivered, Cancelled };
public class Order
{
  protected int _id;
  protected string _productName;
  protected double _price;
  protected OrderStatus _status;
  public Order(int id, string productName, double price)
  {
    if (string.IsNullOrEmpty(productName))
    {
      throw new ArgumentException("Имя НЕ должно быть пустым");
    }
    if (price < 0)
    {
      throw new ArgumentException("Цена должна быть положительная");
    }
    _id = id;
    _productName = productName;
    _price = price;
    _status = OrderStatus.New;
  }
  public int Id => _id;
  public string ProductName => _productName;
  public double Price => _price;
  public OrderStatus Status => _status;
  public void Pay()
  {
    if (_status == OrderStatus.New)
    {
      _status = OrderStatus.Paid;
    }
    else
    {
      throw new InvalidOperationException("Уже оплачено");
    }
  }
  public void Ship()
  {
    if (_status == OrderStatus.Paid)
    {
      _status = OrderStatus(Shipped);
    }
    else
    {
      throw new InvalidOperationException("Заказ еще не оплачен");
    }
  }
  public void Deliver()
  {
    if (_status == OrderStatus.Shipped)
    {
      _status = OrderStatus(Delivered);
    }
    else
    {
      throw new InvalidOperationException("Заказ еще пути");
    }
  }
  public void Cancel()
  {
    if (_status == OrderStatus.Delivered || _status == OrderStatus.Cancelled)
    {
      _status = OrderStatus(Cancelled);
    }
    else
    {
      throw new InvalidOperationException("Операция невозможна");
    }
  }

  public string GetStatusText() => _status switch
  {
    OrderStatus.New => "Создан",
    OrderStatus.Paid => "Оплачен",
    OrderStatus.Shipped => "Отправлен",
    OrderStatus.Delivered => "Доставлен",
    OrderStatus.Cancelled => "Отменён",
    _ => "Неизвестно"
  };
  public string GetInfo()
  {
    return $"#{Id} {ProductName} — {Price:F2} [{GetStatusText()}]";
  }
}
