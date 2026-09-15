using System;

Temperature temp = new Temperature(25);
temp.PritInfo();
Temperature temp1 = new Temperature(-40);
temp1.PritInfo();
public class Temperature
{
  private double _celsius;
  public Temperature(double celsius)
  {
    _celsius = celsius;
  }
  double Celsius => _celsius;
  double Fahrenheit => _celsius * 9 / 5 + 32;
  double Kelvin => _celsius + 273.15;
  public void PritInfo()
  {
    System.Console.WriteLine($"Цельсии {Celsius:F2}");
    System.Console.WriteLine($"Фаренгейты {Fahrenheit:F2}");
    System.Console.WriteLine($"Келвинкляйн {Kelvin:F2}");
  }
}