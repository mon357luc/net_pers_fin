using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using net_pers_fin.Models;

namespace net_pers_fin.Data
{
    public class net_pers_fin_context : DbContext
    {
        public net_pers_fin_context (DbContextOptions<net_pers_fin_context> options)
            : base(options)
        {
        }

        public DbSet<net_pers_fin.Models.user> user { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<net_pers_fin.Models.user>()
                .Property(u => u.createdon)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");
        }
    }
}
