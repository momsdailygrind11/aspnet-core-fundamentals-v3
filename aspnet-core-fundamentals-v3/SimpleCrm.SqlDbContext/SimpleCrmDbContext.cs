using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using aspnet_core_fundamentals_v3.web;
using Microsoft.EntityFrameworkCore;

namespace SimpleCrm.SqlDbServices
{
    class SimpleCrmDbContext : DbContext
    {
        public SimpleCrmDbContext(DbContextOptions<SimpleCrmDbContext> options)
            : base(options)   { }
            public DbSet<Customer> Customers { get; set; }
        
    }
}
