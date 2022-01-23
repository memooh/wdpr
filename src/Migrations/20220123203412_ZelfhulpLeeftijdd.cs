using Microsoft.EntityFrameworkCore.Migrations;

namespace wdpr.Migrations
{
    public partial class ZelfhulpLeeftijdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "765e16da-605a-4bf2-93da-0faf400b7c4c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9cd7f083-4ea9-477a-b2f0-4f379737a703");

            migrationBuilder.AddColumn<int>(
                name: "BehandelaarId1",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VoogdId1",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5d10db17-cd26-4814-8f32-9c58038d3453", "6b29d6d5-03cb-40b7-aa65-350b455effad", "Voogd", "Voogd" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d3184c61-be5e-41a8-bdf9-62e85132c75a", "60968fd4-4b38-49fc-a5cf-587f007ff805", "Client", "Client" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_BehandelaarId1",
                table: "AspNetUsers",
                column: "BehandelaarId1");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_VoogdId1",
                table: "AspNetUsers",
                column: "VoogdId1");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_BehandelaarId1",
                table: "AspNetUsers",
                column: "BehandelaarId1",
                principalTable: "AspNetUsers",
                principalColumn: "BehandelaarId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_VoogdId1",
                table: "AspNetUsers",
                column: "VoogdId1",
                principalTable: "AspNetUsers",
                principalColumn: "VoogdId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_BehandelaarId1",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_VoogdId1",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_BehandelaarId1",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_VoogdId1",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d10db17-cd26-4814-8f32-9c58038d3453");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3184c61-be5e-41a8-bdf9-62e85132c75a");

            migrationBuilder.DropColumn(
                name: "BehandelaarId1",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "VoogdId1",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9cd7f083-4ea9-477a-b2f0-4f379737a703", "498259f6-2e5a-4baf-a062-046cc312cbc8", "Voogd", "Voogd" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "765e16da-605a-4bf2-93da-0faf400b7c4c", "aed63ad1-9376-4fc2-9e30-fff80896a0ff", "Client", "Client" });
        }
    }
}
