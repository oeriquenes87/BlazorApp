using BlazorApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Api.Models
{
    public class BlazorDBContext : DbContext
    {
        public BlazorDBContext(DbContextOptions<BlazorDBContext> options): base(options)
        {

        }


        public DbSet<Book> Books { get; set; }
        public DbSet<Library> Libraries { get; set; }   


        protected override void  OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Book>().HasData(new Book { Id = 1, Title = "Quo Vadis", PublishDate = DateTime.Now,Library=1 });
            modelBuilder.Entity<Book>().HasData(new Book { Id = 2, Title = "Dracula", PublishDate = DateTime.Now, Library=2 });


            modelBuilder.Entity<Library>().HasData(new Library { Id = 1, Name = "Cervantes" });
            modelBuilder.Entity<Library>().HasData(new Library { Id = 2, Name = "Obispo" });
        }
    }
}
