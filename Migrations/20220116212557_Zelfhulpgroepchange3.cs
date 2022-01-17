using Microsoft.EntityFrameworkCore.Migrations;

namespace wdpr.Migrations
{
    public partial class Zelfhulpgroepchange3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: "21f3d531-268c-4973-9c0c-690cf493b95d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c90947b3-36e8-425c-81f5-5c4aa35a0f8e");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "c90947b3-36e8-425c-81f5-5c4aa35a0f8e", "feb69325-624e-41e8-ab0d-964e781b382c", "Hulpverlener", "HULPVERLENER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "21f3d531-268c-4973-9c0c-690cf493b95d", "55384ab9-d710-439e-85cc-4426a5c0d62b", "Patient", "PATIENT" });

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
    }
}
