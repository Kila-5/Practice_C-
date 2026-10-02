using System;

var phones = new Dictionary<string,int> {
  ["Alice"]=111, 
  ["Bob"]=222, 
  ["Charlie"]=333
  };
phones["Diana"]=444;
if (phones.TryGetValue("Bob",out int a))
Console.WriteLine($"Найдено, номер: {a}");
else
Console.WriteLine("Не найдено");
if (phones.TryGetValue("Eve",out int f))
Console.WriteLine($"Найдено, номер: {f}");
else
Console.WriteLine("Не найдено");
phones.Remove("Charlie");
foreach (var kv in phones)
    Console.WriteLine($"{kv.Key} = {kv.Value}");
Console.WriteLine($"Всего записей: {phones.Count}");