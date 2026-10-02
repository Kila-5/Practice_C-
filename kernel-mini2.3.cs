using System;

var list = new List<string>{"хлеб", "молоко", "сыр", "яблоки", "молоко"};
int n = 0;
foreach (string i in list)
{
  Console.WriteLine($"{n++}: {i}");
}
if (list.Contains("сыр"))
  Console.WriteLine("Да");
else
  Console.WriteLine("Нет");
int count = list.RemoveAll(x => x=="молоко");
list.Add("кофе");
Console.WriteLine(string.Join(" ", list));
Console.WriteLine($"Кол-во элементов: {list.Count}");
