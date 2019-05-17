using Microsoft.EntityFrameworkCore;

namespace WebLibrary.Data
{
    public class WebLibraryContext : DbContext
    {
        public WebLibraryContext(DbContextOptions<WebLibraryContext> options)
            : base(options)
        {
        }

        public DbSet<WebLibrary.Models.Book> Book { get; set; }
    }
}
