using Microsoft.EntityFrameworkCore.Migrations;

namespace wdpr.Migrations
{
    public partial class behandelaarModel4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Behandelaren_BehandelaarId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_BehandelaarId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "39250f60-585f-4a0c-bb2b-5d55dc2bc589");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "60ab3e44-ebb7-4d30-8e08-c9c7618128b7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "db4eab7e-0935-42bf-806d-df4d372282bd");

            migrationBuilder.AddColumn<int>(
                name: "BehandelaarsClientenId",
                table: "Behandelaren",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "GebruikerId",
                table: "Behandelaren",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BehandelaarsClientenId",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BehandelaarsClienten",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BehandelaarId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BehandelaarsClienten", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BehandelaarsClienten_Behandelaren_BehandelaarId",
                        column: x => x.BehandelaarId,
                        principalTable: "Behandelaren",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d8716eaf-6468-490d-8274-2ae690c874a9", "79c89d04-5397-445d-a5a5-a011d10f5559", "Hulpverlener", "HULPVERLENER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a2b52860-91d1-4469-9f10-e87b82a13d2e", "413ea522-84b3-4c67-bef7-8f6bac21f7d1", "Patient", "PATIENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4e48c56e-4b0e-4514-bc70-ac5a8be843ea", "368bfed2-08a4-4ff0-8127-e17bd13a8977", "Moderator", "MODERATOR" });

            migrationBuilder.CreateIndex(
                name: "IX_Behandelaren_GebruikerId",
                table: "Behandelaren",
                column: "GebruikerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_BehandelaarsClientenId",
                table: "AspNetUsers",
                column: "BehandelaarsClientenId");

            migrationBuilder.CreateIndex(
                name: "IX_BehandelaarsClienten_BehandelaarId",
                table: "BehandelaarsClienten",
                column: "BehandelaarId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_BehandelaarsClienten_BehandelaarsClientenId",
                table: "AspNetUsers",
                column: "BehandelaarsClientenId",
                principalTable: "BehandelaarsClienten",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Behandelaren_AspNetUsers_GebruikerId",
                table: "Behandelaren",
                column: "GebruikerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_BehandelaarsClienten_BehandelaarsClientenId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Behandelaren_AspNetUsers_GebruikerId",
                table: "Behandelaren");

            migrationBuilder.DropTable(
                name: "BehandelaarsClienten");

            migrationBuilder.DropIndex(
                name: "IX_Behandelaren_GebruikerId",
                table: "Behandelaren");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_BehandelaarsClientenId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4e48c56e-4b0e-4514-bc70-ac5a8be843ea");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a2b52860-91d1-4469-9f10-e87b82a13d2e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d8716eaf-6468-490d-8274-2ae690c874a9");

            migrationBuilder.DropColumn(
                name: "BehandelaarsClientenId",
                table: "Behandelaren");

            migrationBuilder.DropColumn(
                name: "GebruikerId",
                table: "Behandelaren");

            migrationBuilder.DropColumn(
                name: "BehandelaarsClientenId",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "39250f60-585f-4a0c-bb2b-5d55dc2bc589", "24083cb4-960a-4cd3-91ab-0a6234e425b8", "Hulpverlener", "HULPVERLENER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "60ab3e44-ebb7-4d30-8e08-c9c7618128b7", "f389083c-7677-4ed3-907c-8cc32e2e458b", "Patient", "PATIENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "db4eab7e-0935-42bf-806d-df4d372282bd", "dc9cec95-b1b1-4d98-b8df-6955f464dd17", "Moderator", "MODERATOR" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_BehandelaarId",
                table: "AspNetUsers",
                column: "BehandelaarId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Behandelaren_BehandelaarId",
                table: "AspNetUsers",
                column: "BehandelaarId",
                principalTable: "Behandelaren",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
