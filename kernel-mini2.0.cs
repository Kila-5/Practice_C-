using System;

Player player1 = new Player("Artem",2,200);
Console.WriteLine(player1.GetInfo());
player1.AddScore(300);
Console.WriteLine(player1.GetInfo());
player1.AddScore(700);
Console.WriteLine(player1.GetInfo());
player1.AddScore(0);
public class Player
{
  private string _name;
  private int _level;
  private int _score;
  public Player(string name, int level, int score)
  {
    if (string.IsNullOrWhiteSpace(name))
    {
      throw new ArgumentException("Имя не должно быть пустым", nameof(name));
    }
    if (level < 1)
    {
      throw new ArgumentException("Ошибка компиляции уровня", nameof(level));
    }
    if (score < 0)
    {
      throw new ArgumentException("Кол-во очков не может быть отрицательным", nameof(score));
    }
    _name = name;
    _level = level;
    _score = score;
  }
  public string Name => _name;
  public int Level => _level;
  public int Score => _score;
  public void AddScore(int points)
  {
    if (points <= 0)
    {
      throw new ArgumentException("Количество очков должно быть положительным",nameof(points));
    } 
    else
    {
      _score += points;
    }
    if (_score >= 1000)
    {
      _level += 1;
      _score = 0;
      Console.WriteLine("LEVEL UP");
      Console.WriteLine($"Текущий уровень: {Level}");
    }
  }
  public string GetInfo()
  {
    return($"{Name} (ур. {Level}) — {Score} очков");
  }
}