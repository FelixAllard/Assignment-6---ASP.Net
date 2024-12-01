namespace Assignment6.Models;

public class Book
{
    public Book(int id = default, string title = null, string author = null, int publicationYear = default, bool isAvailable = default, string callNumber = null)
    {
        Id = id;
        Title = title;
        Author = author;
        PublicationYear = publicationYear;
        IsAvailable = isAvailable;
        CallNumber = callNumber;
    }

    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public int PublicationYear { get; set; }
    public bool IsAvailable { get; set; }
    public string CallNumber { get; set; }
    
}