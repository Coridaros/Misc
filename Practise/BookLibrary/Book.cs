public class Book
{
    public string Title { get; private set; }
    public string Author { get; private set; }
    public bool IsAvailable { get; private set; }

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
        IsAvailable = true;
    }

    public void Borrow()
    {
        if(IsAvailable)
        {
            IsAvailable = false;
        }
    }

    public void Return()
    {
        IsAvailable = true;
    }

    public void PrintBookInfo()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}, is available: {IsAvailable}");
    }
}