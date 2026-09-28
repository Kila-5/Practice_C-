using System;
using System.Linq;

var shapes = new List<Shape>
{
    new Circle(6),
    new Rectangle(4, 6),
    new Triangle(3, 4, 5),
    new Circle(2.5),
    new Rectangle(10, 10),
};

Console.WriteLine("=== Все фигуры ===");
foreach (var shape in shapes)
    Console.WriteLine(shape.GetInfo());

Console.WriteLine("\n=== Максимальная площадь ===");
var maxArea = shapes.MaxBy(s => s.GetArea());
Console.WriteLine(maxArea.GetInfo());

Console.WriteLine("\n=== Минимальный периметр ===");
var minPer = shapes.MinBy(s => s.GetPerimeter());
Console.WriteLine(minPer.GetInfo());

Console.WriteLine("\n=== Общая площадь ===");
Console.WriteLine($"{shapes.Sum(s => s.GetArea()):F2}");

Console.WriteLine("\n=== По типам ===");
foreach (var g in shapes.GroupBy(s => s.Name))
    Console.WriteLine($"{g.Key}: {g.Count()}");

Console.WriteLine("\n=== Площадь > 30 ===");
foreach (var s in shapes.Where(s => s.GetArea() > 30))
    Console.WriteLine(s.Name);

// === КЛАССЫ ===
public abstract class Shape
{
    protected string _name;

    protected Shape(string name)
    {
        _name = name;
    }

    public string Name => _name;

    public abstract double GetArea();
    public abstract double GetPerimeter();

    public virtual string GetInfo()
        => $"{Name}: площадь = {GetArea():F2}, периметр = {GetPerimeter():F2}";
}

public class Circle : Shape
{
    private double _radius;

    public Circle(double radius) : base("Круг")
    {
        if (radius <= 0)
            throw new ArgumentException("Радиус должен быть положительным.", nameof(radius));

        _radius = radius;
    }

    public override double GetArea() => Math.PI * _radius * _radius;
    public override double GetPerimeter() => 2 * Math.PI * _radius;
}

public class Rectangle : Shape
{
    private double _width;
    private double _height;

    public Rectangle(double width, double height) : base("Прямоугольник")
    {
        if (width <= 0)
            throw new ArgumentException("Ширина должна быть положительной.", nameof(width));

        if (height <= 0)
            throw new ArgumentException("Высота должна быть положительной.", nameof(height));

        _width = width;
        _height = height;
    }

    public override double GetArea() => _width * _height;
    public override double GetPerimeter() => 2 * (_width + _height);
}

public class Triangle : Shape
{
    private double _a;
    private double _b;
    private double _c;

    public Triangle(double a, double b, double c) : base("Треугольник")
    {
        if (a <= 0)
            throw new ArgumentException("Сторона должна быть положительной.", nameof(a));

        if (b <= 0)
            throw new ArgumentException("Сторона должна быть положительной.", nameof(b));

        if (c <= 0)
            throw new ArgumentException("Сторона должна быть положительной.", nameof(c));

        if (a + b <= c || a + c <= b || b + c <= a)
            throw new ArgumentException("Стороны не образуют треугольник.");

        _a = a;
        _b = b;
        _c = c;
    }

    public override double GetPerimeter() => _a + _b + _c;

    public override double GetArea()
    {
        double p = (_a + _b + _c) / 2;
        return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
    }
}