using Microsoft.EntityFrameworkCore;

namespace Assignment6.Models;

public class BookstoreContext : DbContext
{
    public BookstoreContext(DbContextOptions<BookstoreContext> options) : base(options)
    {
        
    }
    public DbSet<Book> Books { get; set; }
    
}