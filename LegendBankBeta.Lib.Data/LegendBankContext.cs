using LegendBankBeta.Lib.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace LegendBankBeta.Lib.Data
{
    public class LegendBankContext : DbContext
    {
        /// <summary>
        /// Database Sets/Tables for the App
        /// </summary>
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<User> Users { get; set; }
        
        //Constructor for Development
        public LegendBankContext()
        {

        }
        //Constructor for Testing
        public LegendBankContext(DbContextOptions<LegendBankContext> options):base(options)
        {

        }

        /// <summary>
        /// Establishes Database Connection
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite(@"Data Source=C:\Users\hp\Documents\Projects\LegendBankBeta\LegendBankBeta.Lib.Data\LegendBank.db");
            }
        }
    }
}
