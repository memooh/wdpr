using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Models;

public class KliniekContext : IdentityDbContext<Gebruiker>
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
        public DbSet<Melding> Meldingen {get; set;}
        public DbSet<Behandeld> BehandelendeGebruikers {get; set;}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(new IdentityRole { Name = "Voogd", NormalizedName = "Voogd", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() });
            builder.Entity<IdentityRole>().HasData(new IdentityRole { Name = "Client", NormalizedName = "Client", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() });

            builder.Entity<Chat>()
            .HasOne(a => a.Zelfhulpgroep)
            .WithOne(b => b.Chat)
            .HasForeignKey<Chat>(b => b.ZelfhulpgroepInt)
            .IsRequired(false);

            builder.Entity<Gebruiker>()
            .HasOne(s => s.Voogd)
            .WithMany(s => s.Voogdij);
        }
    }
