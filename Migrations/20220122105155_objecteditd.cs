using Microsoft.EntityFrameworkCore.Migrations;

namespace wdpr.Migrations
{
    public partial class objecteditd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4fec9476-cff7-48c7-ab59-b2d5b1c229a7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a3380014-feba-4bf1-8248-6092e33e1d01");

            migrationBuilder.RenameColumn(
                name: "Actief",
                table: "Deelnames",
                newName: "Geblokkeerd");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7dd5d6d6-21e0-4a9e-b375-e15570af77b3", "3af50a51-f39c-4f08-ae93-0f31a4a033d5", "Voogd", "Voogd" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dc565951-c101-429c-9595-77c28c406701", "79085c40-1294-4ea3-9bca-a4a6e1a225d4", "Client", "Client" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7dd5d6d6-21e0-4a9e-b375-e15570af77b3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc565951-c101-429c-9595-77c28c406701");

            migrationBuilder.RenameColumn(
                name: "Geblokkeerd",
                table: "Deelnames",
                newName: "Actief");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4fec9476-cff7-48c7-ab59-b2d5b1c229a7", "8a4a0f8c-44cd-48f4-962f-648f3ccbd6ce", "Voogd", "Voogd" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a3380014-feba-4bf1-8248-6092e33e1d01", "e72aaf82-ef40-4d4e-9798-a53984a62fac", "Client", "Client" });
        }
    }
}
