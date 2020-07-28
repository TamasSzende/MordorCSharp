using Microsoft.EntityFrameworkCore.Migrations;

namespace Mordor.Repository.Migrations
{
    public partial class MigrationLatest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HordaID",
                table: "OrkTable",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrkTable_HordaID",
                table: "OrkTable",
                column: "HordaID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrkTable_HordaTable_HordaID",
                table: "OrkTable",
                column: "HordaID",
                principalTable: "HordaTable",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrkTable_HordaTable_HordaID",
                table: "OrkTable");

            migrationBuilder.DropIndex(
                name: "IX_OrkTable_HordaID",
                table: "OrkTable");

            migrationBuilder.DropColumn(
                name: "HordaID",
                table: "OrkTable");
        }
    }
}
