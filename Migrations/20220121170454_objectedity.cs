using Microsoft.EntityFrameworkCore.Migrations;

namespace wdpr.Migrations
{
    public partial class objectedity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chats_Zelfhulpgroepen_ZelfhulpgroepId",
                table: "Chats");

            migrationBuilder.DropIndex(
                name: "IX_Chats_ZelfhulpgroepId",
                table: "Chats");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "87e80e0f-b2b3-4721-b504-1ccce6d82621");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed86c7db-cca1-49bf-97f2-aa7b5d89b7ee");

            migrationBuilder.DropColumn(
                name: "ZelfhulpgroepId",
                table: "Chats");

            migrationBuilder.AddColumn<int>(
                name: "ZelfhulpgroepInt",
                table: "Chats",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3d0ea45b-7b11-447c-b255-0362c2b59736", "fa2b17b4-6700-42ed-b784-2b4af5defc6e", "Voogd", "Voogd" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8fc33049-5883-4f35-988a-2496d1340fd4", "4d22bc64-f9e8-44a2-be78-723b2cf051ae", "Client", "Client" });

            migrationBuilder.CreateIndex(
                name: "IX_Chats_ZelfhulpgroepInt",
                table: "Chats",
                column: "ZelfhulpgroepInt",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Chats_Zelfhulpgroepen_ZelfhulpgroepInt",
                table: "Chats",
                column: "ZelfhulpgroepInt",
                principalTable: "Zelfhulpgroepen",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chats_Zelfhulpgroepen_ZelfhulpgroepInt",
                table: "Chats");

            migrationBuilder.DropIndex(
                name: "IX_Chats_ZelfhulpgroepInt",
                table: "Chats");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d0ea45b-7b11-447c-b255-0362c2b59736");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8fc33049-5883-4f35-988a-2496d1340fd4");

            migrationBuilder.DropColumn(
                name: "ZelfhulpgroepInt",
                table: "Chats");

            migrationBuilder.AddColumn<int>(
                name: "ZelfhulpgroepId",
                table: "Chats",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "87e80e0f-b2b3-4721-b504-1ccce6d82621", "82dbc071-7d77-4dc8-98e2-7c9b33171963", "Voogd", "Voogd" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ed86c7db-cca1-49bf-97f2-aa7b5d89b7ee", "0fa5ca01-e87f-474b-8b75-90abb4c1ef59", "Client", "Client" });

            migrationBuilder.CreateIndex(
                name: "IX_Chats_ZelfhulpgroepId",
                table: "Chats",
                column: "ZelfhulpgroepId");

            migrationBuilder.AddForeignKey(
                name: "FK_Chats_Zelfhulpgroepen_ZelfhulpgroepId",
                table: "Chats",
                column: "ZelfhulpgroepId",
                principalTable: "Zelfhulpgroepen",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
