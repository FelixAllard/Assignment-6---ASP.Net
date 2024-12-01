using Assignment6.Models;
using DataLayer.Interface;

namespace DataLayer.Repositories;

public class BookDatabase : IBookRepository
{
    private BookstoreContext db;

    public BookDatabase(BookstoreContext _Db)
    {
        db = _Db;
    }


    public List<Book> GetAllBooks()
    {
        return db.Books.ToList();
    }

    public Book GetBookById(int id)
    {
        return db.Books.FirstOrDefault(b => b.Id == id);
    }
}