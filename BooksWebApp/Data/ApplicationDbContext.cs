using BooksWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BooksWebApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
            modelBuilder.Entity<Category>().HasData(new Category() { CategoryID = 1 , Name = "Category 1" , DisplayOrder = 50});
			base.OnModelCreating(modelBuilder);
		}

		public virtual DbSet<Category> Categories { get; set; }

    }
}
