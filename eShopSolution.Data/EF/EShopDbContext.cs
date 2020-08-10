using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.EF
{
    class EShopDbContext : DbContext
    {
        public EShopDbContext(DbContextOptions options) : base(options)
        {           
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
