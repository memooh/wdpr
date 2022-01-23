using Microsoft.EntityFrameworkCore.Migrations;

namespace wdpr.Migrations
{
    public partial class objecteditz : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chats_Zelfhulpgroepen_ZelfhulpgroepInt",
                table: "Chats");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d0ea45b-7b11-447c-b255-0362c2b59736");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8fc33049-5883-4f35-988a-2496d1340fd4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "98eb824f-46c3-4962-8da4-cd23b4375df0", "a891b558-ff33-4ea8-a8d2-5e9e65727234", "Voogd", "Voogd" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e5148088-058c-4440-8e05-51f5590d8996", "3be0c8c2-3bf8-4b6c-aebd-136304c4ae26", "Client", "Client" });

            migrationBuilder.AddForeignKey(
                name: "FK_Chats_Zelfhulpgroepen_ZelfhulpgroepInt",
                table: "Chats",
                column: "ZelfhulpgroepInt",
                principalTable: "Zelfhulpgroepen",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chats_Zelfhulpgroepen_ZelfhulpgroepInt",
                table: "Chats");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "98eb824f-46c3-4962-8da4-cd23b4375df0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5148088-058c-4440-8e05-51f5590d8996");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3d0ea45b-7b11-447c-b255-0362c2b59736", "fa2b17b4-6700-42ed-b784-2b4af5defc6e", "Voogd", "Voogd" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8fc33049-5883-4f35-988a-2496d1340fd4", "4d22bc64-f9e8-44a2-be78-723b2cf051ae", "Client", "Client" });

            migrationBuilder.AddForeignKey(
                name: "FK_Chats_Zelfhulpgroepen_ZelfhulpgroepInt",
                table: "Chats",
                column: "ZelfhulpgroepInt",
                principalTable: "Zelfhulpgroepen",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
