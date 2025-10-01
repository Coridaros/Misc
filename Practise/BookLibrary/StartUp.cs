public class StartUp
{
    static void Main()
    {
        Library library = new Library();
        library.AddBook(new Book("Под игото", "Иван Вазов"));
        library.AddBook(new Book("Бай Ганьо", "Алеко Константинов"));

        User user = new User("Николай");

        library.ListAllBooks();
        user.BorrowBook(library, "Под игото");
        library.ListAllBooks();
        user.ReturnBook("Под игото");
        library.ListAllBooks();
    }
}