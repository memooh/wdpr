using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace wdpr.Migrations
{
    public partial class NewClasses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gebruiker");

            migrationBuilder.CreateTable(
                name: "Behandelingen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Naam = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Behandelingen", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gebruikers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Gebruikersnaam = table.Column<string>(type: "TEXT", nullable: true),
                    Wachtwoord = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Geboortedatum = table.Column<DateTime>(type: "TEXT", nullable: false),
                    VoogdId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gebruikers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gebruikers_Gebruikers_VoogdId",
                        column: x => x.VoogdId,
                        principalTable: "Gebruikers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Zelfhulpgroepen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Naam = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zelfhulpgroepen", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Aanmeldingen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Datum = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Gebruikersnaam = table.Column<string>(type: "TEXT", nullable: true),
                    Voornaam = table.Column<string>(type: "TEXT", nullable: true),
                    Achternaam = table.Column<string>(type: "TEXT", nullable: true),
                    GeboorteDatum = table.Column<DateTime>(type: "TEXT", nullable: false),
                    BehandelaarId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aanmeldingen", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Aanmeldingen_Gebruikers_BehandelaarId",
                        column: x => x.BehandelaarId,
                        principalTable: "Gebruikers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Afspraken",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Datum = table.Column<DateTime>(type: "TEXT", nullable: false),
                    _BehandelingId = table.Column<int>(type: "INTEGER", nullable: true),
                    BehandelaarId = table.Column<int>(type: "INTEGER", nullable: true),
                    ClientId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Afspraken", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Afspraken_Behandelingen__BehandelingId",
                        column: x => x._BehandelingId,
                        principalTable: "Behandelingen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Afspraken_Gebruikers_BehandelaarId",
                        column: x => x.BehandelaarId,
                        principalTable: "Gebruikers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Afspraken_Gebruikers_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Gebruikers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Chats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Naam = table.Column<string>(type: "TEXT", nullable: true),
                    BehandelaarId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chats_Gebruikers_BehandelaarId",
                        column: x => x.BehandelaarId,
                        principalTable: "Gebruikers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ZelfhulpDeelnames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Toetredingsdatum = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ZelfhulpgroepId = table.Column<int>(type: "INTEGER", nullable: true),
                    ClientId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZelfhulpDeelnames", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ZelfhulpDeelnames_Gebruikers_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Gebruikers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ZelfhulpDeelnames_Zelfhulpgroepen_ZelfhulpgroepId",
                        column: x => x.ZelfhulpgroepId,
                        principalTable: "Zelfhulpgroepen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Berichten",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Beschrijving = table.Column<string>(type: "TEXT", nullable: true),
                    Datum = table.Column<DateTime>(type: "TEXT", nullable: false),
                    VerzenderId = table.Column<int>(type: "INTEGER", nullable: true),
                    ChatId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Berichten", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Berichten_Chats_ChatId",
                        column: x => x.ChatId,
                        principalTable: "Chats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Berichten_Gebruikers_VerzenderId",
                        column: x => x.VerzenderId,
                        principalTable: "Gebruikers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Deelnames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Toetredingsdatum = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ChatId = table.Column<int>(type: "INTEGER", nullable: true),
                    ClientId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deelnames", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Deelnames_Chats_ChatId",
                        column: x => x.ChatId,
                        principalTable: "Chats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Deelnames_Gebruikers_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Gebruikers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Aanmeldingen_BehandelaarId",
                table: "Aanmeldingen",
                column: "BehandelaarId");

            migrationBuilder.CreateIndex(
                name: "IX_Afspraken__BehandelingId",
                table: "Afspraken",
                column: "_BehandelingId");

            migrationBuilder.CreateIndex(
                name: "IX_Afspraken_BehandelaarId",
                table: "Afspraken",
                column: "BehandelaarId");

            migrationBuilder.CreateIndex(
                name: "IX_Afspraken_ClientId",
                table: "Afspraken",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Berichten_ChatId",
                table: "Berichten",
                column: "ChatId");

            migrationBuilder.CreateIndex(
                name: "IX_Berichten_VerzenderId",
                table: "Berichten",
                column: "VerzenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Chats_BehandelaarId",
                table: "Chats",
                column: "BehandelaarId");

            migrationBuilder.CreateIndex(
                name: "IX_Deelnames_ChatId",
                table: "Deelnames",
                column: "ChatId");

            migrationBuilder.CreateIndex(
                name: "IX_Deelnames_ClientId",
                table: "Deelnames",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Gebruikers_VoogdId",
                table: "Gebruikers",
                column: "VoogdId");

            migrationBuilder.CreateIndex(
                name: "IX_ZelfhulpDeelnames_ClientId",
                table: "ZelfhulpDeelnames",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_ZelfhulpDeelnames_ZelfhulpgroepId",
                table: "ZelfhulpDeelnames",
                column: "ZelfhulpgroepId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aanmeldingen");

            migrationBuilder.DropTable(
                name: "Afspraken");

            migrationBuilder.DropTable(
                name: "Berichten");

            migrationBuilder.DropTable(
                name: "Deelnames");

            migrationBuilder.DropTable(
                name: "ZelfhulpDeelnames");

            migrationBuilder.DropTable(
                name: "Behandelingen");

            migrationBuilder.DropTable(
                name: "Chats");

            migrationBuilder.DropTable(
                name: "Zelfhulpgroepen");

            migrationBuilder.DropTable(
                name: "Gebruikers");

            migrationBuilder.CreateTable(
                name: "Gebruiker",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Achternaam = table.Column<string>(type: "TEXT", nullable: true),
                    Administratie = table.Column<bool>(type: "INTEGER", nullable: false),
                    Client = table.Column<bool>(type: "INTEGER", nullable: false),
                    Leeftijd = table.Column<int>(type: "INTEGER", nullable: false),
                    Moderator = table.Column<bool>(type: "INTEGER", nullable: false),
                    Orthopedagoog = table.Column<bool>(type: "INTEGER", nullable: false),
                    Stagair = table.Column<bool>(type: "INTEGER", nullable: false),
                    Voornaam = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gebruiker", x => x.Id);
                });
        }
    }
}
