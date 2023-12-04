using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BowlThemUp.Data.Migrations
{
    public partial class test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MyProperty",
                table: "Player",
                newName: "PlayerAge");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PlayerAge",
                table: "Player",
                newName: "MyProperty");
        }
    }
}
