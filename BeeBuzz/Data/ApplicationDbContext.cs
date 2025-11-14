using BeeBuzz.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BeeBuzz.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
        public DbSet<ApplicationUser> Users {  get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Beehive> Beehives { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Organization>()
                .Property(o => o.Id)
                .IsRequired();                
        }
    }
}
