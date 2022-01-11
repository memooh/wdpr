using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using wdpr;

    public class KliniekContext : DbContext
    {
        public KliniekContext (DbContextOptions<KliniekContext> options)
            : base(options)
        {
        }

        public DbSet<wdpr.Gebruiker> Gebruiker { get; set; }
    }
