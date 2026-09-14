using System;
Person person = new Person("Ваня",16);
person.PrintInfo();
public class Person
{
  private string _name;
  private int _age;
  public Person(string name, int age)
  {
    if (name == null || age<0 || age > 150)
    {
      throw new ArgumentException("ERROR");
    }
    else
    {
    _age = age;
    _name = name;
    }
  }
  public void PrintInfo()
  {
    Console.WriteLine($"Имя: {_name}");
    Console.WriteLine($"Возраст: {_age}");
  }

}