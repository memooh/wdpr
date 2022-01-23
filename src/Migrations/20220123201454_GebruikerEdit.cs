using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace wdpr.Migrations
{
    public partial class GebruikerEdit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Geboortedatum = table.Column<DateTime>(type: "TEXT", nullable: false),
                    BehandelaarId1 = table.Column<int>(type: "INTEGER", nullable: true),
                    BehandelaarId = table.Column<int>(type: "INTEGER", nullable: false),
                    VoogdId1 = table.Column<string>(type: "TEXT", nullable: true),
                    VoogdId = table.Column<int>(type: "INTEGER", nullable: false),
                    GebruikerVoogdId = table.Column<int>(type: "INTEGER", nullable: true),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.UniqueConstraint("AK_AspNetUsers_BehandelaarId", x => x.BehandelaarId);
                    table.UniqueConstraint("AK_AspNetUsers_VoogdId", x => x.VoogdId);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_AspNetUsers_BehandelaarId1",
                        column: x => x.BehandelaarId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "BehandelaarId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_AspNetUsers_GebruikerVoogdId",
                        column: x => x.GebruikerVoogdId,
                        principalTable: "AspNetUsers",
                        principalColumn: "VoogdId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_AspNetUsers_VoogdId1",
                        column: x => x.VoogdId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    VoogdId = table.Column<string>(type: "TEXT", nullable: true),
                    BehandelaarId = table.Column<string>(type: "TEXT", nullable: true),
                    HeeftAccount = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aanmeldingen", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Aanmeldingen_AspNetUsers_BehandelaarId",
                        column: x => x.BehandelaarId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Aanmeldingen_AspNetUsers_VoogdId",
                        column: x => x.VoogdId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Afspraken",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Datum = table.Column<DateTime>(type: "TEXT", nullable: false),
                    BehandelingId = table.Column<int>(type: "INTEGER", nullable: true),
                    BehandelaarId = table.Column<string>(type: "TEXT", nullable: true),
                    ClientId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Afspraken", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Afspraken_AspNetUsers_BehandelaarId",
                        column: x => x.BehandelaarId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Afspraken_AspNetUsers_ClientId",
                        column: x => x.ClientId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Afspraken_Behandelingen_BehandelingId",
                        column: x => x.BehandelingId,
                        principalTable: "Behandelingen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BehandelendeGebruikers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BehandelingId = table.Column<int>(type: "INTEGER", nullable: true),
                    BehandelaarId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BehandelendeGebruikers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BehandelendeGebruikers_AspNetUsers_BehandelaarId",
                        column: x => x.BehandelaarId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BehandelendeGebruikers_Behandelingen_BehandelingId",
                        column: x => x.BehandelingId,
                        principalTable: "Behandelingen",
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
                    Actief = table.Column<bool>(type: "INTEGER", nullable: false),
                    BehandelaarId = table.Column<string>(type: "TEXT", nullable: true),
                    ZelfhulpgroepInt = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chats_AspNetUsers_BehandelaarId",
                        column: x => x.BehandelaarId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Chats_Zelfhulpgroepen_ZelfhulpgroepInt",
                        column: x => x.ZelfhulpgroepInt,
                        principalTable: "Zelfhulpgroepen",
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
                    ClientId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZelfhulpDeelnames", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ZelfhulpDeelnames_AspNetUsers_ClientId",
                        column: x => x.ClientId,
                        principalTable: "AspNetUsers",
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
                name: "Deelnames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Toetredingsdatum = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Geblokkeerd = table.Column<bool>(type: "INTEGER", nullable: false),
                    ChatId = table.Column<int>(type: "INTEGER", nullable: true),
                    ClientId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deelnames", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Deelnames_AspNetUsers_ClientId",
                        column: x => x.ClientId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Deelnames_Chats_ChatId",
                        column: x => x.ChatId,
                        principalTable: "Chats",
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
                    DeelnameId = table.Column<int>(type: "INTEGER", nullable: true),
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
                        name: "FK_Berichten_Deelnames_DeelnameId",
                        column: x => x.DeelnameId,
                        principalTable: "Deelnames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Meldingen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Beschrijving = table.Column<string>(type: "TEXT", nullable: true),
                    Datum = table.Column<DateTime>(type: "TEXT", nullable: false),
                    BerichtId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meldingen", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Meldingen_Berichten_BerichtId",
                        column: x => x.BerichtId,
                        principalTable: "Berichten",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c25642d7-c506-4f2b-86a8-6a30c38cd8a0", "cc26aaa2-8a31-46b3-b036-facc2d7ac678", "Voogd", "Voogd" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e272c18a-d4d8-44d3-8e8d-9432e308e7d5", "8fcaff1d-20c2-4831-a024-1c9d854f74e9", "Client", "Client" });

            migrationBuilder.CreateIndex(
                name: "IX_Aanmeldingen_BehandelaarId",
                table: "Aanmeldingen",
                column: "BehandelaarId");

            migrationBuilder.CreateIndex(
                name: "IX_Aanmeldingen_VoogdId",
                table: "Aanmeldingen",
                column: "VoogdId");

            migrationBuilder.CreateIndex(
                name: "IX_Afspraken_BehandelaarId",
                table: "Afspraken",
                column: "BehandelaarId");

            migrationBuilder.CreateIndex(
                name: "IX_Afspraken_BehandelingId",
                table: "Afspraken",
                column: "BehandelingId");

            migrationBuilder.CreateIndex(
                name: "IX_Afspraken_ClientId",
                table: "Afspraken",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_BehandelaarId1",
                table: "AspNetUsers",
                column: "BehandelaarId1");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_GebruikerVoogdId",
                table: "AspNetUsers",
                column: "GebruikerVoogdId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_VoogdId1",
                table: "AspNetUsers",
                column: "VoogdId1");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BehandelendeGebruikers_BehandelaarId",
                table: "BehandelendeGebruikers",
                column: "BehandelaarId");

            migrationBuilder.CreateIndex(
                name: "IX_BehandelendeGebruikers_BehandelingId",
                table: "BehandelendeGebruikers",
                column: "BehandelingId");

            migrationBuilder.CreateIndex(
                name: "IX_Berichten_ChatId",
                table: "Berichten",
                column: "ChatId");

            migrationBuilder.CreateIndex(
                name: "IX_Berichten_DeelnameId",
                table: "Berichten",
                column: "DeelnameId");

            migrationBuilder.CreateIndex(
                name: "IX_Chats_BehandelaarId",
                table: "Chats",
                column: "BehandelaarId");

            migrationBuilder.CreateIndex(
                name: "IX_Chats_ZelfhulpgroepInt",
                table: "Chats",
                column: "ZelfhulpgroepInt",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Deelnames_ChatId",
                table: "Deelnames",
                column: "ChatId");

            migrationBuilder.CreateIndex(
                name: "IX_Deelnames_ClientId",
                table: "Deelnames",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Meldingen_BerichtId",
                table: "Meldingen",
                column: "BerichtId");

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
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BehandelendeGebruikers");

            migrationBuilder.DropTable(
                name: "Meldingen");

            migrationBuilder.DropTable(
                name: "ZelfhulpDeelnames");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Behandelingen");

            migrationBuilder.DropTable(
                name: "Berichten");

            migrationBuilder.DropTable(
                name: "Deelnames");

            migrationBuilder.DropTable(
                name: "Chats");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Zelfhulpgroepen");
        }
    }
}
