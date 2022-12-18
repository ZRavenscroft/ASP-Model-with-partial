using PustokLayout.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace PustokLayout.DAL
{
    public class PustokContext : IdentityDbContext
    {
        public PustokContext(DbContextOptions<PustokContext> options) : base(options)
        {

        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookImage> BookImages { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Setting> Settings { get; set; }   
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<BasketItem> BasketItems { get; set; }
    }
}
