namespace MvvmExample;

public class Book
{
    private static int IdCounter = 0;
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }

    public Book(string title, string author)
    {
        Id = ++IdCounter;
        Title = title;
        Author = author;
    }
}