using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Models;
using System;


public class KliniekContext : IdentityDbContext
    {
        public KliniekContext (DbContextOptions<KliniekContext> options): base(options){}

        public DbSet<Aanmelding> Aanmeldingen { get; set; }
        public DbSet<Afspraak> Afspraken { get; set; }
        public DbSet<Behandeling> Behandelingen { get; set; }
        public DbSet<Bericht> Berichten {get; set;}
        public DbSet<Chat> Chats {get; set;}
        public DbSet<Deelname> Deelnames {get; set;}
        public DbSet<Gebruiker> Gebruikers {get; set;}
        public DbSet<ZelfhulpDeelname> ZelfhulpDeelnames {get; set;}
        public DbSet<Zelfhulpgroep> Zelfhulpgroepen {get; set;}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Zelfhulpgroep>().HasOne<ZelfhulpDeelname>(z => z.Deelname).WithOne(z => z.Zelfhulpgroep).HasForeignKey<ZelfhulpDeelname>(z => z.ZelfhulpgroepId);
            builder.Entity<IdentityRole>().HasData(new IdentityRole { Name = "Hulpverlener", NormalizedName = "HULPVERLENER", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() });
            builder.Entity<IdentityRole>().HasData(new IdentityRole { Name = "Patient", NormalizedName = "PATIENT", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() });
            base.OnModelCreating(builder);
        }
    }

