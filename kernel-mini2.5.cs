using System;

var stack = new Stack<string>();
stack.Push("Hello");
stack.Push("world");
stack.Push("!");
Console.WriteLine(stack.Peek());
Console.WriteLine(stack.Pop());
foreach (var item in stack)
{
  Console.WriteLine(item);
}
Console.WriteLine($"Количевство элементов в стеке: {stack.Count}");
if (stack.Contains("World"))
Console.WriteLine("Да");
else 
Console.WriteLine("Нет");