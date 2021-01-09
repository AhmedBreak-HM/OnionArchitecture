using Core.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Owner>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Portfilio>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Owner>().HasData(new Owner {
                Id = Guid.NewGuid(), FullName = "Ahmed Break", Avatar = "avatar.jpg",JobTitle = "Full-Stack Developer"
            });
        }
        public DbSet<Owner> owners { get; set; }
        public DbSet<Portfilio> portfilios { get; set; }
    }
}
