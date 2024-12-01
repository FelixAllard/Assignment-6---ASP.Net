using Assignment6.Models;

namespace DataLayer.Interface;

public interface IBookRepository
{
    List<Book> GetAllBooks();
    Book GetBookById(int id);
}