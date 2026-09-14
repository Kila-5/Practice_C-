using System;
//Этот кусок скопировал с прошлой задачи
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

NumberAnalyzer Analyz = new NumberAnalyzer(numbers);
Analyz.PrintReport(); //!!!!!!!!!!!!!!!!!!!!!!
public class NumberAnalyzer
{
    private readonly int[] _numbers;
    public NumberAnalyzer(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            throw new ArgumentException("Массив не может быть пустым.", nameof(numbers));
        _numbers = numbers;
    }
public int Sum => _numbers.Sum();
public double Average => (double)_numbers.Sum() / _numbers.Length;
public int Max => _numbers.Max();
public int Min => _numbers.Min();
public int EvenCount => _numbers.Count(x => x % 2 == 0);
public int OddCount => _numbers.Length - EvenCount;

  public int[] GetNumbersAboveAverage()
{
    return _numbers.Where(x => x > Average).ToArray();
}
  public void PrintReport()
{
    Console.WriteLine("\n--- Результаты ---");
    Console.WriteLine($"Сумма: {Sum}");
    Console.WriteLine($"Среднее: {Average:F2}");
    Console.WriteLine($"Максимум: {Max}");
    Console.WriteLine($"Минимум: {Min}");
    Console.WriteLine($"Чётных: {EvenCount}");
    Console.WriteLine($"Нечётных: {OddCount}");
    Console.WriteLine($"Числа выше среднего: {string.Join(" ", GetNumbersAboveAverage())}");
}
}

