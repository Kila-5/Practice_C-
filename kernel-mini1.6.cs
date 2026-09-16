using System;

Console.Write("Введите имя: ");
string name = Console.ReadLine()!;
Console.Write("Введите возраст: ");
int age;
while (!int.TryParse(Console.ReadLine(), out age))
{
    Console.Write("Введите корректный возраст: ");
}
Console.Write("Введите цвет: ");
string color = Console.ReadLine()!;
Animal animal1 = new Animal(name,age);
Dog animal2 = new Dog(name, age, color);
animal1.Sound();
animal2.Sound();

public class Animal
{
  protected string _name;
  protected int _age;
  public Animal(string name, int age)
  {
    _name = name;
    _age = age;
  }
  public virtual void Sound()
  {
    Console.WriteLine($"Животное {_name} издает звук");
  } 
}
public class Dog : Animal
{
  protected string _color;
  public Dog(string name, int age, string color) : base(name, age)
  {
    _color = color;
  }
  public override void Sound()
  {
    base.Sound(); 
    Console.WriteLine($"Сабака {_name} гавкает");
  }
}