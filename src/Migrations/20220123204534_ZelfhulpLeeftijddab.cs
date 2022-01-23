using Microsoft.EntityFrameworkCore.Migrations;

namespace wdpr.Migrations
{
    public partial class ZelfhulpLeeftijddab : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "917a106e-00ea-470c-bb42-85490f5d4638");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f326e059-a827-404a-b10f-76f5e0db1add");

            migrationBuilder.AddColumn<string>(
                name: "VoogdId",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2b24b91d-6dec-42c5-b293-5e8c5ee6392d", "0878ba3e-41b5-4af5-bcfb-841350fb48f7", "Voogd", "Voogd" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "68aa1902-b7d8-4a0a-a178-26581e59a806", "562cdcb5-5bb3-4c0b-9b5e-a9bd0eaf3795", "Client", "Client" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_VoogdId",
                table: "AspNetUsers",
                column: "VoogdId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_VoogdId",
                table: "AspNetUsers",
                column: "VoogdId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_VoogdId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_VoogdId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b24b91d-6dec-42c5-b293-5e8c5ee6392d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "68aa1902-b7d8-4a0a-a178-26581e59a806");

            migrationBuilder.DropColumn(
                name: "VoogdId",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "917a106e-00ea-470c-bb42-85490f5d4638", "2ac996fa-a962-45ad-9552-09db65e21e62", "Voogd", "Voogd" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f326e059-a827-404a-b10f-76f5e0db1add", "6388d28e-3bad-43de-bccd-d8264a704d7c", "Client", "Client" });
        }
    }
}
