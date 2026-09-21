using System;


List<LibraryBook> books = new List<LibraryBook>();
books.Add(new LibraryBook("Война", "Путин", 2022, BookStatus.Available));
Console.WriteLine(books[0].GetInfo());
public enum BookStatus
{
    Available,   
    Borrowed,    
    Lost         
}
public class Book
{
    protected string _title;
    protected string _author;
    protected int _year;
    public Book(string title, string author, int year)
    {
        if (string.IsNullOrWhiteSpace(title))
            throw new ArgumentException("Название не может быть пустым.", nameof(title));

        if (string.IsNullOrWhiteSpace(author))
            throw new ArgumentException("Автор не может быть пустым.", nameof(author));

        if (year < 1000 || year > 2026)
            throw new ArgumentException("Год должен быть от 1000 до 2026.", nameof(year));

        _title = title;
        _author = author;
        _year = year;
}
    public string Title => _title;
    public string Author => _author;
    public int Year => _year;
    public virtual string GetInfo()
    {
        return($"{Title} — {Author}({Year})");
    }
}
public class LibraryBook : Book
{
    private BookStatus _status;

    public LibraryBook(string title, string author, int year, BookStatus status) 
    : base(title, author, year)
    {
        _status = status;
    }
    public BookStatus Status => _status;
    public void ChangeStatus(BookStatus newStatus)
    {
        _status = newStatus;
    }
    public override string GetInfo()
    {
        return $"{base.GetInfo()} [{GetStatusText()}]";
    }

    private string GetStatusText() => _status switch
    {
        BookStatus.Available => "Доступна",
        BookStatus.Borrowed => "Выдана",
        BookStatus.Lost => "Потеряна",
        _ => "Неизвестно"
    };
}