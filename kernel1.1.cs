using System;
using System.Linq;


int sum = 0;
int chet = 0;
int nechet = 0;
Console.Write("Введите длину масива: ");
int N = int.Parse(Console.ReadLine());
var hight = new List<int>();
int[] list = new int[N];
for (int i = 0; i<N; i++)
{
  Console.Write($"Введите еще {N-i} символов: ");
  list[i] = int.Parse(Console.ReadLine());
  sum += list[i];
}
double sr = (double)sum / N;
for (int i = 0; i<N; i++)
{
  if (list[i] % 2 == 0)
  {
    chet+=1;
  }
  else
  {
    nechet+=1;
  }
  if (list[i] > sr)
  {
    hight.Add(list[i]); 
  }
}

Console.WriteLine($"Сумма элементов: {sum}");
Console.WriteLine($"Среднее арифметическое элементов: {sr}");
Console.WriteLine($"Максимальный элемент: {list.Max()}");
Console.WriteLine($"Минимальный элемент: {list.Min()}");
Console.WriteLine($"Кол-во четных элементов: {chet}");
Console.WriteLine($"Кол-во не четных элементов: {nechet}");
Console.WriteLine($"Числа больше среднего {string.Join(", ", hight)}");