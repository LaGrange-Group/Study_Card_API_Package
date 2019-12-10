using Microsoft.EntityFrameworkCore;
using study_cards_api.Data.Configuration;
using study_cards_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace study_cards_api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options)
            :base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StackConfiguration());
            modelBuilder.ApplyConfiguration(new CardConfiguration());
        }
        public DbSet<Stack> Stacks { get; set; }
        public DbSet<Card> Cards { get; set; }
    }
}
