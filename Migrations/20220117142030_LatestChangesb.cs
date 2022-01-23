using Microsoft.EntityFrameworkCore.Migrations;

namespace wdpr.Migrations
{
    public partial class LatestChangesb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Berichten_Meldingen_MeldingId",
                table: "Berichten");

            migrationBuilder.DropIndex(
                name: "IX_Berichten_MeldingId",
                table: "Berichten");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac497774-c649-4ec9-b463-756405b7ab9b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5029d62-c822-4afc-b64f-cd26fb055acc");

            migrationBuilder.DropColumn(
                name: "MeldingId",
                table: "Berichten");

            migrationBuilder.AddColumn<int>(
                name: "BerichtId",
                table: "Meldingen",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "768f06ad-1152-4837-9080-dd1f2b0fdf38", "26057391-3354-4c49-bd99-c6f896d3aa72", "Voogd", "Voogd" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "72fb7f3a-fd21-4314-a8c0-dcfddc2444aa", "0a7c1cba-91ae-40ca-9b80-6e8bd1d9d9ca", "Client", "Client" });

            migrationBuilder.CreateIndex(
                name: "IX_Meldingen_BerichtId",
                table: "Meldingen",
                column: "BerichtId");

            migrationBuilder.AddForeignKey(
                name: "FK_Meldingen_Berichten_BerichtId",
                table: "Meldingen",
                column: "BerichtId",
                principalTable: "Berichten",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meldingen_Berichten_BerichtId",
                table: "Meldingen");

            migrationBuilder.DropIndex(
                name: "IX_Meldingen_BerichtId",
                table: "Meldingen");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "72fb7f3a-fd21-4314-a8c0-dcfddc2444aa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "768f06ad-1152-4837-9080-dd1f2b0fdf38");

            migrationBuilder.DropColumn(
                name: "BerichtId",
                table: "Meldingen");

            migrationBuilder.AddColumn<int>(
                name: "MeldingId",
                table: "Berichten",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ac497774-c649-4ec9-b463-756405b7ab9b", "4a13c480-4d6f-4cda-acc3-d2054afb8673", "Voogd", "Voogd" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c5029d62-c822-4afc-b64f-cd26fb055acc", "facf9ce2-dd3c-4019-a3f2-20a74e7d2b90", "Client", "Client" });

            migrationBuilder.CreateIndex(
                name: "IX_Berichten_MeldingId",
                table: "Berichten",
                column: "MeldingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Berichten_Meldingen_MeldingId",
                table: "Berichten",
                column: "MeldingId",
                principalTable: "Meldingen",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
