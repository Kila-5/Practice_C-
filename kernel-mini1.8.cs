using System;

Wallet wallet1 = new Wallet("Иван", 1000);
wallet1.PrintInfo();
wallet1.Deposit(500);
wallet1.PrintInfo();
wallet1.Withdraw(300);
wallet1.PrintInfo();
try
{
    wallet1.Withdraw(5300);
}
catch (InvalidOperationException ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}

wallet1.PrintInfo(); 
public class Wallet
{
  protected string _owner;
  protected double _balance;
  public Wallet(string owner, double balance)
  {
    if (string.IsNullOrWhiteSpace(owner))
    {
      throw new ArgumentException("Не может быть пустым");
    }
    if (balance < 0)
    {
      throw new ArgumentException("Бомж");
    }
    _balance = balance;
    _owner = owner;
  }
  public string Owner => _owner;
  public double Balance => _balance;
  public void Deposit(double amount)
  {
    if (amount <= 0)
    {
      throw new ArgumentException("?????");
    }
    else
    {
      _balance += amount;
    }
  }
  public void Withdraw(double amount)
  {
    if (amount <= 0)
    {
      throw new ArgumentException("?????");
    }
    else if (amount > _balance) {
      throw new InvalidOperationException("Недостаточно средств");
    }
    else
    {
      _balance -= amount;
    }
  }
  public void PrintInfo()
  {
    Console.WriteLine($"{Owner}: {Balance:F2}");
  }
}