using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using web_pc.Models;

namespace web_pc.Data
{
    public class web_pcContext : DbContext
    {
        public web_pcContext (DbContextOptions<web_pcContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller         { get; set; }
        public DbSet<SalesRecord> Sales     { get; set; }
    }
}
