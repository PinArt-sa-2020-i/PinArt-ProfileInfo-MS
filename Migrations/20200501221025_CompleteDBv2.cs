using Microsoft.EntityFrameworkCore.Migrations;

namespace PinArt_ProfileInfo_MS.Migrations
{
    public partial class CompleteDBv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "firstName",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "lastName",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "username",
                table: "Users",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "firstName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "lastName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "username",
                table: "Users");
        }
    }
}
