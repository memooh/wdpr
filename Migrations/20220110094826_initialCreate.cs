using Microsoft.EntityFrameworkCore.Migrations;

namespace wdpr.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gebruiker",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Voornaam = table.Column<string>(type: "TEXT", nullable: true),
                    Achternaam = table.Column<string>(type: "TEXT", nullable: true),
                    Leeftijd = table.Column<int>(type: "INTEGER", nullable: false),
                    Moderator = table.Column<bool>(type: "INTEGER", nullable: false),
                    Orthopedagoog = table.Column<bool>(type: "INTEGER", nullable: false),
                    Client = table.Column<bool>(type: "INTEGER", nullable: false),
                    Stagair = table.Column<bool>(type: "INTEGER", nullable: false),
                    Administratie = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gebruiker", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gebruiker");
        }
    }
}
