using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TpFreelancer.Models;

namespace TpFreelancer.Data
{
    public class TpFreelancerContext : DbContext
    {
        public TpFreelancerContext(DbContextOptions<TpFreelancerContext> options)
            : base(options)
        {
        }

        public DbSet<TpFreelancer.Models.CustomersModel> CustomersModel { get; set; }

        public DbSet<TpFreelancer.Models.CustomerCatsModel> CustomersCatsModel { get; set; }

        public DbSet<TpFreelancer.Models.JobsModel> JobsModel { get; set; }

        public DbSet<TpFreelancer.Models.QuotesModel> QuotesModels { get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Add unique constraint to the customers table
            modelBuilder.Entity<CustomersModel>()
                .HasIndex(p => new { p.CustomerName, p.CustomerEmail })
                .IsUnique(true);
            
            // Add unique constraint to the customers_cats table
            modelBuilder.Entity<CustomerCatsModel>()
                .HasIndex(p => new { p.CatName })
                .IsUnique(true);
         }
    }
}
