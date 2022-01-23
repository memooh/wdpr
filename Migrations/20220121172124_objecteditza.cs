using Microsoft.EntityFrameworkCore.Migrations;

namespace wdpr.Migrations
{
    public partial class objecteditza : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Berichten_AspNetUsers_VerzenderId",
                table: "Berichten");

            migrationBuilder.DropIndex(
                name: "IX_Berichten_VerzenderId",
                table: "Berichten");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "98eb824f-46c3-4962-8da4-cd23b4375df0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5148088-058c-4440-8e05-51f5590d8996");

            migrationBuilder.DropColumn(
                name: "VerzenderId",
                table: "Berichten");

            migrationBuilder.AddColumn<int>(
                name: "DeelnameId",
                table: "Berichten",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f17d27bf-f942-44e5-86ce-99836411053d", "be3ac8ef-763d-4a81-b09d-774300501d57", "Voogd", "Voogd" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ec5762c5-27fb-4f7d-9521-738efd7d20c6", "5ae89a56-9de1-461e-b78f-123e620cc61d", "Client", "Client" });

            migrationBuilder.CreateIndex(
                name: "IX_Berichten_DeelnameId",
                table: "Berichten",
                column: "DeelnameId");

            migrationBuilder.AddForeignKey(
                name: "FK_Berichten_Deelnames_DeelnameId",
                table: "Berichten",
                column: "DeelnameId",
                principalTable: "Deelnames",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Berichten_Deelnames_DeelnameId",
                table: "Berichten");

            migrationBuilder.DropIndex(
                name: "IX_Berichten_DeelnameId",
                table: "Berichten");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec5762c5-27fb-4f7d-9521-738efd7d20c6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f17d27bf-f942-44e5-86ce-99836411053d");

            migrationBuilder.DropColumn(
                name: "DeelnameId",
                table: "Berichten");

            migrationBuilder.AddColumn<string>(
                name: "VerzenderId",
                table: "Berichten",
                type: "TEXT",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "98eb824f-46c3-4962-8da4-cd23b4375df0", "a891b558-ff33-4ea8-a8d2-5e9e65727234", "Voogd", "Voogd" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e5148088-058c-4440-8e05-51f5590d8996", "3be0c8c2-3bf8-4b6c-aebd-136304c4ae26", "Client", "Client" });

            migrationBuilder.CreateIndex(
                name: "IX_Berichten_VerzenderId",
                table: "Berichten",
                column: "VerzenderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Berichten_AspNetUsers_VerzenderId",
                table: "Berichten",
                column: "VerzenderId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
