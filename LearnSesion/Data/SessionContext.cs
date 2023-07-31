using LearnSesion.Models;
using Microsoft.EntityFrameworkCore;

namespace LearnSesion.Data
{
    public class SessionContext : DbContext
    {
        public SessionContext(DbContextOptions<SessionContext> options) : base(options)
        {

        }

        public DbSet<User>  Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShopingList> ShopingLists { get; set; }
    }
}
