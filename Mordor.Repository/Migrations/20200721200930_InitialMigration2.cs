using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mordor.Repository.Migrations
{
    public partial class InitialMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Horda",
                table: "Horda");

            migrationBuilder.RenameTable(
                name: "Horda",
                newName: "HordaTable");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastFight",
                table: "HordaTable",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "HordaTable",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HordaTable",
                table: "HordaTable",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_HordaTable_Name",
                table: "HordaTable",
                column: "Name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_HordaTable",
                table: "HordaTable");

            migrationBuilder.DropIndex(
                name: "IX_HordaTable_Name",
                table: "HordaTable");

            migrationBuilder.DropColumn(
                name: "LastFight",
                table: "HordaTable");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "HordaTable");

            migrationBuilder.RenameTable(
                name: "HordaTable",
                newName: "Horda");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Horda",
                table: "Horda",
                column: "ID");
        }
    }
}
