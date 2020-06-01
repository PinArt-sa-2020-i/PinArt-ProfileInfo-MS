using Microsoft.EntityFrameworkCore.Migrations;

namespace PinArt_ProfileInfo_MS.Migrations
{
    public partial class Testing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Gustos",
                table: "Profiles",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gustos",
                table: "Profiles");
        }
    }
}
