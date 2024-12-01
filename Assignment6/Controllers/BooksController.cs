using Assignment6.Models;
using DataLayer.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assignment6.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BooksController : Controller
{
    public BookRespository books = new BookRespository();
    
    [HttpGet]
    public ActionResult<IEnumerable<Book>> GetAllBooks()
    {
        return books.GetAllBooks();
    }
    [HttpGet("{id}")]
    public ActionResult<Book> GetBook(int id){
        var book = books.GetBookById(id);
        if (book == null)
        {
            return NotFound();
        }
        return book;
    }
    [HttpPost]
    public ActionResult<Book> GetBook([FromBody] Book book){
        return books.PostBook(book);
    }
    
    [HttpDelete("{id}")]
    public ActionResult<Book> DelBook(int id)
    {
        return books.DeleteBook(id);
    }
    [HttpPut("{id}")]
    public ActionResult<Book> PutBook(int id, [FromBody] Book book)
    {
        return books.PutBook(id, book);
    }
    
    
    // GET
    public IActionResult Index()
    {
        return View();
    }
}