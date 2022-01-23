using Microsoft.EntityFrameworkCore.Migrations;

namespace wdpr.Migrations
{
    public partial class GebruikerEdita : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_GebruikerVoogdId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_VoogdId1",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_GebruikerVoogdId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c25642d7-c506-4f2b-86a8-6a30c38cd8a0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e272c18a-d4d8-44d3-8e8d-9432e308e7d5");

            migrationBuilder.DropColumn(
                name: "GebruikerVoogdId",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "VoogdId1",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4a0eff05-e6e1-4114-a73e-04862911246b", "9642b045-f370-4b27-82a7-011a43972085", "Voogd", "Voogd" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5683c156-223f-4680-976e-ec2fcf386ac8", "a3c7f7f2-cc03-4713-8902-4c1ca3cc49ae", "Client", "Client" });

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
                name: "FK_AspNetUsers_AspNetUsers_VoogdId1",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a0eff05-e6e1-4114-a73e-04862911246b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5683c156-223f-4680-976e-ec2fcf386ac8");

            migrationBuilder.AlterColumn<string>(
                name: "VoogdId1",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GebruikerVoogdId",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c25642d7-c506-4f2b-86a8-6a30c38cd8a0", "cc26aaa2-8a31-46b3-b036-facc2d7ac678", "Voogd", "Voogd" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e272c18a-d4d8-44d3-8e8d-9432e308e7d5", "8fcaff1d-20c2-4831-a024-1c9d854f74e9", "Client", "Client" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_GebruikerVoogdId",
                table: "AspNetUsers",
                column: "GebruikerVoogdId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_GebruikerVoogdId",
                table: "AspNetUsers",
                column: "GebruikerVoogdId",
                principalTable: "AspNetUsers",
                principalColumn: "VoogdId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_VoogdId1",
                table: "AspNetUsers",
                column: "VoogdId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
