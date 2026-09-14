using System;
using System.Runtime.ConstrainedExecution;

Dog dog = new Dog("Тузик",11);
dog.Bark();
dog.PrintInfo();
public class Dog
{
  private string _name;
  private int _age;
  public Dog(string name,int age)
  {
    _name = name;
    _age = age;
  }
  public void Bark()
  {
    Console.WriteLine($"Гав! Меня зовут {_name}");
  }
  public void PrintInfo()
  {
    System.Console.WriteLine($"{_name} {_age} лет");
  }
}