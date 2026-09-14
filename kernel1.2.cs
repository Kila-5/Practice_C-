using System;

int n;
while (true)
{
    Console.Write("Введите количество элементов: ");
    if (int.TryParse(Console.ReadLine(), out n) && n > 0) break;
    Console.WriteLine("Некорректные данные. Требуется положительное число.");
}
int[] numbers = new int[n];
for (int i = 0; i < n; i++)
{
  Console.Write($"Введите значение {i+1}: ");
  while (!int.TryParse(Console.ReadLine(), out numbers[i]))
  {
    Console.WriteLine("Некоректные данные, требуется целое число");
    Console.Write($"Введите значение {i+1}: ");
  }
}
int sum = numbers.Sum();
double avg = (double)sum/n;
int max = numbers.Max();
int min = numbers.Min();
int chet = numbers.Count(x=>x%2==0);
int nechet = n - chet;
int[] aboveAvg = numbers.Where(x => x > avg).ToArray();

Console.WriteLine("\n--- Результаты ---");
Console.WriteLine($"Сумма всех чисел масива: {sum}");
Console.WriteLine($"Среднее арифметическое массива: {avg:F2}");
Console.WriteLine($"Максимальный элемент массива: {max}");
Console.WriteLine($"Минимальный элемент массива: {min}");
Console.WriteLine($"Кол-во четных чисел: {chet}");
Console.WriteLine($"Кол-во не четных чисел: {nechet}");
Console.WriteLine($"Числа выше среднего: {string.Join(" ",aboveAvg)}");