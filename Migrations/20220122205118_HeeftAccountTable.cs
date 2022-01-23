using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace wdpr.Migrations
{
    public partial class HeeftAccountTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Afspraken_Behandelingen__BehandelingId",
                table: "Afspraken");

            migrationBuilder.DropForeignKey(
                name: "FK_Berichten_Gebruikers_VerzenderId",
                table: "Berichten");

            migrationBuilder.RenameColumn(
                name: "Wachtwoord",
                table: "Gebruikers",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "Gebruikersnaam",
                table: "Gebruikers",
                newName: "SecurityStamp");

            migrationBuilder.RenameColumn(
                name: "VerzenderId",
                table: "Berichten",
                newName: "DeelnameId");

            migrationBuilder.RenameIndex(
                name: "IX_Berichten_VerzenderId",
                table: "Berichten",
                newName: "IX_Berichten_DeelnameId");

            migrationBuilder.RenameColumn(
                name: "_BehandelingId",
                table: "Afspraken",
                newName: "BehandelingId");

            migrationBuilder.RenameIndex(
                name: "IX_Afspraken__BehandelingId",
                table: "Afspraken",
                newName: "IX_Afspraken_BehandelingId");

            migrationBuilder.AlterColumn<string>(
                name: "ClientId",
                table: "ZelfhulpDeelnames",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "VoogdId",
                table: "Gebruikers",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Gebruikers",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "Gebruikers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Gebruikers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "Gebruikers",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "Gebruikers",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "Gebruikers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "Gebruikers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "Gebruikers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Gebruikers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Gebruikers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "Gebruikers",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "Gebruikers",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "ClientId",
                table: "Deelnames",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Geblokkeerd",
                table: "Deelnames",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "BehandelaarId",
                table: "Chats",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Actief",
                table: "Chats",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ZelfhulpgroepInt",
                table: "Chats",
                type: "INTEGER",
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

            migrationBuilder.AddColumn<bool>(
                name: "HeeftAccount",
                table: "Aanmeldingen",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "VoogdId",
                table: "Aanmeldingen",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Behandeld",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BehandelingId = table.Column<int>(type: "INTEGER", nullable: true),
                    BehandelaarId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Behandeld", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Behandeld_Behandelingen_BehandelingId",
                        column: x => x.BehandelingId,
                        principalTable: "Behandelingen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Behandeld_Gebruikers_BehandelaarId",
                        column: x => x.BehandelaarId,
                        principalTable: "Gebruikers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Melding",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Beschrijving = table.Column<string>(type: "TEXT", nullable: true),
                    Datum = table.Column<DateTime>(type: "TEXT", nullable: false),
                    BerichtId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Melding", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Melding_Berichten_BerichtId",
                        column: x => x.BerichtId,
                        principalTable: "Berichten",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chats_ZelfhulpgroepInt",
                table: "Chats",
                column: "ZelfhulpgroepInt",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Aanmeldingen_VoogdId",
                table: "Aanmeldingen",
                column: "VoogdId");

            migrationBuilder.CreateIndex(
                name: "IX_Behandeld_BehandelaarId",
                table: "Behandeld",
                column: "BehandelaarId");

            migrationBuilder.CreateIndex(
                name: "IX_Behandeld_BehandelingId",
                table: "Behandeld",
                column: "BehandelingId");

            migrationBuilder.CreateIndex(
                name: "IX_Melding_BerichtId",
                table: "Melding",
                column: "BerichtId");

            migrationBuilder.AddForeignKey(
                name: "FK_Aanmeldingen_Gebruikers_VoogdId",
                table: "Aanmeldingen",
                column: "VoogdId",
                principalTable: "Gebruikers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Afspraken_Behandelingen_BehandelingId",
                table: "Afspraken",
                column: "BehandelingId",
                principalTable: "Behandelingen",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Berichten_Deelnames_DeelnameId",
                table: "Berichten",
                column: "DeelnameId",
                principalTable: "Deelnames",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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
                name: "FK_Aanmeldingen_Gebruikers_VoogdId",
                table: "Aanmeldingen");

            migrationBuilder.DropForeignKey(
                name: "FK_Afspraken_Behandelingen_BehandelingId",
                table: "Afspraken");

            migrationBuilder.DropForeignKey(
                name: "FK_Berichten_Deelnames_DeelnameId",
                table: "Berichten");

            migrationBuilder.DropForeignKey(
                name: "FK_Chats_Zelfhulpgroepen_ZelfhulpgroepInt",
                table: "Chats");

            migrationBuilder.DropTable(
                name: "Behandeld");

            migrationBuilder.DropTable(
                name: "Melding");

            migrationBuilder.DropIndex(
                name: "IX_Chats_ZelfhulpgroepInt",
                table: "Chats");

            migrationBuilder.DropIndex(
                name: "IX_Aanmeldingen_VoogdId",
                table: "Aanmeldingen");

            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "Gebruikers");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Gebruikers");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "Gebruikers");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "Gebruikers");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "Gebruikers");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "Gebruikers");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "Gebruikers");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Gebruikers");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Gebruikers");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "Gebruikers");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "Gebruikers");

            migrationBuilder.DropColumn(
                name: "Geblokkeerd",
                table: "Deelnames");

            migrationBuilder.DropColumn(
                name: "Actief",
                table: "Chats");

            migrationBuilder.DropColumn(
                name: "ZelfhulpgroepInt",
                table: "Chats");

            migrationBuilder.DropColumn(
                name: "HeeftAccount",
                table: "Aanmeldingen");

            migrationBuilder.DropColumn(
                name: "VoogdId",
                table: "Aanmeldingen");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Gebruikers",
                newName: "Wachtwoord");

            migrationBuilder.RenameColumn(
                name: "SecurityStamp",
                table: "Gebruikers",
                newName: "Gebruikersnaam");

            migrationBuilder.RenameColumn(
                name: "DeelnameId",
                table: "Berichten",
                newName: "VerzenderId");

            migrationBuilder.RenameIndex(
                name: "IX_Berichten_DeelnameId",
                table: "Berichten",
                newName: "IX_Berichten_VerzenderId");

            migrationBuilder.RenameColumn(
                name: "BehandelingId",
                table: "Afspraken",
                newName: "_BehandelingId");

            migrationBuilder.RenameIndex(
                name: "IX_Afspraken_BehandelingId",
                table: "Afspraken",
                newName: "IX_Afspraken__BehandelingId");

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "ZelfhulpDeelnames",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "VoogdId",
                table: "Gebruikers",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Gebruikers",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT")
                .Annotation("Sqlite:Autoincrement", true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Afspraken_Behandelingen__BehandelingId",
                table: "Afspraken",
                column: "_BehandelingId",
                principalTable: "Behandelingen",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Berichten_Gebruikers_VerzenderId",
                table: "Berichten",
                column: "VerzenderId",
                principalTable: "Gebruikers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
