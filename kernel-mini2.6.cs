using System;

var Queue = new Queue<string>();
Queue.Enqueue("Иванов");
Queue.Enqueue("Петров");
Queue.Enqueue("Сидоров");
Console.WriteLine($"Первый в очереди: {Queue.Peek()}");
Console.WriteLine($"Пациент {Queue.Dequeue()} принят");
Queue.Enqueue("Кузнецов");
Console.WriteLine($"Сейчас в очереди {Queue.Count} человека:");
foreach (string a in Queue)
{
  Console.WriteLine(a);
}
if (Queue.Contains("Петров"))
Console.WriteLine("Да");
else
Console.WriteLine("Нет");