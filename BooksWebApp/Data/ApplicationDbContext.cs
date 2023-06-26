using BooksWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BooksWebApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public virtual DbSet<Category> Categories { get; set; }

    }
}
