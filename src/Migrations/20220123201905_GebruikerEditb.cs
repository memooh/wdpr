using Microsoft.EntityFrameworkCore.Migrations;

namespace wdpr.Migrations
{
    public partial class GebruikerEditb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: "4a0eff05-e6e1-4114-a73e-04862911246b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5683c156-223f-4680-976e-ec2fcf386ac8");

            migrationBuilder.DropColumn(
                name: "BehandelaarId1",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "VoogdId1",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e006ee41-1a4d-45bf-a0e0-c85d5a3a5d28", "9c56f281-7f5b-4bb8-8ee9-2bfec8b123fe", "Voogd", "Voogd" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d7440d68-8fee-469a-9a7d-3c06aaa92fa1", "41a5516b-5a65-4ce4-a3c0-919ab1c8363a", "Client", "Client" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d7440d68-8fee-469a-9a7d-3c06aaa92fa1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e006ee41-1a4d-45bf-a0e0-c85d5a3a5d28");

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
                values: new object[] { "4a0eff05-e6e1-4114-a73e-04862911246b", "9642b045-f370-4b27-82a7-011a43972085", "Voogd", "Voogd" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5683c156-223f-4680-976e-ec2fcf386ac8", "a3c7f7f2-cc03-4713-8902-4c1ca3cc49ae", "Client", "Client" });

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
    }
}
