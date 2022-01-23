using Microsoft.EntityFrameworkCore.Migrations;

namespace wdpr.Migrations
{
    public partial class ZelfhulpLeeftijddaa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_BehandelaarId1",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_VoogdId1",
                table: "AspNetUsers");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_AspNetUsers_BehandelaarId",
                table: "AspNetUsers");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_AspNetUsers_VoogdId",
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
                name: "VoogdId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "VoogdId1",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "BehandelaarId",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "917a106e-00ea-470c-bb42-85490f5d4638", "2ac996fa-a962-45ad-9552-09db65e21e62", "Voogd", "Voogd" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f326e059-a827-404a-b10f-76f5e0db1add", "6388d28e-3bad-43de-bccd-d8264a704d7c", "Client", "Client" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_BehandelaarId",
                table: "AspNetUsers",
                column: "BehandelaarId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_BehandelaarId",
                table: "AspNetUsers",
                column: "BehandelaarId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_BehandelaarId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_BehandelaarId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "917a106e-00ea-470c-bb42-85490f5d4638");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f326e059-a827-404a-b10f-76f5e0db1add");

            migrationBuilder.AlterColumn<int>(
                name: "BehandelaarId",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BehandelaarId1",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VoogdId",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VoogdId1",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_AspNetUsers_BehandelaarId",
                table: "AspNetUsers",
                column: "BehandelaarId");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_AspNetUsers_VoogdId",
                table: "AspNetUsers",
                column: "VoogdId");

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
    }
}
