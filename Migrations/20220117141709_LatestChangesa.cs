using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace wdpr.Migrations
{
    public partial class LatestChangesa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Behandeld_AspNetUsers_BehandelaarId",
                table: "Behandeld");

            migrationBuilder.DropForeignKey(
                name: "FK_Behandeld_Behandelingen_BehandelingId",
                table: "Behandeld");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Behandeld",
                table: "Behandeld");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c4ec5ac-4c58-4a28-b398-dc148de5f52e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9a824af7-1755-4076-b3d4-17e4e3c95ff9");

            migrationBuilder.RenameTable(
                name: "Behandeld",
                newName: "BehandelendeGebruikers");

            migrationBuilder.RenameIndex(
                name: "IX_Behandeld_BehandelingId",
                table: "BehandelendeGebruikers",
                newName: "IX_BehandelendeGebruikers_BehandelingId");

            migrationBuilder.RenameIndex(
                name: "IX_Behandeld_BehandelaarId",
                table: "BehandelendeGebruikers",
                newName: "IX_BehandelendeGebruikers_BehandelaarId");

            migrationBuilder.AddColumn<int>(
                name: "MeldingId",
                table: "Berichten",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_BehandelendeGebruikers",
                table: "BehandelendeGebruikers",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Meldingen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Beschrijving = table.Column<string>(type: "TEXT", nullable: true),
                    Datum = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meldingen", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ac497774-c649-4ec9-b463-756405b7ab9b", "4a13c480-4d6f-4cda-acc3-d2054afb8673", "Voogd", "Voogd" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c5029d62-c822-4afc-b64f-cd26fb055acc", "facf9ce2-dd3c-4019-a3f2-20a74e7d2b90", "Client", "Client" });

            migrationBuilder.CreateIndex(
                name: "IX_Berichten_MeldingId",
                table: "Berichten",
                column: "MeldingId");

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
                name: "FK_Berichten_Meldingen_MeldingId",
                table: "Berichten",
                column: "MeldingId",
                principalTable: "Meldingen",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BehandelendeGebruikers_AspNetUsers_BehandelaarId",
                table: "BehandelendeGebruikers");

            migrationBuilder.DropForeignKey(
                name: "FK_BehandelendeGebruikers_Behandelingen_BehandelingId",
                table: "BehandelendeGebruikers");

            migrationBuilder.DropForeignKey(
                name: "FK_Berichten_Meldingen_MeldingId",
                table: "Berichten");

            migrationBuilder.DropTable(
                name: "Meldingen");

            migrationBuilder.DropIndex(
                name: "IX_Berichten_MeldingId",
                table: "Berichten");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BehandelendeGebruikers",
                table: "BehandelendeGebruikers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac497774-c649-4ec9-b463-756405b7ab9b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5029d62-c822-4afc-b64f-cd26fb055acc");

            migrationBuilder.DropColumn(
                name: "MeldingId",
                table: "Berichten");

            migrationBuilder.RenameTable(
                name: "BehandelendeGebruikers",
                newName: "Behandeld");

            migrationBuilder.RenameIndex(
                name: "IX_BehandelendeGebruikers_BehandelingId",
                table: "Behandeld",
                newName: "IX_Behandeld_BehandelingId");

            migrationBuilder.RenameIndex(
                name: "IX_BehandelendeGebruikers_BehandelaarId",
                table: "Behandeld",
                newName: "IX_Behandeld_BehandelaarId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Behandeld",
                table: "Behandeld",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9a824af7-1755-4076-b3d4-17e4e3c95ff9", "f8869256-be7a-4f6f-9698-aa11fe030596", "Voogd", "Voogd" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0c4ec5ac-4c58-4a28-b398-dc148de5f52e", "097d07c1-b825-4ebb-8ee8-c75e754b7262", "Client", "Client" });

            migrationBuilder.AddForeignKey(
                name: "FK_Behandeld_AspNetUsers_BehandelaarId",
                table: "Behandeld",
                column: "BehandelaarId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Behandeld_Behandelingen_BehandelingId",
                table: "Behandeld",
                column: "BehandelingId",
                principalTable: "Behandelingen",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
