using Data.LimeZander.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace Data.LimeZander.Persistence
{
    public class LimeZanderContext: DbContext
    {
        public LimeZanderContext(DbContextOptions<LimeZanderContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
