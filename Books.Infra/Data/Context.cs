using Books.Domain.Models;
using Books.Infra.EntityConfiguration;
using Microsoft.EntityFrameworkCore;

namespace Books.Infra.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BookConfiguration());
        }
    }
}
