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

            builder.Entity<IdentityRole>().HasData(new IdentityRole { Name = "Voogd", NormalizedName = "Voogd", Id = "fb8be9c0-aa65-4af8-bd17-00bd9344e575", ConcurrencyStamp = Guid.NewGuid().ToString() });
            builder.Entity<IdentityRole>().HasData(new IdentityRole { Name = "Client", NormalizedName = "Client", Id = "fc8be9c0-aa65-4af8-bd17-00bd9344e575", ConcurrencyStamp = Guid.NewGuid().ToString() });
            builder.Entity<IdentityRole>().HasData(new IdentityRole { Name = "Behandelaar", NormalizedName = "Behandelaar", Id = "fd8be9c0-aa65-4af8-bd17-00bd9344e575", ConcurrencyStamp = Guid.NewGuid().ToString() });
            builder.Entity<IdentityRole>().HasData(new IdentityRole { Name = "Moderator", NormalizedName = "Moderator", Id = "fe8be9c0-aa65-4af8-bd17-00bd9344e575", ConcurrencyStamp = Guid.NewGuid().ToString() });

            var hasher = new PasswordHasher<Gebruiker>();

            builder.Entity<Gebruiker>().HasData(new Gebruiker
            {
                Id = "ub8be9c0-aa65-4af8-bd17-00bd9344e575",
                UserName = "moderator@test.nl",
                NormalizedUserName = "moderator@test.nl",
                Email = "moderator@test.nl",
                NormalizedEmail = "moderator@test.nl",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Test12!"),
                SecurityStamp = string.Empty,
                Voornaam = "Moderator",
                Achternaam = "Account",
                IsActief = true,
                Geboortedatum = new DateTime(2000, 12, 31, 5, 10, 20)
            });

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "fd8be9c0-aa65-4af8-bd17-00bd9344e575",
                UserId = "ub8be9c0-aa65-4af8-bd17-00bd9344e575"
            });

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "fe8be9c0-aa65-4af8-bd17-00bd9344e575",
                UserId = "ub8be9c0-aa65-4af8-bd17-00bd9344e575"
            });

            builder.Entity<Behandeling>().HasData(new Behandeling
            {
                Id = 1,
                Naam = "ADHD",
                Beschrijving = "Het oplossen en behandelen van je ADHD"
            });

            builder.Entity<Behandeling>().HasData(new Behandeling
            {
                Id = 2,
                Naam = "Paniekaanvallen",
                Beschrijving = "Ook last van paniekaanvallen? Dit kan heel veel probleme veroorzaken"
            });

            builder.Entity<Behandeling>().HasData(new Behandeling
            {
                Id = 3,
                Naam = "Autisme",
                Beschrijving = "Het behandelen van autisme is erg zwaar, hiervoor is veel aandacht nodig"
            });

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
