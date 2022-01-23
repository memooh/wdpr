using Microsoft.EntityFrameworkCore.Migrations;

namespace wdpr.Migrations
{
    public partial class LatestChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aanmeldingen_AspNetUsers_BehandelaarId",
                table: "Aanmeldingen");

            migrationBuilder.DropForeignKey(
                name: "FK_Afspraken_Behandelingen__BehandelingId",
                table: "Afspraken");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5dd846a4-7692-414d-8789-885268601aec");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4339221-ad96-471e-907f-63307b2ba612");

            migrationBuilder.RenameColumn(
                name: "_BehandelingId",
                table: "Afspraken",
                newName: "BehandelingId");

            migrationBuilder.RenameIndex(
                name: "IX_Afspraken__BehandelingId",
                table: "Afspraken",
                newName: "IX_Afspraken_BehandelingId");

            migrationBuilder.RenameColumn(
                name: "BehandelaarId",
                table: "Aanmeldingen",
                newName: "VoogdId");

            migrationBuilder.RenameIndex(
                name: "IX_Aanmeldingen_BehandelaarId",
                table: "Aanmeldingen",
                newName: "IX_Aanmeldingen_VoogdId");

            migrationBuilder.CreateTable(
                name: "Behandeld",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BehandelingId = table.Column<int>(type: "INTEGER", nullable: true),
                    BehandelaarId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Behandeld", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Behandeld_AspNetUsers_BehandelaarId",
                        column: x => x.BehandelaarId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Behandeld_Behandelingen_BehandelingId",
                        column: x => x.BehandelingId,
                        principalTable: "Behandelingen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9a824af7-1755-4076-b3d4-17e4e3c95ff9", "f8869256-be7a-4f6f-9698-aa11fe030596", "Voogd", "Voogd" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0c4ec5ac-4c58-4a28-b398-dc148de5f52e", "097d07c1-b825-4ebb-8ee8-c75e754b7262", "Client", "Client" });

            migrationBuilder.CreateIndex(
                name: "IX_Behandeld_BehandelaarId",
                table: "Behandeld",
                column: "BehandelaarId");

            migrationBuilder.CreateIndex(
                name: "IX_Behandeld_BehandelingId",
                table: "Behandeld",
                column: "BehandelingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Aanmeldingen_AspNetUsers_VoogdId",
                table: "Aanmeldingen",
                column: "VoogdId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Afspraken_Behandelingen_BehandelingId",
                table: "Afspraken",
                column: "BehandelingId",
                principalTable: "Behandelingen",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aanmeldingen_AspNetUsers_VoogdId",
                table: "Aanmeldingen");

            migrationBuilder.DropForeignKey(
                name: "FK_Afspraken_Behandelingen_BehandelingId",
                table: "Afspraken");

            migrationBuilder.DropTable(
                name: "Behandeld");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c4ec5ac-4c58-4a28-b398-dc148de5f52e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9a824af7-1755-4076-b3d4-17e4e3c95ff9");

            migrationBuilder.RenameColumn(
                name: "BehandelingId",
                table: "Afspraken",
                newName: "_BehandelingId");

            migrationBuilder.RenameIndex(
                name: "IX_Afspraken_BehandelingId",
                table: "Afspraken",
                newName: "IX_Afspraken__BehandelingId");

            migrationBuilder.RenameColumn(
                name: "VoogdId",
                table: "Aanmeldingen",
                newName: "BehandelaarId");

            migrationBuilder.RenameIndex(
                name: "IX_Aanmeldingen_VoogdId",
                table: "Aanmeldingen",
                newName: "IX_Aanmeldingen_BehandelaarId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5dd846a4-7692-414d-8789-885268601aec", "d28f05ab-1c02-4a38-aa6c-99cdf40cc994", "Voogd", "Voogd" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e4339221-ad96-471e-907f-63307b2ba612", "b3ea2385-ed83-4349-8c69-1195cd445f99", "Client", "Client" });

            migrationBuilder.AddForeignKey(
                name: "FK_Aanmeldingen_AspNetUsers_BehandelaarId",
                table: "Aanmeldingen",
                column: "BehandelaarId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Afspraken_Behandelingen__BehandelingId",
                table: "Afspraken",
                column: "_BehandelingId",
                principalTable: "Behandelingen",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
