using Microsoft.EntityFrameworkCore.Migrations;

namespace PinArt_ProfileInfo_MS.Migrations
{
    public partial class CompleteDBv7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profiles_Countries_CountryId",
                table: "Profiles");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Causes_CauseId",
                table: "Reports");

            migrationBuilder.DropIndex(
                name: "IX_Reports_CauseId",
                table: "Reports");

            migrationBuilder.DropIndex(
                name: "IX_Profiles_CountryId",
                table: "Profiles");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Reports_CauseId",
                table: "Reports",
                column: "CauseId");

            migrationBuilder.CreateIndex(
                name: "IX_Profiles_CountryId",
                table: "Profiles",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Profiles_Countries_CountryId",
                table: "Profiles",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_Causes_CauseId",
                table: "Reports",
                column: "CauseId",
                principalTable: "Causes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
