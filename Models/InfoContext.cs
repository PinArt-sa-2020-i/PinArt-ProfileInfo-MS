using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore.Extensions;

namespace PinArt_ProfileInfo_MS.Models
{
    public class InfoContext : DbContext
    {
        public InfoContext(DbContextOptions<InfoContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Authentication> Authentications { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Recovery> Recoveries { get; set; }
        public DbSet<Cause> Causes { get; set; }
        public DbSet<Report> Reports { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Profile Primary Keys setup
            modelBuilder.Entity<Profile>()
                .HasKey(x => new { x.Id, x.UserId });

            //Authentication Primary Keys setup
            modelBuilder.Entity<Authentication>()
                .HasKey(x => new { x.Id, x.UserId });

            //Report Primary Keys setup
            modelBuilder.Entity<Report>()
                .HasKey(x => new { x.Id, x.UserId });
        }
    }
}