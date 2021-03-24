using SydneyOnlineBookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace SydneyOnlineBookStore.Data
{
    public class BookStoreContext : Microsoft.AspNet.Identity.EntityFramework.IdentityDbContext<ApplicationUser>
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options)
           : base(options)
        {

        }

        public DbSet<Books> Books { get; set; }

        public DbSet<BookGallery> BookGallery { get; set; }

        public DbSet<Language> Language { get; set; }
    }
}
