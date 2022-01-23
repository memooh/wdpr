using Microsoft.EntityFrameworkCore.Migrations;

namespace wdpr.Migrations
{
    public partial class objecteditc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "af552aec-3f75-4218-92b5-7c17b33138b9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb64d628-3f76-4247-9590-ae25e375a604");

            migrationBuilder.AlterColumn<int>(
                name: "ZelfhulpgroepInt",
                table: "Chats",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4fec9476-cff7-48c7-ab59-b2d5b1c229a7", "8a4a0f8c-44cd-48f4-962f-648f3ccbd6ce", "Voogd", "Voogd" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a3380014-feba-4bf1-8248-6092e33e1d01", "e72aaf82-ef40-4d4e-9798-a53984a62fac", "Client", "Client" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4fec9476-cff7-48c7-ab59-b2d5b1c229a7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a3380014-feba-4bf1-8248-6092e33e1d01");

            migrationBuilder.AlterColumn<int>(
                name: "ZelfhulpgroepInt",
                table: "Chats",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fb64d628-3f76-4247-9590-ae25e375a604", "508bb308-4b3c-4c9d-ad3c-1a0ace8bae71", "Voogd", "Voogd" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "af552aec-3f75-4218-92b5-7c17b33138b9", "c7a7a644-b9d1-4782-b2b8-73a03dbd0c64", "Client", "Client" });
        }
    }
}
