using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace RandomNameGenerator
{
    internal class NameData : DbContext
    {
        public DbSet<LastName> LastName { get; set; }
        public DbSet<FemaleFirstName> FemaleFirstName { get; set; }
        public DbSet<MaleFirstName> MaleFirstName { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=names.db");
            
        }
    }
}


