using Microsoft.EntityFrameworkCore;
using NArchitecture.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NArchitecture.Data
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Product> Product { get; set; }    

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options) { 
        
        
        
        
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
