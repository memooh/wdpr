using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Models;
using Xunit;

namespace test
{
    public class UnitTest1
    {
        [Fact]
        public void Aantal_Deelnames_Testen()
        {
            DbContextOptions<KliniekContext> options = new DbContextOptionsBuilder<KliniekContext>().UseInMemoryDatabase("MijnDatabase").Options;
            var c = new KliniekContext(options);

            Gebruiker Behandelaar = new Gebruiker {
                Email = "test@test.nl",
                UserName = "test@test.nl",
            };

            Gebruiker Client = new Gebruiker {
                Email = "client@test.nl",
                UserName = "client@test.nl",
            };

            c.Gebruikers.Add(Behandelaar);
            c.Gebruikers.Add(Client);

            Chat Gesprek = new Chat {
                Naam = "Chat",
                Behandelaar = Behandelaar  
            };

            c.Chats.Add(Gesprek);

            c.Deelnames.Add(new Deelname {
                Chat = Gesprek,
                Client = Behandelaar,
                Toetredingsdatum = new DateTime(),
            });

            c.Deelnames.Add(new Deelname {
                Chat = Gesprek,
                Client = Client,
                Toetredingsdatum = new DateTime(),
            });

            c.SaveChanges();

            Assert.Equal(2, c.Deelnames.Count());
        }
        
        [Fact]  
        public void Aantal_Berichten_Testen()
        {
            DbContextOptions<KliniekContext> options = new DbContextOptionsBuilder<KliniekContext>().UseInMemoryDatabase("MijnDatabase").Options;
            var c = new KliniekContext(options);

            Gebruiker Behandelaar = new Gebruiker {
                Email = "test@test.nl",
                UserName = "test@test.nl",
            };

            Gebruiker Client = new Gebruiker {
                Email = "client@test.nl",
                UserName = "client@test.nl",
            };

            c.Gebruikers.Add(Behandelaar);
            c.Gebruikers.Add(Client);

            Chat Gesprek = new Chat {
                Naam = "Chat",
                Behandelaar = Behandelaar  
            };

            c.Chats.Add(Gesprek);

            Deelname BehandelaarDeelname = new Deelname {
                Chat = Gesprek,
                Client = Behandelaar,
                Toetredingsdatum = new DateTime(),
            };
        
            Deelname ClientDeelname = new Deelname {
                Chat = Gesprek,
                Client = Client,
                Toetredingsdatum = new DateTime(),
            };

            c.Deelnames.Add(ClientDeelname);
            c.Deelnames.Add(BehandelaarDeelname);

            c.Berichten.Add(new Bericht {
                Beschrijving = "Bericht 1",
                Datum = new DateTime(),
                Deelname = ClientDeelname
            });

            c.Berichten.Add(new Bericht {
                Beschrijving = "Bericht 2",
                Datum = new DateTime(),
                Deelname = ClientDeelname
            });

            c.Berichten.Add(new Bericht {
                Beschrijving = "Bericht 3",
                Datum = new DateTime(),
                Deelname = ClientDeelname
            });

            c.Berichten.Add(new Bericht {
                Beschrijving = "Bericht 4",
                Datum = new DateTime(),
                Deelname = BehandelaarDeelname
            });

            c.SaveChanges();

            Assert.Equal(3, c.Berichten.Where(b => b.Deelname == ClientDeelname).Count());
            Assert.Equal(1, c.Berichten.Where(b => b.Deelname == BehandelaarDeelname).Count());
        }
    }
}
