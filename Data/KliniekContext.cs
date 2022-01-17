using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Models;

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
    }
