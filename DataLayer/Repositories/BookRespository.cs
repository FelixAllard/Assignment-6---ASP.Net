using Assignment6.Models;
using DataLayer.Interface;

namespace DataLayer.Repositories;

public class BookRespository : IBookRepository
{

    public List<Book> books = new List<Book>()
    {
        new Book(0, "The One who represented the end", "FelixAllard", 2015, true, "1234122"),
        new Book(1, "Whispers of the Forgotten", "Emily Blake", 2010, true, "2345234"),
        new Book(2, "Shadows of Eternity", "David Fisher", 2012, false, "3456345"),
        new Book(3, "The Final Horizon", "Sophia Waters", 2018, true, "4567456"),
        new Book(4, "Echoes of the Lost", "Lucas Evans", 2020, true, "5678567"),
        new Book(5, "The Silent Witness", "Olivia Moore", 2011, false, "6789678"),
        new Book(6, "The Vanishing Point", "Liam Carter", 2017, true, "7890789"),
        new Book(7, "The Last Beacon", "Isabella Harper", 2019, false, "8901890"),
        new Book(8, "Chronicles of Dusk", "James Reed", 2013, true, "9012901"),
        new Book(9, "The Eternal Covenant", "Ava Hill", 2021, true, "1123112")
    };
    
    public List<Book> GetAllBooks()
    {
        return books;
    }

    public Book GetBookById(int id)
    {
        return books.FirstOrDefault(b => b.Id == id);
    }

    public Book PostBook(Book book)
    {
        books.Add(book);
        return book;
    }

    public Book DeleteBook(int id)
    {
        Book deletedBook = GetBookById(id);
        books.FirstOrDefault(x => x.Id == id);
        return deletedBook;
    }

    public Book PutBook(int id, Book book)
    {
        books.FirstOrDefault(x => x.Id == id).PublicationYear = book.PublicationYear;
        books.FirstOrDefault(x => x.Id == id).Author = book.Author;
        books.FirstOrDefault(x => x.Id == id).Title = book.Title;
        books.FirstOrDefault(x => x.Id == id).CallNumber = book.CallNumber;
        books.FirstOrDefault(x => x.Id == id).IsAvailable = book.IsAvailable;
        return books.FirstOrDefault(x => x.Id == id);
    }
}