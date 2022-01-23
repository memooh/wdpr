using Microsoft.EntityFrameworkCore.Migrations;

namespace wdpr.Migrations
{
    public partial class testing3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aanmeldingen_Gebruikers_BehandelaarId",
                table: "Aanmeldingen");

            migrationBuilder.DropForeignKey(
                name: "FK_Aanmeldingen_Gebruikers_VoogdId",
                table: "Aanmeldingen");

            migrationBuilder.DropForeignKey(
                name: "FK_Afspraken_Gebruikers_BehandelaarId",
                table: "Afspraken");

            migrationBuilder.DropForeignKey(
                name: "FK_Afspraken_Gebruikers_ClientId",
                table: "Afspraken");

            migrationBuilder.DropForeignKey(
                name: "FK_Behandeld_Behandelingen_BehandelingId",
                table: "Behandeld");

            migrationBuilder.DropForeignKey(
                name: "FK_Behandeld_Gebruikers_BehandelaarId",
                table: "Behandeld");

            migrationBuilder.DropForeignKey(
                name: "FK_Chats_Gebruikers_BehandelaarId",
                table: "Chats");

            migrationBuilder.DropForeignKey(
                name: "FK_Deelnames_Gebruikers_ClientId",
                table: "Deelnames");

            migrationBuilder.DropForeignKey(
                name: "FK_Gebruikers_Gebruikers_VoogdId",
                table: "Gebruikers");

            migrationBuilder.DropForeignKey(
                name: "FK_Melding_Berichten_BerichtId",
                table: "Melding");

            migrationBuilder.DropForeignKey(
                name: "FK_ZelfhulpDeelnames_Gebruikers_ClientId",
                table: "ZelfhulpDeelnames");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Melding",
                table: "Melding");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Gebruikers",
                table: "Gebruikers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Behandeld",
                table: "Behandeld");

            migrationBuilder.RenameTable(
                name: "Melding",
                newName: "Meldingen");

            migrationBuilder.RenameTable(
                name: "Gebruikers",
                newName: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "Behandeld",
                newName: "BehandelendeGebruikers");

            migrationBuilder.RenameIndex(
                name: "IX_Melding_BerichtId",
                table: "Meldingen",
                newName: "IX_Meldingen_BerichtId");

            migrationBuilder.RenameIndex(
                name: "IX_Gebruikers_VoogdId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_VoogdId");

            migrationBuilder.RenameIndex(
                name: "IX_Behandeld_BehandelingId",
                table: "BehandelendeGebruikers",
                newName: "IX_BehandelendeGebruikers_BehandelingId");

            migrationBuilder.RenameIndex(
                name: "IX_Behandeld_BehandelaarId",
                table: "BehandelendeGebruikers",
                newName: "IX_BehandelendeGebruikers_BehandelaarId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Meldingen",
                table: "Meldingen",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BehandelendeGebruikers",
                table: "BehandelendeGebruikers",
                column: "Id");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e7afea1e-d4f2-47f3-932d-489d3d342bf7", "53d63b94-fbec-4af1-a0ed-44855ddbf928", "Voogd", "Voogd" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "659d1fa2-4235-4a11-89f4-f41786a08856", "a343d0e9-af06-4f88-9b11-d3fde997b12f", "Client", "Client" });

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Aanmeldingen_AspNetUsers_BehandelaarId",
                table: "Aanmeldingen",
                column: "BehandelaarId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Aanmeldingen_AspNetUsers_VoogdId",
                table: "Aanmeldingen",
                column: "VoogdId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Afspraken_AspNetUsers_BehandelaarId",
                table: "Afspraken",
                column: "BehandelaarId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Afspraken_AspNetUsers_ClientId",
                table: "Afspraken",
                column: "ClientId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_VoogdId",
                table: "AspNetUsers",
                column: "VoogdId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BehandelendeGebruikers_AspNetUsers_BehandelaarId",
                table: "BehandelendeGebruikers",
                column: "BehandelaarId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BehandelendeGebruikers_Behandelingen_BehandelingId",
                table: "BehandelendeGebruikers",
                column: "BehandelingId",
                principalTable: "Behandelingen",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Chats_AspNetUsers_BehandelaarId",
                table: "Chats",
                column: "BehandelaarId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Deelnames_AspNetUsers_ClientId",
                table: "Deelnames",
                column: "ClientId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Meldingen_Berichten_BerichtId",
                table: "Meldingen",
                column: "BerichtId",
                principalTable: "Berichten",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ZelfhulpDeelnames_AspNetUsers_ClientId",
                table: "ZelfhulpDeelnames",
                column: "ClientId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aanmeldingen_AspNetUsers_BehandelaarId",
                table: "Aanmeldingen");

            migrationBuilder.DropForeignKey(
                name: "FK_Aanmeldingen_AspNetUsers_VoogdId",
                table: "Aanmeldingen");

            migrationBuilder.DropForeignKey(
                name: "FK_Afspraken_AspNetUsers_BehandelaarId",
                table: "Afspraken");

            migrationBuilder.DropForeignKey(
                name: "FK_Afspraken_AspNetUsers_ClientId",
                table: "Afspraken");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_VoogdId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_BehandelendeGebruikers_AspNetUsers_BehandelaarId",
                table: "BehandelendeGebruikers");

            migrationBuilder.DropForeignKey(
                name: "FK_BehandelendeGebruikers_Behandelingen_BehandelingId",
                table: "BehandelendeGebruikers");

            migrationBuilder.DropForeignKey(
                name: "FK_Chats_AspNetUsers_BehandelaarId",
                table: "Chats");

            migrationBuilder.DropForeignKey(
                name: "FK_Deelnames_AspNetUsers_ClientId",
                table: "Deelnames");

            migrationBuilder.DropForeignKey(
                name: "FK_Meldingen_Berichten_BerichtId",
                table: "Meldingen");

            migrationBuilder.DropForeignKey(
                name: "FK_ZelfhulpDeelnames_AspNetUsers_ClientId",
                table: "ZelfhulpDeelnames");

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
                name: "AspNetRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Meldingen",
                table: "Meldingen");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BehandelendeGebruikers",
                table: "BehandelendeGebruikers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "EmailIndex",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "UserNameIndex",
                table: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "Meldingen",
                newName: "Melding");

            migrationBuilder.RenameTable(
                name: "BehandelendeGebruikers",
                newName: "Behandeld");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                newName: "Gebruikers");

            migrationBuilder.RenameIndex(
                name: "IX_Meldingen_BerichtId",
                table: "Melding",
                newName: "IX_Melding_BerichtId");

            migrationBuilder.RenameIndex(
                name: "IX_BehandelendeGebruikers_BehandelingId",
                table: "Behandeld",
                newName: "IX_Behandeld_BehandelingId");

            migrationBuilder.RenameIndex(
                name: "IX_BehandelendeGebruikers_BehandelaarId",
                table: "Behandeld",
                newName: "IX_Behandeld_BehandelaarId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_VoogdId",
                table: "Gebruikers",
                newName: "IX_Gebruikers_VoogdId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Melding",
                table: "Melding",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Behandeld",
                table: "Behandeld",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Gebruikers",
                table: "Gebruikers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Aanmeldingen_Gebruikers_BehandelaarId",
                table: "Aanmeldingen",
                column: "BehandelaarId",
                principalTable: "Gebruikers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Aanmeldingen_Gebruikers_VoogdId",
                table: "Aanmeldingen",
                column: "VoogdId",
                principalTable: "Gebruikers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Afspraken_Gebruikers_BehandelaarId",
                table: "Afspraken",
                column: "BehandelaarId",
                principalTable: "Gebruikers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Afspraken_Gebruikers_ClientId",
                table: "Afspraken",
                column: "ClientId",
                principalTable: "Gebruikers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Behandeld_Behandelingen_BehandelingId",
                table: "Behandeld",
                column: "BehandelingId",
                principalTable: "Behandelingen",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Behandeld_Gebruikers_BehandelaarId",
                table: "Behandeld",
                column: "BehandelaarId",
                principalTable: "Gebruikers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Chats_Gebruikers_BehandelaarId",
                table: "Chats",
                column: "BehandelaarId",
                principalTable: "Gebruikers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Deelnames_Gebruikers_ClientId",
                table: "Deelnames",
                column: "ClientId",
                principalTable: "Gebruikers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Gebruikers_Gebruikers_VoogdId",
                table: "Gebruikers",
                column: "VoogdId",
                principalTable: "Gebruikers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Melding_Berichten_BerichtId",
                table: "Melding",
                column: "BerichtId",
                principalTable: "Berichten",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ZelfhulpDeelnames_Gebruikers_ClientId",
                table: "ZelfhulpDeelnames",
                column: "ClientId",
                principalTable: "Gebruikers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
