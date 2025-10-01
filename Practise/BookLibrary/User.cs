public class User
{
    public string Name { get; private set; }
    private List<Book> borrowedBooks = new List<Book>();

    public User(string name)
    {
        Name = name;
    }

    public void BorrowBook(Library library, string title)
    {
        Book book = library.FindBookByName(title);

        if(book != null && book.IsAvailable)
        {
            book.Borrow();
            borrowedBooks.Add(book);
            Console.WriteLine($"User: {Name} взе книгата: {book.Title}");
        }
        else
        {
            Console.WriteLine($"Книгата {book.Title} не е налична.");
        }
    }

    public void ReturnBook(string title)
    {
        Book book = borrowedBooks.FirstOrDefault(x => x.Title == title);

        if(book != null)
        {
            book.Return();
            borrowedBooks.Remove(book);
            Console.WriteLine($"User: {Name} върна книгата: {book.Title}");
        }
    }
}