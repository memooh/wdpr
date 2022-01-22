using Microsoft.EntityFrameworkCore.Migrations;

namespace wdpr.Migrations
{
    public partial class behandelaarModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a10636b-4289-41fb-9e15-0ccc77dd39b1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c6a03ab4-0961-468e-9412-038c6c9f8637");

            migrationBuilder.AddColumn<int>(
                name: "BehandelaarId",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Behandelaren",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Behandelaren", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Behandelaren_BehandelaarId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Behandelaren");

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

            migrationBuilder.DropColumn(
                name: "BehandelaarId",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0a10636b-4289-41fb-9e15-0ccc77dd39b1", "2f9d0937-c7d6-4488-8939-3420229b06fc", "Hulpverlener", "HULPVERLENER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c6a03ab4-0961-468e-9412-038c6c9f8637", "a021ea4d-d3ce-4afa-911e-4ee78fbeb63b", "Patient", "PATIENT" });
        }
    }
}
