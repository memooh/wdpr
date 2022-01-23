using Microsoft.EntityFrameworkCore.Migrations;

namespace wdpr.Migrations
{
    public partial class objecteditzb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec5762c5-27fb-4f7d-9521-738efd7d20c6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f17d27bf-f942-44e5-86ce-99836411053d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fb64d628-3f76-4247-9590-ae25e375a604", "508bb308-4b3c-4c9d-ad3c-1a0ace8bae71", "Voogd", "Voogd" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "af552aec-3f75-4218-92b5-7c17b33138b9", "c7a7a644-b9d1-4782-b2b8-73a03dbd0c64", "Client", "Client" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "af552aec-3f75-4218-92b5-7c17b33138b9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb64d628-3f76-4247-9590-ae25e375a604");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f17d27bf-f942-44e5-86ce-99836411053d", "be3ac8ef-763d-4a81-b09d-774300501d57", "Voogd", "Voogd" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ec5762c5-27fb-4f7d-9521-738efd7d20c6", "5ae89a56-9de1-461e-b78f-123e620cc61d", "Client", "Client" });
        }
    }
}
