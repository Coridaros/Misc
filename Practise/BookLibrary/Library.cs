public class Library
{
    private List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public void ListAllBooks()
    {
        foreach(Book book in books)
        {
            book.PrintBookInfo();
        }
    }

    public Book FindBookByName(string bookName)
    {
        return books.FirstOrDefault(b => b.Title == bookName);
    }
}