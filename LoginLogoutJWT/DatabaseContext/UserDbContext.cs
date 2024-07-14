using LoginLogoutJWT.Models;
using Microsoft.EntityFrameworkCore;

namespace LoginLogoutJWT.DatabaseContext
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        //Your connectionstrings here
        //       // optionsBuilder.UseSqlServer("Server=ASUS\\SQLEXPRESS06;Database=AuthJWt;Integrated Security=true;Encrypt=false");
        //    }
        //}

       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Users>().HasKey(e => e.UserId);
            modelBuilder.Entity<Users>().Property(e => e.Email);
            modelBuilder.Entity<Users>().Property(e => e.Name);
            modelBuilder.Entity<Users>().Property(e => e.Password);


        }
        public DbSet<Users> Users { get; set; }

    }
}
