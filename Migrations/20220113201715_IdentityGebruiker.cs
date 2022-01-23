using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace wdpr.Migrations
{
    public partial class IdentityGebruiker : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aanmeldingen_Gebruikers_BehandelaarId",
                table: "Aanmeldingen");

            migrationBuilder.DropForeignKey(
                name: "FK_Afspraken_Gebruikers_BehandelaarId",
                table: "Afspraken");

            migrationBuilder.DropForeignKey(
                name: "FK_Afspraken_Gebruikers_ClientId",
                table: "Afspraken");

            migrationBuilder.DropForeignKey(
                name: "FK_Berichten_Gebruikers_VerzenderId",
                table: "Berichten");

            migrationBuilder.DropForeignKey(
                name: "FK_Chats_Gebruikers_BehandelaarId",
                table: "Chats");

            migrationBuilder.DropForeignKey(
                name: "FK_Deelnames_Gebruikers_ClientId",
                table: "Deelnames");

            migrationBuilder.DropForeignKey(
                name: "FK_ZelfhulpDeelnames_Gebruikers_ClientId",
                table: "ZelfhulpDeelnames");

            migrationBuilder.DropTable(
                name: "Gebruikers");

            migrationBuilder.AlterColumn<string>(
                name: "ClientId",
                table: "ZelfhulpDeelnames",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClientId",
                table: "Deelnames",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BehandelaarId",
                table: "Chats",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "VerzenderId",
                table: "Berichten",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Geboortedatum",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VoogdId",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClientId",
                table: "Afspraken",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BehandelaarId",
                table: "Afspraken",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BehandelaarId",
                table: "Aanmeldingen",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_VoogdId",
                table: "AspNetUsers",
                column: "VoogdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Aanmeldingen_AspNetUsers_BehandelaarId",
                table: "Aanmeldingen",
                column: "BehandelaarId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Afspraken_AspNetUsers_BehandelaarId",
                table: "Afspraken",
                column: "BehandelaarId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Afspraken_AspNetUsers_ClientId",
                table: "Afspraken",
                column: "ClientId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_VoogdId",
                table: "AspNetUsers",
                column: "VoogdId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Berichten_AspNetUsers_VerzenderId",
                table: "Berichten",
                column: "VerzenderId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Chats_AspNetUsers_BehandelaarId",
                table: "Chats",
                column: "BehandelaarId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Deelnames_AspNetUsers_ClientId",
                table: "Deelnames",
                column: "ClientId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ZelfhulpDeelnames_AspNetUsers_ClientId",
                table: "ZelfhulpDeelnames",
                column: "ClientId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aanmeldingen_AspNetUsers_BehandelaarId",
                table: "Aanmeldingen");

            migrationBuilder.DropForeignKey(
                name: "FK_Afspraken_AspNetUsers_BehandelaarId",
                table: "Afspraken");

            migrationBuilder.DropForeignKey(
                name: "FK_Afspraken_AspNetUsers_ClientId",
                table: "Afspraken");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_VoogdId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Berichten_AspNetUsers_VerzenderId",
                table: "Berichten");

            migrationBuilder.DropForeignKey(
                name: "FK_Chats_AspNetUsers_BehandelaarId",
                table: "Chats");

            migrationBuilder.DropForeignKey(
                name: "FK_Deelnames_AspNetUsers_ClientId",
                table: "Deelnames");

            migrationBuilder.DropForeignKey(
                name: "FK_ZelfhulpDeelnames_AspNetUsers_ClientId",
                table: "ZelfhulpDeelnames");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_VoogdId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Geboortedatum",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "VoogdId",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "ZelfhulpDeelnames",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "Deelnames",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BehandelaarId",
                table: "Chats",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "VerzenderId",
                table: "Berichten",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "Afspraken",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BehandelaarId",
                table: "Afspraken",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BehandelaarId",
                table: "Aanmeldingen",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Gebruikers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Geboortedatum = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Gebruikersnaam = table.Column<string>(type: "TEXT", nullable: true),
                    VoogdId = table.Column<int>(type: "INTEGER", nullable: true),
                    Wachtwoord = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gebruikers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gebruikers_Gebruikers_VoogdId",
                        column: x => x.VoogdId,
                        principalTable: "Gebruikers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Gebruikers_VoogdId",
                table: "Gebruikers",
                column: "VoogdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Aanmeldingen_Gebruikers_BehandelaarId",
                table: "Aanmeldingen",
                column: "BehandelaarId",
                principalTable: "Gebruikers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Afspraken_Gebruikers_BehandelaarId",
                table: "Afspraken",
                column: "BehandelaarId",
                principalTable: "Gebruikers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Afspraken_Gebruikers_ClientId",
                table: "Afspraken",
                column: "ClientId",
                principalTable: "Gebruikers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Berichten_Gebruikers_VerzenderId",
                table: "Berichten",
                column: "VerzenderId",
                principalTable: "Gebruikers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Chats_Gebruikers_BehandelaarId",
                table: "Chats",
                column: "BehandelaarId",
                principalTable: "Gebruikers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Deelnames_Gebruikers_ClientId",
                table: "Deelnames",
                column: "ClientId",
                principalTable: "Gebruikers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ZelfhulpDeelnames_Gebruikers_ClientId",
                table: "ZelfhulpDeelnames",
                column: "ClientId",
                principalTable: "Gebruikers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
