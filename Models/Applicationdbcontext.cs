using Microsoft.EntityFrameworkCore;

namespace Portfolio.Models
{
    public class Applicationdbcontext : DbContext
    {
        public Applicationdbcontext(DbContextOptions<Applicationdbcontext> options) : base(options) {
        }
        public DbSet<ContactUs> ContactUs { get; set; }
    }
}
