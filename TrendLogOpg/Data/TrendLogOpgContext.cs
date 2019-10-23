using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TrendLogOpg.Models;

namespace TrendLogOpg.Models
{
    public class TrendLogOpgContext : DbContext
    {
        public TrendLogOpgContext (DbContextOptions<TrendLogOpgContext> options)
            : base(options)
        {
        }
        public DbSet<TrendLogOpg.Models.Author> Author { get; set; }

    }
}
