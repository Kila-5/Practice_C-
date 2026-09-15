using System;

Circle circle = new Circle(5);
circle.PrintInfo();
public class Circle
{
  private double _radius;
  public Circle(double radius)
  {
    _radius = radius;
  }
  public double Radius => _radius;
  public double Area => Math.PI * _radius * _radius;
  public double Circumference => 2 * Math.PI * _radius;

  public void PrintInfo()
  {
    Console.WriteLine($"Радиус: {_radius}");
    Console.WriteLine($"Площадь: {Area}");
    Console.WriteLine($"Длинна окружности: {Circumference}");
  }
}