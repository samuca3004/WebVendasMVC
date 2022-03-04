using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebVendasMVC.Models;

namespace WebVendasMVC.Data
{
    public class WebVendasMVCContext : DbContext
    {
        public WebVendasMVCContext (DbContextOptions<WebVendasMVCContext> options)
            : base(options)
        {
        }

        public DbSet<WebVendasMVC.Models.Department> Department { get; set; }
        public DbSet<WebVendasMVC.Models.Seller> Seller { get;}

        public DbSet<WebVendasMVC.Models.SalesRecord> SalesRecord { get; set; }
    }
}
