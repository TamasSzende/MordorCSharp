using Microsoft.EntityFrameworkCore;
using Mordor.Repository.Config;
using Mordor.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mordor.Repository
{
    public class IzeContext : DbContext, IIzeContext
    {
        public DbSet<DbOrk> Orkok { get; set; }   //így már 3 táblánk van
        public DbSet<DbHorda> Horda { get; set; }
        public DbSet<DbOrkWeapon> Weapons { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySQL("server=localhost;database=izek3;user=root;password=Flaron76");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new DbOrkConfig());
            modelBuilder.ApplyConfiguration(new DbHordaConfig());
            //modelBuilder.Entity<DbHorda>()
            //    .HasMany<DbOrk>(d => d.Orks);
        }
    }
}
