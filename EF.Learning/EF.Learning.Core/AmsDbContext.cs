using System;
using EF.Learning.Domain;
using Microsoft.EntityFrameworkCore;

namespace EF.Learning.Core
{
    public class AmsDbContext : DbContext
    {
        public DbSet<Application> Applications { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Application

            modelBuilder.Entity<Application>()
                .Property(p => p.Name).IsRequired().HasMaxLength(200);
            modelBuilder.Entity<Application>()
                .Property(p => p.Url).HasMaxLength(200);

            #endregion

            #region Account
            
            modelBuilder.Entity<Account>()
                .Property(p => p.LoginName).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Account>()
                .Property(p => p.Password).IsRequired().HasMaxLength(200);
            modelBuilder.Entity<Account>()
                .Property(p => p.Salt).IsRequired().HasMaxLength(200);
            modelBuilder.Entity<Account>()
                .Property(p => p.Phone).HasMaxLength(15);
            modelBuilder.Entity<Account>()
                .Property(p => p.Email).HasMaxLength(50); 
            modelBuilder.Entity<Account>()
                .Property(p => p.QQ).HasMaxLength(15);

            #endregion

            #region Tag

            modelBuilder.Entity<Tag>()
                .Property(p => p.Name).IsRequired().HasMaxLength(50);

            #endregion

            #region ApplicationTag

            modelBuilder.Entity<ApplicationTag>().HasKey(k => new { k.ApplicationId, k.TagId });

            modelBuilder.Entity<ApplicationTag>()
                .HasOne(t => t.Application)
                .WithMany(t => t.ApplicationTags)
                .HasForeignKey(k => k.ApplicationId);

            modelBuilder.Entity<ApplicationTag>()
                .HasOne(x => x.Tag)
                .WithMany(t => t.ApplicationTags)
                .HasForeignKey(k => k.TagId);

            #endregion
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Ams;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }
    }
}
