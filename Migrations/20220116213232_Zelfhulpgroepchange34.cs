using Microsoft.EntityFrameworkCore.Migrations;

namespace wdpr.Migrations
{
    public partial class Zelfhulpgroepchange34 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_ZelfhulpDeelnames_ZelfhulpDeelnameId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Zelfhulpgroepen_ZelfhulpDeelnames_ZelfhulpDeelnameId",
                table: "Zelfhulpgroepen");

            migrationBuilder.DropIndex(
                name: "IX_Zelfhulpgroepen_ZelfhulpDeelnameId",
                table: "Zelfhulpgroepen");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ZelfhulpDeelnameId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "051172f9-55b8-4e2b-b629-0f2a3a05a126");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e6f1fd89-286f-45f6-8466-cb12f503e3c8");

            migrationBuilder.DropColumn(
                name: "ZelfhulpDeelnameId",
                table: "Zelfhulpgroepen");

            migrationBuilder.DropColumn(
                name: "ZelfhulpDeelnameId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "ClientId",
                table: "ZelfhulpDeelnames",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ZelfhulpgroepId",
                table: "ZelfhulpDeelnames",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fada2d14-60df-461f-b738-694ed9cd9126", "94a62104-7560-42b6-9c0e-f5de1d0c4daf", "Hulpverlener", "HULPVERLENER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6eb41b7f-f540-4cc6-8091-d6b77c2c3580", "b23dcfba-8d1b-444b-969a-eda17215b396", "Patient", "PATIENT" });

            migrationBuilder.CreateIndex(
                name: "IX_ZelfhulpDeelnames_ClientId",
                table: "ZelfhulpDeelnames",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_ZelfhulpDeelnames_ZelfhulpgroepId",
                table: "ZelfhulpDeelnames",
                column: "ZelfhulpgroepId");

            migrationBuilder.AddForeignKey(
                name: "FK_ZelfhulpDeelnames_AspNetUsers_ClientId",
                table: "ZelfhulpDeelnames",
                column: "ClientId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ZelfhulpDeelnames_Zelfhulpgroepen_ZelfhulpgroepId",
                table: "ZelfhulpDeelnames",
                column: "ZelfhulpgroepId",
                principalTable: "Zelfhulpgroepen",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ZelfhulpDeelnames_AspNetUsers_ClientId",
                table: "ZelfhulpDeelnames");

            migrationBuilder.DropForeignKey(
                name: "FK_ZelfhulpDeelnames_Zelfhulpgroepen_ZelfhulpgroepId",
                table: "ZelfhulpDeelnames");

            migrationBuilder.DropIndex(
                name: "IX_ZelfhulpDeelnames_ClientId",
                table: "ZelfhulpDeelnames");

            migrationBuilder.DropIndex(
                name: "IX_ZelfhulpDeelnames_ZelfhulpgroepId",
                table: "ZelfhulpDeelnames");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6eb41b7f-f540-4cc6-8091-d6b77c2c3580");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fada2d14-60df-461f-b738-694ed9cd9126");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "ZelfhulpDeelnames");

            migrationBuilder.DropColumn(
                name: "ZelfhulpgroepId",
                table: "ZelfhulpDeelnames");

            migrationBuilder.AddColumn<int>(
                name: "ZelfhulpDeelnameId",
                table: "Zelfhulpgroepen",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ZelfhulpDeelnameId",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e6f1fd89-286f-45f6-8466-cb12f503e3c8", "5281a345-5e4c-4e69-9daf-5260c5531668", "Hulpverlener", "HULPVERLENER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "051172f9-55b8-4e2b-b629-0f2a3a05a126", "15bdfe50-a594-4dfc-abd7-48339187a1ca", "Patient", "PATIENT" });

            migrationBuilder.CreateIndex(
                name: "IX_Zelfhulpgroepen_ZelfhulpDeelnameId",
                table: "Zelfhulpgroepen",
                column: "ZelfhulpDeelnameId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ZelfhulpDeelnameId",
                table: "AspNetUsers",
                column: "ZelfhulpDeelnameId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_ZelfhulpDeelnames_ZelfhulpDeelnameId",
                table: "AspNetUsers",
                column: "ZelfhulpDeelnameId",
                principalTable: "ZelfhulpDeelnames",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Zelfhulpgroepen_ZelfhulpDeelnames_ZelfhulpDeelnameId",
                table: "Zelfhulpgroepen",
                column: "ZelfhulpDeelnameId",
                principalTable: "ZelfhulpDeelnames",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
