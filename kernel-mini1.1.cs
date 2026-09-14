using System;

Book book1 = new Book("Война и мир", 1225);
Book book2 = new Book("Преступление и наказание", 671);
book1.PrintInfo();
book2.PrintInfo();
public class Book
{
  private string _title;
  private int _pages;
  public Book(string title, int pages)
    {
        _title = title;
        _pages = pages;
    }
  public void PrintInfo()
  {
    Console.WriteLine($"Книга {_title}, {_pages} стр.");
  } 
}