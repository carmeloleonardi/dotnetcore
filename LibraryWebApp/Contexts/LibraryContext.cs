using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using LibraryWebApp.Models;

namespace LibraryWebApp.Contexts
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {

        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuthorBook>()
                .HasKey(k => new { k.AuthorId, k.Isbn });

            modelBuilder.Entity<AuthorBook>()
                .HasOne(k => k.Author)
                .WithMany(k => k.AuthorBooks)
                .HasForeignKey(k => k.AuthorId);

            modelBuilder.Entity<AuthorBook>()
                .HasOne(k => k.Book)
                .WithMany(k => k.AuthorBooks)
                .HasForeignKey(k => k.Isbn);
            //---------
            modelBuilder.Entity<BookLoan>()
               .HasKey(k => new { k.UserId, k.Isbn });

            modelBuilder.Entity<BookLoan>()
                .HasOne(k => k.User)
                .WithMany(k => k.BookLoans)
                .HasForeignKey(k => k.UserId);

            modelBuilder.Entity<BookLoan>()
                .HasOne(k => k.Book)
                .WithMany(k => k.BookLoans)
                .HasForeignKey(k => k.Isbn);
            //---------
            modelBuilder.Entity<BookCategory>()
                .HasKey(k => new { k.CategoryId, k.Isbn });

            modelBuilder.Entity<BookCategory>()
                .HasOne(k => k.Category)
                .WithMany(k => k.BookCategories)
                .HasForeignKey(k => k.CategoryId);

            modelBuilder.Entity<BookCategory>()
                .HasOne(k => k.Book)
                .WithMany(k => k.BookCategories)
                .HasForeignKey(k => k.Isbn);
        }
    }
}
