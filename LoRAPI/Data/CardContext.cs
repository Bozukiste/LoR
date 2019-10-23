using LoRAPI.DbSetup;
using LoRAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoRAPI.Data
{
    public class CardContext : DbContext
    {
        public CardContext(DbContextOptions pOptions) : base(pOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Card>().HasData(CardDataPopulator.Populate());
        }

        public DbSet<Card> Cards { get; set; }
    }
}
